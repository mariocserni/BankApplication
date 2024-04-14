namespace ApplicationUI
{
    partial class WithdrawForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.recentLabel = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.withdrawAmountLabel = new System.Windows.Forms.Label();
            this.withdrawsTable = new System.Windows.Forms.DataGridView();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.withdrawAmountError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.withdrawsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawAmountError)).BeginInit();
            this.SuspendLayout();
            // 
            // recentLabel
            // 
            this.recentLabel.AutoSize = true;
            this.recentLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.recentLabel.Location = new System.Drawing.Point(556, 71);
            this.recentLabel.Name = "recentLabel";
            this.recentLabel.Size = new System.Drawing.Size(215, 32);
            this.recentLabel.TabIndex = 17;
            this.recentLabel.Text = "Recent withdraws";
            // 
            // withdrawButton
            // 
            this.withdrawButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.withdrawButton.FlatAppearance.BorderSize = 0;
            this.withdrawButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawButton.ForeColor = System.Drawing.Color.White;
            this.withdrawButton.Location = new System.Drawing.Point(169, 268);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(131, 39);
            this.withdrawButton.TabIndex = 16;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTextBox.Location = new System.Drawing.Point(129, 197);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(210, 29);
            this.amountTextBox.TabIndex = 15;
            // 
            // withdrawAmountLabel
            // 
            this.withdrawAmountLabel.AutoSize = true;
            this.withdrawAmountLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawAmountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(61)))), ((int)(((byte)(111)))));
            this.withdrawAmountLabel.Location = new System.Drawing.Point(115, 162);
            this.withdrawAmountLabel.Name = "withdrawAmountLabel";
            this.withdrawAmountLabel.Size = new System.Drawing.Size(239, 32);
            this.withdrawAmountLabel.TabIndex = 14;
            this.withdrawAmountLabel.Text = "Withdraw Amount :";
            // 
            // withdrawsTable
            // 
            this.withdrawsTable.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.withdrawsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.withdrawsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.withdrawsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountColumn,
            this.dateColumn});
            this.withdrawsTable.Location = new System.Drawing.Point(494, 106);
            this.withdrawsTable.Name = "withdrawsTable";
            this.withdrawsTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.withdrawsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.withdrawsTable.Size = new System.Drawing.Size(338, 490);
            this.withdrawsTable.TabIndex = 13;
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
            // withdrawAmountError
            // 
            this.withdrawAmountError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.withdrawAmountError.ContainerControl = this;
            // 
            // WithdrawForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 666);
            this.Controls.Add(this.recentLabel);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.withdrawAmountLabel);
            this.Controls.Add(this.withdrawsTable);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WithdrawForm";
            this.Text = "WithdrawForm";
            ((System.ComponentModel.ISupportInitialize)(this.withdrawsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawAmountError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recentLabel;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label withdrawAmountLabel;
        private System.Windows.Forms.DataGridView withdrawsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.ErrorProvider withdrawAmountError;
    }
}