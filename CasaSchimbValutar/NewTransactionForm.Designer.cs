
namespace CasaSchimbValutar
{
    partial class NewTransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbCNP = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.lbConverted = new System.Windows.Forms.Label();
            this.lbOriginal = new System.Windows.Forms.Label();
            this.cbCurr2 = new System.Windows.Forms.ComboBox();
            this.cbCurr1 = new System.Windows.Forms.ComboBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnCancelConverter = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.errCNP = new System.Windows.Forms.ErrorProvider(this.components);
            this.lnkTOS = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errTOS = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errCNP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(74, 88);
            this.txtID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(272, 31);
            this.txtID.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(374, 47);
            this.lbName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 30);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.Location = new System.Drawing.Point(708, 52);
            this.lbSurname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(117, 30);
            this.lbSurname.TabIndex = 3;
            this.lbSurname.Text = "Surname";
            // 
            // lbCNP
            // 
            this.lbCNP.AutoSize = true;
            this.lbCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCNP.Location = new System.Drawing.Point(375, 135);
            this.lbCNP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCNP.Name = "lbCNP";
            this.lbCNP.Size = new System.Drawing.Size(213, 30);
            this.lbCNP.TabIndex = 4;
            this.lbCNP.Text = "CNP / ID Number";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(380, 87);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 31);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(714, 88);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(272, 31);
            this.txtSurname.TabIndex = 6;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(381, 171);
            this.txtCNP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(299, 31);
            this.txtCNP.TabIndex = 7;
            this.txtCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNP_KeyPress);
            this.txtCNP.Validating += new System.ComponentModel.CancelEventHandler(this.txtCNP_Validating);
            this.txtCNP.Validated += new System.EventHandler(this.txtCNP_Validated);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.Location = new System.Drawing.Point(68, 125);
            this.lbDateTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(74, 30);
            this.lbDateTime.TabIndex = 9;
            this.lbDateTime.Text = "Date ";
            
            // 
            // txtDateTime
            // 
            this.txtDateTime.Enabled = false;
            this.txtDateTime.Location = new System.Drawing.Point(74, 161);
            this.txtDateTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(272, 31);
            this.txtDateTime.TabIndex = 10;
            this.txtDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbConverted
            // 
            this.lbConverted.AutoSize = true;
            this.lbConverted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConverted.Location = new System.Drawing.Point(595, 217);
            this.lbConverted.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbConverted.Name = "lbConverted";
            this.lbConverted.Size = new System.Drawing.Size(223, 30);
            this.lbConverted.TabIndex = 17;
            this.lbConverted.Text = "Converted amount";
            // 
            // lbOriginal
            // 
            this.lbOriginal.AutoSize = true;
            this.lbOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOriginal.Location = new System.Drawing.Point(72, 217);
            this.lbOriginal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbOriginal.Name = "lbOriginal";
            this.lbOriginal.Size = new System.Drawing.Size(194, 30);
            this.lbOriginal.TabIndex = 16;
            this.lbOriginal.Text = "Original amount";
            // 
            // cbCurr2
            // 
            this.cbCurr2.FormattingEnabled = true;
            this.cbCurr2.Items.AddRange(new object[] {
            "RON",
            "EUR",
            "USD",
            "GBP",
            "CHF"});
            this.cbCurr2.Location = new System.Drawing.Point(845, 256);
            this.cbCurr2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCurr2.Name = "cbCurr2";
            this.cbCurr2.Size = new System.Drawing.Size(138, 33);
            this.cbCurr2.TabIndex = 14;
            this.cbCurr2.SelectionChangeCommitted += new System.EventHandler(this.cbCurr2_SelectionChangeCommitted);
            // 
            // cbCurr1
            // 
            this.cbCurr1.FormattingEnabled = true;
            this.cbCurr1.Items.AddRange(new object[] {
            "RON",
            "EUR",
            "USD",
            "GBP",
            "CHF"});
            this.cbCurr1.Location = new System.Drawing.Point(318, 256);
            this.cbCurr1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCurr1.Name = "cbCurr1";
            this.cbCurr1.Size = new System.Drawing.Size(138, 33);
            this.cbCurr1.TabIndex = 13;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(601, 256);
            this.txtTo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(224, 31);
            this.txtTo.TabIndex = 12;
            // 
            // txtFrom
            // 
            this.txtFrom.AcceptsReturn = true;
            this.txtFrom.Location = new System.Drawing.Point(78, 258);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(224, 31);
            this.txtFrom.TabIndex = 11;
            // 
            // btnCancelConverter
            // 
            this.btnCancelConverter.Location = new System.Drawing.Point(652, 338);
            this.btnCancelConverter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelConverter.Name = "btnCancelConverter";
            this.btnCancelConverter.Size = new System.Drawing.Size(150, 44);
            this.btnCancelConverter.TabIndex = 19;
            this.btnCancelConverter.Text = "Cancel";
            this.btnCancelConverter.UseVisualStyleBackColor = true;
            this.btnCancelConverter.Click += new System.EventHandler(this.btnCancelConverter_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(832, 338);
            this.btnTransaction.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(150, 44);
            this.btnTransaction.TabIndex = 20;
            this.btnTransaction.Text = "Convert";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // errCNP
            // 
            this.errCNP.ContainerControl = this;
            // 
            // lnkTOS
            // 
            this.lnkTOS.AutoSize = true;
            this.lnkTOS.Location = new System.Drawing.Point(374, 515);
            this.lnkTOS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lnkTOS.Name = "lnkTOS";
            this.lnkTOS.Size = new System.Drawing.Size(0, 25);
            this.lnkTOS.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(542, 513);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 30);
            this.label2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(657, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(964, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(657, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "*";
            // 
            // errTOS
            // 
            this.errTOS.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Currency";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(840, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Currency";
            // 
            // NewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 436);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkTOS);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnCancelConverter);
            this.Controls.Add(this.lbConverted);
            this.Controls.Add(this.lbOriginal);
            this.Controls.Add(this.cbCurr2);
            this.Controls.Add(this.cbCurr1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbCNP);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "NewTransactionForm";
            this.Text = "New Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.errCNP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbCNP;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.Label lbConverted;
        private System.Windows.Forms.Label lbOriginal;
        private System.Windows.Forms.ComboBox cbCurr2;
        private System.Windows.Forms.ComboBox cbCurr1;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnCancelConverter;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.ErrorProvider errCNP;
        private System.Windows.Forms.LinkLabel lnkTOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errTOS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}