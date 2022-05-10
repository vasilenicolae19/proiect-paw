using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CasaSchimbValutar
{
    public partial class NewTransactionForm : Form 
	{
		#region Attributes
		private const string connectionDB = "Data Source=database.db";
        private readonly List<Currency> currencies = new List<Currency>();
		#endregion

		public NewTransactionForm()
        {
            InitializeComponent();
            Transaction t = new Transaction();
            const string cmdCheck = "SELECT id FROM Transactions ORDER BY ID DESC LIMIT 1;";
            using(SQLiteConnection connection = new SQLiteConnection(connectionDB))
			{
                connection.Open();
                var command = new SQLiteCommand(cmdCheck, connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
                        int aux = Convert.ToInt32(reader["id"]);
                        t.id = ++aux;
					}
				}
			}
            
            txtID.Text = t.id.ToString();
            DateTime d = new DateTime();
            d = DateTime.Now;
            txtDateTime.Text = d.ToShortDateString();
            loadCurrency();
        }
        private void loadCurrency()
        {
            const string cmdSQL = "SELECT * FROM Currency;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionDB))
            {
                connection.Open();
                var command = new SQLiteCommand(cmdSQL, connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
					while (reader.Read())
                    {
                        String name = (String)reader["name"];
                        String iso = (string)reader["iso"];
                        ExchangeRate r = new ExchangeRate();
                        r.rate = Convert.ToDouble(reader["rate"]);
                        Currency c = new Currency(name, iso, r);
                        currencies.Add(c);
                        Console.WriteLine(c.iso);
                    }
                }
            }
        }

        private void txtCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelConverter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         List <Transaction>transactionList = new List<Transaction>();
        
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            Transaction t = new Transaction();
            t.id = int.Parse(txtID.Text);
            t.name = txtName.Text;
            t.surname = txtSurname.Text;
            t.CNP = txtCNP.Text;
            t.amount = float.Parse(txtFrom.Text);
            foreach(Currency c in currencies)
			{
                if (cbCurr1.SelectedItem.ToString() == c.iso.ToString())
				{
                    t.currencyFrom = c;
                    break;
				}
			}
            t.endAmount = float.Parse(txtTo.Text); 
            foreach (Currency c in currencies)
            {
                if (cbCurr2.SelectedItem.ToString() == c.iso.ToString())
                {
                    t.currencyTo = c;
                    break;
                }
            }
            t.transactionDate = DateTime.Parse(txtDateTime.Text);

            if (!ValidateChildren())
            {
                MessageBox.Show("The input is invalid!", "Invalid input", MessageBoxButtons.OK);
            }
			else
			{
                var cmdAddTransaction = "INSERT INTO Transactions(id, transactionDate, name, surname, CNP, amount, currencyFrom, endAmount, currencyTo)" +
                    " VALUES(@id, @transactionDate, @name, @surname, @CNP, @amount, @currencyFrom, @endAmount, @currencyTo);";

                using (SQLiteConnection connection = new SQLiteConnection(connectionDB))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(cmdAddTransaction, connection);
                    command.Parameters.AddWithValue("@id", t.id); //au buba
                    command.Parameters.AddWithValue("@transactionDate", t.transactionDate);
                    command.Parameters.AddWithValue("@name", t.name);
                    command.Parameters.AddWithValue("@surname", t.surname);
                    command.Parameters.AddWithValue("@CNP", t.CNP);
                    command.Parameters.AddWithValue("@amount", t.amount);
                    command.Parameters.AddWithValue("@currencyFrom", t.currencyFrom.iso);
                    command.Parameters.AddWithValue("@endAmount", t.endAmount);
                    command.Parameters.AddWithValue("@currencyTo", t.currencyTo.iso);
                    command.ExecuteNonQuery();
                    transactionList.Add(t);
                }

                var result = MessageBox.Show("Do you want to register a new transaction?", "Yes/No", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    
                }
                else
                   Close();
            }   
        }

        private void txtCNP_Validating(object sender, CancelEventArgs e)
        {
            if(txtCNP.TextLength < 12)
            {
                e.Cancel = true;
                errCNP.SetError((Control)sender, "The ID is too short. Please review your input.");
            }
        }

        private void txtCNP_Validated(object sender, EventArgs e)
        {
            errCNP.SetError((Control)sender, String.Empty);
        }

		private void cbCurr2_SelectionChangeCommitted(object sender, EventArgs e)
		{
            String a = txtFrom.Text;
            double b = double.Parse(a);
            double result = 0;
            if (b >= 0)
            {
                switch (cbCurr1.SelectedItem)
                {
                    case "RON":
                        result = b;
                        break;
                    case "EUR":
                        result = (double)(b / 0.2);
                        break;
                    case "USD":
                        result = (double)(b / 0.24);
                        break;
                    case "GBP":
                        result = (double)(b / 0.18);
                        break;
                    case "CHF":
                        result = (double)(b / 0.22);
                        break;
                    default:
                        MessageBox.Show("No currency selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            double aux = 1;
            switch (cbCurr2.SelectedItem)
            {
                case "RON":
                    txtTo.Text = Math.Round(result, 2).ToString();
                    break;
                case "EUR":
                    aux = result * 0.2;
                    txtTo.Text = Math.Round(aux, 2).ToString();
                    break;
                case "USD":
                    aux = result * 0.24;
                    txtTo.Text = Math.Round(aux, 2).ToString();
                    break;
                case "GBP":
                    aux = result * 0.18;
                    txtTo.Text = Math.Round(aux, 2).ToString();
                    break;
                case "CHF":
                    aux = result * 0.22;
                    txtTo.Text = Math.Round(aux, 2).ToString();
                    break;
                default:
                    MessageBox.Show("Please input the amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
