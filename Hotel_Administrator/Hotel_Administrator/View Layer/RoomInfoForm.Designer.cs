namespace Hotel_Administrator
{
    partial class RoomInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInfoForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.guestTabel = new System.Windows.Forms.DataGridView();
            this.leaveLabel = new System.Windows.Forms.Label();
            this.isEmptyLabel = new System.Windows.Forms.Label();
            this.guestLabel = new System.Windows.Forms.Label();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestTabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(159, 4);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(130, 31);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Комната ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(165, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Состояние: ";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classLabel.Location = new System.Drawing.Point(165, 64);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(55, 17);
            this.classLabel.TabIndex = 3;
            this.classLabel.Text = "Класс: ";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capacityLabel.Location = new System.Drawing.Point(165, 86);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(70, 17);
            this.capacityLabel.TabIndex = 4;
            this.capacityLabel.Text = "Ёмкость: ";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(165, 108);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(110, 17);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Цена за сутки: ";
            // 
            // guestTabel
            // 
            this.guestTabel.AllowDrop = true;
            this.guestTabel.AllowUserToAddRows = false;
            this.guestTabel.AllowUserToDeleteRows = false;
            this.guestTabel.AllowUserToResizeColumns = false;
            this.guestTabel.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guestTabel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.guestTabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guestTabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.guestTabel.DataSource = this.guestBindingSource;
            this.guestTabel.Location = new System.Drawing.Point(12, 180);
            this.guestTabel.Name = "guestTabel";
            this.guestTabel.ReadOnly = true;
            this.guestTabel.RowHeadersVisible = false;
            this.guestTabel.Size = new System.Drawing.Size(348, 145);
            this.guestTabel.TabIndex = 46;
            // 
            // leaveLabel
            // 
            this.leaveLabel.AutoSize = true;
            this.leaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaveLabel.Location = new System.Drawing.Point(165, 132);
            this.leaveLabel.Name = "leaveLabel";
            this.leaveLabel.Size = new System.Drawing.Size(146, 17);
            this.leaveLabel.TabIndex = 48;
            this.leaveLabel.Text = "Выезд постояльцев: ";
            // 
            // isEmptyLabel
            // 
            this.isEmptyLabel.AutoSize = true;
            this.isEmptyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isEmptyLabel.Location = new System.Drawing.Point(244, 42);
            this.isEmptyLabel.Name = "isEmptyLabel";
            this.isEmptyLabel.Size = new System.Drawing.Size(46, 17);
            this.isEmptyLabel.TabIndex = 49;
            this.isEmptyLabel.Text = "label1";
            // 
            // guestLabel
            // 
            this.guestLabel.AutoSize = true;
            this.guestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guestLabel.Location = new System.Drawing.Point(12, 160);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(50, 17);
            this.guestLabel.TabIndex = 50;
            this.guestLabel.Text = "Гости:";
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataSource = typeof(Hotel_Administrator.Guest);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn.Width = 110;
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            this.surNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.surNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phoneDataGridViewTextBoxColumn.Width = 105;
            // 
            // RoomInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 337);
            this.Controls.Add(this.guestLabel);
            this.Controls.Add(this.isEmptyLabel);
            this.Controls.Add(this.leaveLabel);
            this.Controls.Add(this.guestTabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RoomInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация о конмнате";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestTabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.DataGridView guestTabel;
        private System.Windows.Forms.Label leaveLabel;
        private System.Windows.Forms.Label isEmptyLabel;
        private System.Windows.Forms.Label guestLabel;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}