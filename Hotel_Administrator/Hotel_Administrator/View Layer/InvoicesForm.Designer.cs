namespace Hotel_Administrator
{
    partial class InvoicesForm
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
            this.invoicesTable = new System.Windows.Forms.DataGridView();
            this.invoiceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCoulmn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicesTable
            // 
            this.invoicesTable.AllowUserToAddRows = false;
            this.invoicesTable.AllowUserToDeleteRows = false;
            this.invoicesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceColumn,
            this.buttonCoulmn});
            this.invoicesTable.Location = new System.Drawing.Point(12, 12);
            this.invoicesTable.Name = "invoicesTable";
            this.invoicesTable.ReadOnly = true;
            this.invoicesTable.RowHeadersVisible = false;
            this.invoicesTable.Size = new System.Drawing.Size(443, 319);
            this.invoicesTable.TabIndex = 0;
            this.invoicesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.openInvoice);
            // 
            // invoiceColumn
            // 
            this.invoiceColumn.HeaderText = "Квитанция";
            this.invoiceColumn.Name = "invoiceColumn";
            this.invoiceColumn.ReadOnly = true;
            this.invoiceColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.invoiceColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.invoiceColumn.Width = 315;
            // 
            // buttonCoulmn
            // 
            this.buttonCoulmn.HeaderText = "";
            this.buttonCoulmn.Name = "buttonCoulmn";
            this.buttonCoulmn.ReadOnly = true;
            this.buttonCoulmn.Text = "Открыть";
            this.buttonCoulmn.UseColumnTextForButtonValue = true;
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 343);
            this.Controls.Add(this.invoicesTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InvoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Квитанции";
            ((System.ComponentModel.ISupportInitialize)(this.invoicesTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView invoicesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn buttonCoulmn;
    }
}