namespace ApplicationUI
{
    partial class DepositForm
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
            this.depositsTable = new System.Windows.Forms.DataGridView();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositAmountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.recentLabel = new System.Windows.Forms.Label();
            this.depositAmountError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.depositsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositAmountError)).BeginInit();
            this.SuspendLayout();
            // 
            // depositsTable
            // 
            this.depositsTable.BackgroundColor = System.Drawing.Color.White;
            this.depositsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.depositsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountColumn,
            this.dateColumn});
            this.depositsTable.Location = new System.Drawing.Point(498, 104);
            this.depositsTable.Name = "depositsTable";
            this.depositsTable.ReadOnly = true;
            this.depositsTable.Size = new System.Drawing.Size(338, 490);
            this.depositsTable.TabIndex = 0;
            // 
            // amountColumn
            // 
            this.amountColumn.HeaderText = "Amount";
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.ReadOnly = true;
            this.amountColumn.Width = 120;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Date";
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 175;
            // 
            // depositAmountLabel
            // 
            this.depositAmountLabel.AutoSize = true;
            this.depositAmountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.depositAmountLabel.Location = new System.Drawing.Point(112, 160);
            this.depositAmountLabel.Name = "depositAmountLabel";
            this.depositAmountLabel.Size = new System.Drawing.Size(216, 32);
            this.depositAmountLabel.TabIndex = 9;
            this.depositAmountLabel.Text = "Deposit Amount :";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(115, 195);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(210, 29);
            this.amountTextBox.TabIndex = 10;
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.depositButton.FlatAppearance.BorderSize = 0;
            this.depositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depositButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.ForeColor = System.Drawing.Color.White;
            this.depositButton.Location = new System.Drawing.Point(155, 266);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(131, 39);
            this.depositButton.TabIndex = 11;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // recentLabel
            // 
            this.recentLabel.AutoSize = true;
            this.recentLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.recentLabel.Location = new System.Drawing.Point(570, 69);
            this.recentLabel.Name = "recentLabel";
            this.recentLabel.Size = new System.Drawing.Size(194, 32);
            this.recentLabel.TabIndex = 12;
            this.recentLabel.Text = "Recent deposits";
            // 
            // depositAmountError
            // 
            this.depositAmountError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.depositAmountError.ContainerControl = this;
            // 
            // DepositForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 666);
            this.Controls.Add(this.recentLabel);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.depositAmountLabel);
            this.Controls.Add(this.depositsTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepositForm";
            this.Text = "DepositForm";
            ((System.ComponentModel.ISupportInitialize)(this.depositsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositAmountError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView depositsTable;
        private System.Windows.Forms.Label depositAmountLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Label recentLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.ErrorProvider depositAmountError;
    }
}