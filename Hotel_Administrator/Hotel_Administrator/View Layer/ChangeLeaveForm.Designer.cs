namespace Hotel_Administrator
{
    partial class ChangeLeaveForm
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
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.leaveDateLabel = new System.Windows.Forms.Label();
            this.leaveDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Location = new System.Drawing.Point(70, 50);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomNumberTextBox.TabIndex = 6;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.roomNumberLabel.Location = new System.Drawing.Point(27, 22);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(200, 17);
            this.roomNumberLabel.TabIndex = 5;
            this.roomNumberLabel.Text = "Комната проживания гостей:";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.submitButton.Location = new System.Drawing.Point(74, 181);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(92, 27);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Применить";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // leaveDateLabel
            // 
            this.leaveDateLabel.AutoSize = true;
            this.leaveDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.leaveDateLabel.Location = new System.Drawing.Point(47, 91);
            this.leaveDateLabel.Name = "leaveDateLabel";
            this.leaveDateLabel.Size = new System.Drawing.Size(147, 17);
            this.leaveDateLabel.TabIndex = 14;
            this.leaveDateLabel.Text = "Новая дата отъезда:";
            // 
            // leaveDatePicker
            // 
            this.leaveDatePicker.Location = new System.Drawing.Point(49, 121);
            this.leaveDatePicker.Name = "leaveDatePicker";
            this.leaveDatePicker.Size = new System.Drawing.Size(143, 20);
            this.leaveDatePicker.TabIndex = 15;
            // 
            // ChangeLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 221);
            this.Controls.Add(this.leaveDatePicker);
            this.Controls.Add(this.leaveDateLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.roomNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeLeaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Изменение даты отъезад";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker leaveDatePicker;
        private System.Windows.Forms.Label leaveDateLabel;
    }
}