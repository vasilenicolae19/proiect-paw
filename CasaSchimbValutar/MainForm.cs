using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace CasaSchimbValutar
{
    public partial class MainForm : Form
    {
        #region Attributes
        private const string connectionDB = "Data Source=database.db";
        private readonly List<Transaction> transactions;
        #endregion

        public MainForm()
        {
            transactions = new List<Transaction>();
            InitializeComponent();
        }

        #region Methods
        public void displayTransactions()
        {
            lvTransactions.Items.Clear();
            foreach (Transaction t in transactions)
            {
                var lvItem = new ListViewItem(t.id.ToString());
                lvItem.SubItems.Add(t.transactionDate.ToShortDateString());
                lvItem.SubItems.Add(t.name);
                lvItem.SubItems.Add(t.surname);
                lvItem.SubItems.Add(t.CNP);
                lvItem.SubItems.Add(t.amount.ToString());
                lvItem.SubItems.Add(t.currencyFrom.iso);
                lvItem.SubItems.Add(t.endAmount.ToString());
                lvItem.SubItems.Add(t.currencyTo.iso);
                lvItem.Tag = t;
                lvTransactions.Items.Add(lvItem);
            }
        }

        private void loadTransactions()
        {
            const string cmdSQL = "SELECT * FROM Transactions";
            using (SQLiteConnection connection = new SQLiteConnection(connectionDB))
            {
                connection.Open();
                var cmd = new SQLiteCommand(cmdSQL, connection);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = (long)reader["id"];
                        string td = (string)reader["transactionDate"];
                        DateTime transactionDate = DateTime.Parse(td);
                        string name = (string)reader["name"];
                        string surname = (string)reader["surname"];
                        string CNP = (string)reader["CNP"];
                        double amount = double.Parse(reader["amount"].ToString());
                        Currency c1 = new Currency();
                        c1.iso = (string)reader["currencyFrom"];
                        double endAmount = double.Parse(reader["endAmount"].ToString());
                        Currency c2 = new Currency();
                        c2.iso = (string)reader["currencyTo"];

                        Transaction _t = new Transaction(id, name, surname, CNP, amount, c1, endAmount, c2, transactionDate);
                        transactions.Add(_t);
                    }
                }
            }
        }

        private void deleteTransaction(Transaction t)
        {
            const string cmdDel = "DELETE FROM Transactions WHERE id=@id";
            using (SQLiteConnection connection = new SQLiteConnection(connectionDB))
            {
                connection.Open();
                var cmd = new SQLiteCommand(cmdDel, connection);
                cmd.Parameters.AddWithValue("@id", t.id);
                cmd.ExecuteNonQuery();
                transactions.Remove(t);
            }
        }

        private void btnNewTClick(object sender, EventArgs e)
        {
            Form NewTransactionForm = new NewTransactionForm();
            NewTransactionForm.ShowDialog();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Form NewConversionForm = new ConversionForm();
            NewConversionForm.ShowDialog();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadTransactions();
                displayTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string transactionID = "";
        public static string transactionName = "";
        public static string transactionSurname = "";
        public static string transactionDate = "";
        public static string transactionCNP = "";
        public static string transactionAmount = "";
        public static string transactionCurr1 = "";
        public static string transactionEndAmount = "";
        public static string transactionCurr2 = "";

        private void lvTransactions_DoubleClick(object sender, EventArgs e)
        {
            Transaction temp = new Transaction();
            if (lvTransactions.SelectedItems.Count > 0)
            {
                foreach(ListViewItem lv in lvTransactions.SelectedItems)
				{

                    temp = (Transaction)lv.Tag;
                }
            }

            transactionID = temp.id.ToString();
            transactionName = temp.name;
            transactionSurname = temp.surname;
            transactionDate = temp.transactionDate.ToShortDateString();
            transactionCNP = temp.CNP;
            transactionAmount = temp.amount.ToString();
            transactionCurr1 = temp.currencyFrom.iso.ToString();
            transactionEndAmount = temp.endAmount.ToString();
            transactionCurr2 = temp.currencyTo.iso.ToString();

            Form ViewTransaction = new ViewTransaction();
            ViewTransaction.ShowDialog();
        }

		private void copyDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if(lvTransactions.SelectedItems.Count >= 0)
			{
                Clipboard.Clear();
                StringBuilder sb = new StringBuilder();
                Transaction aux = new Transaction();

                foreach(ListViewItem lv in lvTransactions.SelectedItems)
				{
                    aux = (Transaction)lv.Tag;
				}

                sb.Append("ID: ");
                sb.Append(aux.id); 
                sb.Append(", Name: ");
                sb.Append(aux.name);
                sb.Append(", Surname: ");
                sb.Append(aux.surname);
                sb.Append(", Date: ");
                sb.Append(aux.transactionDate.ToShortDateString());
                sb.Append(", CNP/ID nr.: ");
                sb.Append(aux.CNP);
                sb.Append(", Amount: ");
                sb.Append(aux.amount.ToString());
                sb.Append(" ");
                sb.Append(aux.currencyFrom.iso);
                sb.Append(", End amount: ");
                sb.Append(aux.endAmount.ToString());
                sb.Append(" ");
                sb.Append(aux.currencyTo.iso);
                sb.Append(". ");

                Clipboard.SetText(sb.ToString());
            }
		}
	
		private void btnRefresh_Click(object sender, EventArgs e)
		{
            transactions.Clear();
            loadTransactions();
            displayTransactions();   
		}

		private void serializationToolStripMenuItem_Click(object sender, EventArgs e)
		{
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.Create("transactions.bin"))
			{
                    formatter.Serialize(fs, transactions);
            }
            MessageBox.Show("Transactions serialized.", "Confirmation.", MessageBoxButtons.OK);

        }

        private void deserializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Transaction> _transactions = new List<Transaction>();
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = File.OpenRead("transactions.bin"))
            {
                _transactions = (List<Transaction>)formatter.Deserialize(fs);
                lvTransactions.Items.Clear();
                foreach (Transaction a in _transactions)
                {
                    var lvItem = new ListViewItem(a.id.ToString());
                    lvItem.SubItems.Add(a.transactionDate.ToShortDateString());
                    lvItem.SubItems.Add(a.name);
                    lvItem.SubItems.Add(a.surname);
                    lvItem.SubItems.Add(a.CNP);
                    lvItem.SubItems.Add(a.amount.ToString());
                    lvItem.SubItems.Add(a.currencyFrom.iso);
                    lvItem.SubItems.Add(a.endAmount.ToString());
                    lvItem.SubItems.Add(a.currencyTo.iso);         
                    lvItem.Tag = a;
                    lvTransactions.Items.Add(lvItem);
                }
            }
            MessageBox.Show("Transaction deserialized.", "Confirmation.", MessageBoxButtons.OK);
        }

		private void exportAscsvFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("ID, Name, Surname, Transaction Date, CNP, Initial amount, Currency, End amount, Currency");
                    foreach (Transaction transaction in transactions)
                    {
                        sw.WriteLine(transaction.id + ", " + transaction.name + ", " + transaction.surname + ", "
                            + transaction.transactionDate.ToShortDateString() + ", " + transaction.CNP + ", " + transaction.amount +
                                ", " + transaction.currencyFrom.iso + ", " + transaction.endAmount
                                    + ", " + transaction.currencyTo.iso);
                    }
                    sw.Close();
                }
            }
        }

		private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
		{
            if (lvTransactions.SelectedItems.Count > 0)
            {
                var result = MessageBox.Show("Are you sure that you would like to delete this transaction?", "Confirm delete.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem lv in lvTransactions.SelectedItems)
                    {
                        Transaction aux = new Transaction();
                        aux = (Transaction)lv.Tag;
                        foreach (Transaction t in transactions.ToList())
                        {
                            if (aux.id == t.id)
                            {
                                transactions.Remove(t);
                                deleteTransaction(aux);
                            }
                        } 
                    }
                }
            }
        }

		private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
		{
            psd.PageSettings = printDocument.DefaultPageSettings;
            if (psd.ShowDialog() == DialogResult.OK)
			{
                printDocument.DefaultPageSettings = psd.PageSettings;
            }
        }

		private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
            Font f = new Font("Calibri", 16);
            int currentY = printDocument.DefaultPageSettings.Margins.Top;

            while (currentPrintIndex < transactions.Count)
            {
                Transaction t = transactions[currentPrintIndex];
				e.Graphics.DrawString($"{t.id}, {t.name}, {t.surname}, {t.CNP}, {t.amount}, {t.currencyFrom.iso}, " +
                    $"{t.endAmount}, {t.currencyTo.iso}", f, Brushes.Black,
                    printDocument.DefaultPageSettings.Margins.Left, currentY);

                currentY += 40;

                if (currentY > e.MarginBounds.Height)
                {
                    e.HasMorePages = true;
                    break; 
                }

                currentPrintIndex++;
            }
        }

        int currentPrintIndex = 0;

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{
            currentPrintIndex = 0;
		}

		private void printPreviewDialog_Click(object sender, EventArgs e)
		{
            printPreviewDialog.ShowDialog();
		}

		private void printToolStripMenuItem1_Click(object sender, EventArgs e)
		{
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }
	}	
}
