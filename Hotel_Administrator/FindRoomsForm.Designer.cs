namespace Hotel_Administrator
{
    partial class FindRoomsForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.priceLabel1 = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.classCheckBox = new System.Windows.Forms.CheckBox();
            this.priceCheckBox = new System.Windows.Forms.CheckBox();
            this.capacityCheckBox = new System.Windows.Forms.CheckBox();
            this.findButton = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isEmptyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateLeaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.nothingFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.titleLabel.Location = new System.Drawing.Point(22, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(291, 18);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Выберите и установите критерии поиска";
            // 
            // priceLabel1
            // 
            this.priceLabel1.AutoSize = true;
            this.priceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceLabel1.Location = new System.Drawing.Point(324, 165);
            this.priceLabel1.Name = "priceLabel1";
            this.priceLabel1.Size = new System.Drawing.Size(33, 17);
            this.priceLabel1.TabIndex = 20;
            this.priceLabel1.Text = "грн.";
            // 
            // classTextBox
            // 
            this.classTextBox.Enabled = false;
            this.classTextBox.Location = new System.Drawing.Point(106, 95);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(100, 20);
            this.classTextBox.TabIndex = 19;
            this.classTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.classLabel.Location = new System.Drawing.Point(49, 96);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(51, 17);
            this.classLabel.TabIndex = 18;
            this.classLabel.Text = "Класс:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(219, 164);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 17;
            this.priceTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceLabel.Location = new System.Drawing.Point(49, 165);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(170, 17);
            this.priceLabel.TabIndex = 16;
            this.priceLabel.Text = "Цена за сутки не более ";
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Enabled = false;
            this.capacityTextBox.Location = new System.Drawing.Point(237, 128);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacityTextBox.TabIndex = 15;
            this.capacityTextBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.capacityLabel.Location = new System.Drawing.Point(49, 129);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(186, 17);
            this.capacityLabel.TabIndex = 14;
            this.capacityLabel.Text = "Количество мест не менее";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateLabel.Location = new System.Drawing.Point(49, 60);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(46, 17);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.Text = "Дата:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(106, 60);
            this.datePicker.MinDate = new System.DateTime(2015, 7, 6, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(148, 20);
            this.datePicker.TabIndex = 22;
            // 
            // classCheckBox
            // 
            this.classCheckBox.AutoSize = true;
            this.classCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.classCheckBox.Location = new System.Drawing.Point(25, 98);
            this.classCheckBox.Name = "classCheckBox";
            this.classCheckBox.Size = new System.Drawing.Size(15, 14);
            this.classCheckBox.TabIndex = 23;
            this.classCheckBox.UseVisualStyleBackColor = true;
            this.classCheckBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // priceCheckBox
            // 
            this.priceCheckBox.AutoSize = true;
            this.priceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceCheckBox.Location = new System.Drawing.Point(25, 167);
            this.priceCheckBox.Name = "priceCheckBox";
            this.priceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.priceCheckBox.TabIndex = 24;
            this.priceCheckBox.UseVisualStyleBackColor = true;
            this.priceCheckBox.Click += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // capacityCheckBox
            // 
            this.capacityCheckBox.AutoSize = true;
            this.capacityCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.capacityCheckBox.Location = new System.Drawing.Point(25, 131);
            this.capacityCheckBox.Name = "capacityCheckBox";
            this.capacityCheckBox.Size = new System.Drawing.Size(15, 14);
            this.capacityCheckBox.TabIndex = 25;
            this.capacityCheckBox.UseVisualStyleBackColor = true;
            this.capacityCheckBox.Click += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.findButton.Location = new System.Drawing.Point(148, 225);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(86, 27);
            this.findButton.TabIndex = 26;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // searchResult
            // 
            this.searchResult.AllowDrop = true;
            this.searchResult.AllowUserToAddRows = false;
            this.searchResult.AllowUserToDeleteRows = false;
            this.searchResult.AllowUserToResizeColumns = false;
            this.searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.pricePerDayDataGridViewTextBoxColumn,
            this.isEmptyDataGridViewCheckBoxColumn,
            this.dateLeaveDataGridViewTextBoxColumn});
            this.searchResult.Location = new System.Drawing.Point(387, 54);
            this.searchResult.Name = "searchResult";
            this.searchResult.ReadOnly = true;
            this.searchResult.RowHeadersVisible = false;
            this.searchResult.Size = new System.Drawing.Size(401, 323);
            this.searchResult.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(384, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Результаты поиска:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер комнаты";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 55;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.ReadOnly = true;
            this.classDataGridViewTextBoxColumn.Width = 80;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Кол-во мест";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.ToolTipText = "Максимальное количество гостей";
            this.capacityDataGridViewTextBoxColumn.Width = 45;
            // 
            // pricePerDayDataGridViewTextBoxColumn
            // 
            this.pricePerDayDataGridViewTextBoxColumn.DataPropertyName = "PricePerDay";
            this.pricePerDayDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.pricePerDayDataGridViewTextBoxColumn.Name = "pricePerDayDataGridViewTextBoxColumn";
            this.pricePerDayDataGridViewTextBoxColumn.ReadOnly = true;
            this.pricePerDayDataGridViewTextBoxColumn.ToolTipText = "Цена за сутки в гривнах";
            this.pricePerDayDataGridViewTextBoxColumn.Width = 60;
            // 
            // isEmptyDataGridViewCheckBoxColumn
            // 
            this.isEmptyDataGridViewCheckBoxColumn.DataPropertyName = "IsEmpty";
            this.isEmptyDataGridViewCheckBoxColumn.HeaderText = "Свободна";
            this.isEmptyDataGridViewCheckBoxColumn.Name = "isEmptyDataGridViewCheckBoxColumn";
            this.isEmptyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isEmptyDataGridViewCheckBoxColumn.ToolTipText = "Свободна ли комната";
            this.isEmptyDataGridViewCheckBoxColumn.Width = 60;
            // 
            // dateLeaveDataGridViewTextBoxColumn
            // 
            this.dateLeaveDataGridViewTextBoxColumn.DataPropertyName = "DateLeave";
            this.dateLeaveDataGridViewTextBoxColumn.HeaderText = "Выезд гостей";
            this.dateLeaveDataGridViewTextBoxColumn.Name = "dateLeaveDataGridViewTextBoxColumn";
            this.dateLeaveDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateLeaveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateLeaveDataGridViewTextBoxColumn.ToolTipText = "Дата выезда текущих постояльцев комнаты";
            this.dateLeaveDataGridViewTextBoxColumn.Width = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Нажмите на заголовок столбца для сортировки по заданному параметру";
            // 
            // nothingFound
            // 
            this.nothingFound.AutoSize = true;
            this.nothingFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nothingFound.ForeColor = System.Drawing.Color.Red;
            this.nothingFound.Location = new System.Drawing.Point(530, 21);
            this.nothingFound.Name = "nothingFound";
            this.nothingFound.Size = new System.Drawing.Size(137, 18);
            this.nothingFound.TabIndex = 30;
            this.nothingFound.Text = "ничего не найдено";
            this.nothingFound.Visible = false;
            // 
            // FindRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.nothingFound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.capacityCheckBox);
            this.Controls.Add(this.priceCheckBox);
            this.Controls.Add(this.classCheckBox);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.priceLabel1);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FindRoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск свободных номеров";
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label priceLabel1;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox capacityTextBox;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.CheckBox classCheckBox;
        private System.Windows.Forms.CheckBox priceCheckBox;
        private System.Windows.Forms.CheckBox capacityCheckBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.DataGridView searchResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEmptyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLeaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label nothingFound;
        private System.Windows.Forms.Label label2;
    }
}