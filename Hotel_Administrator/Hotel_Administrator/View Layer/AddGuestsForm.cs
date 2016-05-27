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
    // Форма заселения гостей.
    public partial class AddGuestsForm : Form
    {
        Guests guests;

        // Конструктор.
        public AddGuestsForm(Guests g)
        {
            guests = g;
            InitializeComponent();
            datePicker.MinDate = DateTime.Today.AddDays(1);
        }

        // Обработчики событий.
        private void addGuestButton_Click(object sender, EventArgs e)
        {
            guestsToAdd.Rows.Add();
        }

        private void guestsToAdd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                guestsToAdd.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void roomNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(roomNumberTextBox, null);
        }

        private void guestsToAdd_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (guestsToAdd.Rows.Count == 0)
            {
                return;
            }
            guestsToAdd.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = null;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //проверка номера комнаты
            string text = roomNumberTextBox.Text;
            int number;
            string name, surname, phone;
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

            //проверка присутствия хоть 1 гостя
            if (guestsToAdd.Rows.Count == 0)
            {
                MessageBox.Show("Добавьте как минимум одного гостя.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Guest> guestList = new List<Guest>();

            //проверка и парсинг списка гостей
            foreach (DataGridViewRow row in guestsToAdd.Rows)
            {
                name = row.Cells[0].EditedFormattedValue.ToString();
                surname = row.Cells[1].EditedFormattedValue.ToString();
                phone = row.Cells[2].EditedFormattedValue.ToString();
                if (name == "")
                {
                    row.Cells[0].ErrorText = "Заполните это поле.";
                    return;   
                }
                if (surname == "")
                {
                    row.Cells[1].ErrorText = "Заполните это поле.";
                    return;
                }
                //в номере могут быть скобки, дефисы, плюс и т.д. поэтому проверить очень сложно
                if (phone == "")
                {
                    row.Cells[2].ErrorText = "Заполните это поле.";
                    return;
                }
                guestList.Add(new Guest(name, surname, phone));
            }

            try
            {
                DateTime date = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day);
                guests.SettleGuests(number, date, guestList);
                MessageBox.Show($"Гости успешно добавлены в комнату {number}.\nПодробная информация содержится в квитанции.",
                    "Заселение успешно",
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
