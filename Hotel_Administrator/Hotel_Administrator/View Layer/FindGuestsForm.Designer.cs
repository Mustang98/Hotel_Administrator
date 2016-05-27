namespace Hotel_Administrator
{
    partial class FindGuestsForm
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
            this.nothingFound = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchResult = new System.Windows.Forms.DataGridView();
            this.findButton = new System.Windows.Forms.Button();
            this.surNameCheckBox = new System.Windows.Forms.CheckBox();
            this.phoneCheckBox = new System.Windows.Forms.CheckBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.enterDatePicker = new System.Windows.Forms.DateTimePicker();
            this.enterLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.surNameTextBox = new System.Windows.Forms.TextBox();
            this.surNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.enterCheckBox = new System.Windows.Forms.CheckBox();
            this.leaveCheckBox = new System.Windows.Forms.CheckBox();
            this.leaveDatePicker = new System.Windows.Forms.DateTimePicker();
            this.leaveLabel = new System.Windows.Forms.Label();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // nothingFound
            // 
            this.nothingFound.AutoSize = true;
            this.nothingFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nothingFound.ForeColor = System.Drawing.Color.Red;
            this.nothingFound.Location = new System.Drawing.Point(483, 20);
            this.nothingFound.Name = "nothingFound";
            this.nothingFound.Size = new System.Drawing.Size(137, 18);
            this.nothingFound.TabIndex = 48;
            this.nothingFound.Text = "ничего не найдено";
            this.nothingFound.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(337, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Результаты поиска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Нажмите на заголовок столбца для сортировки по заданному параметру";
            // 
            // searchResult
            // 
            this.searchResult.AllowDrop = true;
            this.searchResult.AllowUserToAddRows = false;
            this.searchResult.AllowUserToDeleteRows = false;
            this.searchResult.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.roomColumn,
            this.pricePerDayDataGridViewTextBoxColumn,
            this.dateLeaveDataGridViewTextBoxColumn});
            this.searchResult.Location = new System.Drawing.Point(340, 53);
            this.searchResult.Name = "searchResult";
            this.searchResult.ReadOnly = true;
            this.searchResult.RowHeadersVisible = false;
            this.searchResult.Size = new System.Drawing.Size(511, 323);
            this.searchResult.TabIndex = 45;
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.findButton.Location = new System.Drawing.Point(148, 252);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(86, 27);
            this.findButton.TabIndex = 44;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // surNameCheckBox
            // 
            this.surNameCheckBox.AutoSize = true;
            this.surNameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.surNameCheckBox.Location = new System.Drawing.Point(25, 90);
            this.surNameCheckBox.Name = "surNameCheckBox";
            this.surNameCheckBox.Size = new System.Drawing.Size(15, 14);
            this.surNameCheckBox.TabIndex = 43;
            this.surNameCheckBox.UseVisualStyleBackColor = true;
            this.surNameCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // phoneCheckBox
            // 
            this.phoneCheckBox.AutoSize = true;
            this.phoneCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phoneCheckBox.Location = new System.Drawing.Point(25, 126);
            this.phoneCheckBox.Name = "phoneCheckBox";
            this.phoneCheckBox.Size = new System.Drawing.Size(15, 14);
            this.phoneCheckBox.TabIndex = 42;
            this.phoneCheckBox.UseVisualStyleBackColor = true;
            this.phoneCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameCheckBox.Location = new System.Drawing.Point(25, 57);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(15, 14);
            this.nameCheckBox.TabIndex = 41;
            this.nameCheckBox.UseVisualStyleBackColor = true;
            this.nameCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // enterDatePicker
            // 
            this.enterDatePicker.Enabled = false;
            this.enterDatePicker.Location = new System.Drawing.Point(148, 160);
            this.enterDatePicker.MinDate = new System.DateTime(2015, 7, 6, 0, 0, 0, 0);
            this.enterDatePicker.Name = "enterDatePicker";
            this.enterDatePicker.Size = new System.Drawing.Size(148, 20);
            this.enterDatePicker.TabIndex = 40;
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterLabel.Location = new System.Drawing.Point(49, 160);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(97, 17);
            this.enterLabel.TabIndex = 39;
            this.enterLabel.Text = "Дата въезда:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(94, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(113, 20);
            this.nameTextBox.TabIndex = 37;
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel.Location = new System.Drawing.Point(49, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 17);
            this.nameLabel.TabIndex = 36;
            this.nameLabel.Text = "Имя:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Enabled = false;
            this.phoneTextBox.Location = new System.Drawing.Point(127, 123);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(113, 20);
            this.phoneTextBox.TabIndex = 35;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.phoneLabel.Location = new System.Drawing.Point(49, 124);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(76, 17);
            this.phoneLabel.TabIndex = 34;
            this.phoneLabel.Text = "Телефон: ";
            // 
            // surNameTextBox
            // 
            this.surNameTextBox.Enabled = false;
            this.surNameTextBox.Location = new System.Drawing.Point(129, 87);
            this.surNameTextBox.Name = "surNameTextBox";
            this.surNameTextBox.Size = new System.Drawing.Size(113, 20);
            this.surNameTextBox.TabIndex = 33;
            this.surNameTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // surNameLabel
            // 
            this.surNameLabel.AutoSize = true;
            this.surNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.surNameLabel.Location = new System.Drawing.Point(49, 88);
            this.surNameLabel.Name = "surNameLabel";
            this.surNameLabel.Size = new System.Drawing.Size(74, 17);
            this.surNameLabel.TabIndex = 32;
            this.surNameLabel.Text = "Фамилия:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.titleLabel.Location = new System.Drawing.Point(22, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(291, 18);
            this.titleLabel.TabIndex = 31;
            this.titleLabel.Text = "Выберите и установите критерии поиска";
            // 
            // enterCheckBox
            // 
            this.enterCheckBox.AutoSize = true;
            this.enterCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterCheckBox.Location = new System.Drawing.Point(25, 162);
            this.enterCheckBox.Name = "enterCheckBox";
            this.enterCheckBox.Size = new System.Drawing.Size(15, 14);
            this.enterCheckBox.TabIndex = 49;
            this.enterCheckBox.UseVisualStyleBackColor = true;
            this.enterCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // leaveCheckBox
            // 
            this.leaveCheckBox.AutoSize = true;
            this.leaveCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.leaveCheckBox.Location = new System.Drawing.Point(25, 200);
            this.leaveCheckBox.Name = "leaveCheckBox";
            this.leaveCheckBox.Size = new System.Drawing.Size(15, 14);
            this.leaveCheckBox.TabIndex = 52;
            this.leaveCheckBox.UseVisualStyleBackColor = true;
            this.leaveCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // leaveDatePicker
            // 
            this.leaveDatePicker.Enabled = false;
            this.leaveDatePicker.Location = new System.Drawing.Point(158, 198);
            this.leaveDatePicker.MinDate = new System.DateTime(2015, 7, 6, 0, 0, 0, 0);
            this.leaveDatePicker.Name = "leaveDatePicker";
            this.leaveDatePicker.Size = new System.Drawing.Size(148, 20);
            this.leaveDatePicker.TabIndex = 51;
            // 
            // leaveLabel
            // 
            this.leaveLabel.AutoSize = true;
            this.leaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.leaveLabel.Location = new System.Drawing.Point(49, 198);
            this.leaveLabel.Name = "leaveLabel";
            this.leaveLabel.Size = new System.Drawing.Size(105, 17);
            this.leaveLabel.TabIndex = 50;
            this.leaveLabel.Text = "Дата отъезда:";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "nameColumn";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 95;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "surNameColumn";
            this.classDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "phoneColumn";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomColumn
            // 
            this.roomColumn.HeaderText = "Комн.";
            this.roomColumn.Name = "roomColumn";
            this.roomColumn.ReadOnly = true;
            this.roomColumn.ToolTipText = "Комната проживания";
            this.roomColumn.Width = 40;
            // 
            // pricePerDayDataGridViewTextBoxColumn
            // 
            this.pricePerDayDataGridViewTextBoxColumn.DataPropertyName = "leaveColumn";
            this.pricePerDayDataGridViewTextBoxColumn.HeaderText = "Въезд";
            this.pricePerDayDataGridViewTextBoxColumn.Name = "pricePerDayDataGridViewTextBoxColumn";
            this.pricePerDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricePerDayDataGridViewTextBoxColumn.Width = 75;
            // 
            // dateLeaveDataGridViewTextBoxColumn
            // 
            this.dateLeaveDataGridViewTextBoxColumn.DataPropertyName = "leaveColumn";
            this.dateLeaveDataGridViewTextBoxColumn.HeaderText = "Отъезд";
            this.dateLeaveDataGridViewTextBoxColumn.Name = "dateLeaveDataGridViewTextBoxColumn";
            this.dateLeaveDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateLeaveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateLeaveDataGridViewTextBoxColumn.Width = 75;
            // 
            // FindGuestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 398);
            this.Controls.Add(this.leaveCheckBox);
            this.Controls.Add(this.leaveDatePicker);
            this.Controls.Add(this.leaveLabel);
            this.Controls.Add(this.enterCheckBox);
            this.Controls.Add(this.nothingFound);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.surNameCheckBox);
            this.Controls.Add(this.phoneCheckBox);
            this.Controls.Add(this.nameCheckBox);
            this.Controls.Add(this.enterDatePicker);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.surNameTextBox);
            this.Controls.Add(this.surNameLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FindGuestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск гостей";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nothingFound;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView searchResult;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.CheckBox surNameCheckBox;
        private System.Windows.Forms.CheckBox phoneCheckBox;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.DateTimePicker enterDatePicker;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox surNameTextBox;
        private System.Windows.Forms.Label surNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckBox enterCheckBox;
        private System.Windows.Forms.CheckBox leaveCheckBox;
        private System.Windows.Forms.DateTimePicker leaveDatePicker;
        private System.Windows.Forms.Label leaveLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLeaveDataGridViewTextBoxColumn;
    }
}