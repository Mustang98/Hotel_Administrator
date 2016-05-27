using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Administrator
{
    // Форма изменения даты отъезда гостей.
    public partial class ChangeLeaveForm : Form
    {
        private Guests guests;

        // Конструктор.
        public ChangeLeaveForm(Guests g)
        {
            InitializeComponent();
            guests = g;
            leaveDatePicker.MinDate = DateTime.Today;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string text = roomNumberTextBox.Text;
            int number;
            if (text == "")
            {
                errorProvider.SetError(roomNumberTextBox, "Заполните это поле.");
                return;
            }

            if (Int32.TryParse(text, out number) == false || number <= 0)
            {
                errorProvider.SetError(roomNumberTextBox, "Введите положительное число не больше миллиарда.");
                return;
            }

            try
            {
                DateTime date = new DateTime(leaveDatePicker.Value.Year, leaveDatePicker.Value.Month, leaveDatePicker.Value.Day);
                guests.ChangeLeaveDate(number, date);
                MessageBox.Show($"Дата отъезда гостей из комнаты {number} изменена на {leaveDatePicker.Value.ToShortDateString()}.\nНовая квитанция выписана.",
                    "Изменение успешно",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }

            catch (Exception exc)
            {
                errorProvider.SetError(roomNumberTextBox, null);
                MessageBox.Show(exc.Message,
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
