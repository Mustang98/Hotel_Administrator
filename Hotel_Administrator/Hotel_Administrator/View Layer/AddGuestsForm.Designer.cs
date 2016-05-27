namespace Hotel_Administrator
{
    partial class AddGuestsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.guestsToAdd = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addGuestButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guestsToAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(214, 58);
            this.datePicker.MinDate = new System.DateTime(2015, 7, 6, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(148, 20);
            this.datePicker.TabIndex = 24;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateLabel.Location = new System.Drawing.Point(105, 59);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(105, 17);
            this.dateLabel.TabIndex = 23;
            this.dateLabel.Text = "Дата отъезда:";
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Location = new System.Drawing.Point(268, 24);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(51, 20);
            this.roomNumberTextBox.TabIndex = 26;
            this.roomNumberTextBox.TextChanged += new System.EventHandler(this.roomNumberTextBox_TextChanged);
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roomNumberLabel.Location = new System.Drawing.Point(151, 25);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(116, 17);
            this.roomNumberLabel.TabIndex = 25;
            this.roomNumberLabel.Text = "Номер комнаты:";
            // 
            // guestsToAdd
            // 
            this.guestsToAdd.AllowUserToAddRows = false;
            this.guestsToAdd.AllowUserToDeleteRows = false;
            this.guestsToAdd.AllowUserToResizeColumns = false;
            this.guestsToAdd.AllowUserToResizeRows = false;
            this.guestsToAdd.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guestsToAdd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.guestsToAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestsToAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.surNameColumn,
            this.phoneColumn,
            this.deleteColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guestsToAdd.DefaultCellStyle = dataGridViewCellStyle3;
            this.guestsToAdd.Location = new System.Drawing.Point(13, 132);
            this.guestsToAdd.Name = "guestsToAdd";
            this.guestsToAdd.RowHeadersVisible = false;
            this.guestsToAdd.RowTemplate.Height = 23;
            this.guestsToAdd.ShowCellToolTips = false;
            this.guestsToAdd.Size = new System.Drawing.Size(446, 167);
            this.guestsToAdd.TabIndex = 27;
            this.guestsToAdd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guestsToAdd_CellClick);
            this.guestsToAdd.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.guestsToAdd_CellValueChanged);
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Имя";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameColumn.Width = 135;
            // 
            // surNameColumn
            // 
            this.surNameColumn.HeaderText = "Фамилия";
            this.surNameColumn.Name = "surNameColumn";
            this.surNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.surNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.surNameColumn.Width = 130;
            // 
            // phoneColumn
            // 
            this.phoneColumn.HeaderText = "Телефон";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phoneColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.phoneColumn.Width = 130;
            // 
            // deleteColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            this.deleteColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteColumn.Text = "X";
            this.deleteColumn.UseColumnTextForButtonValue = true;
            this.deleteColumn.Width = 23;
            // 
            // addGuestButton
            // 
            this.addGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addGuestButton.Location = new System.Drawing.Point(13, 101);
            this.addGuestButton.Name = "addGuestButton";
            this.addGuestButton.Size = new System.Drawing.Size(125, 25);
            this.addGuestButton.TabIndex = 1;
            this.addGuestButton.Text = "Добавить гостя";
            this.addGuestButton.UseVisualStyleBackColor = true;
            this.addGuestButton.Click += new System.EventHandler(this.addGuestButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.submitButton.Location = new System.Drawing.Point(373, 307);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(86, 27);
            this.submitButton.TabIndex = 30;
            this.submitButton.Text = "Заселить";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AddGuestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 344);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.addGuestButton);
            this.Controls.Add(this.guestsToAdd);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddGuestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заселение гостей";
            ((System.ComponentModel.ISupportInitialize)(this.guestsToAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.DataGridView guestsToAdd;
        private System.Windows.Forms.Button addGuestButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}