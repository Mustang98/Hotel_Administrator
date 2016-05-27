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
    // Форма выселения гостей из заданной комнаты.
    public partial class DeleteGuestsForm : Form
    {
        private Guests guests;
        private Hotel hotel;

        public DeleteGuestsForm(Guests g, Hotel h)
        {
            InitializeComponent();
            hotel = h;
            guests = g;
        }

        private void deleteButton_Click(object sender, EventArgs e)
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

             // Должны ли гости были выехать сегодня или нет. Если комната пустая/не найдена, спокойно вызываем метод выселения, он выкинет эксепшн.
            bool isDateEqualToLeave;
            Room room = hotel.FindRoomByNumber(number);

            if (room == null || room.IsEmpty || room.DateLeave == DateTime.Today)
            {
                isDateEqualToLeave = true;
            }
            else
            {
                isDateEqualToLeave = false;
            }

            if (isDateEqualToLeave == false)
            {
                DialogResult result = MessageBox.Show(
                    "Текущая дата не совпадает с запланированной датой отъезда."+
                    "\nЕсли гости решили изменить дату отъезда, воспользуйтесь функцией \"Изменить дату отъезда\" с выпиской новой квитанции."+
                    "\n\nЕсли вы действительно хотите удалить гостей из комнаты вне плана, нажмите ОК. Новая квитанция при этом выписана не будет.",
                    "Подтверждение операции",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel)
                {
                    errorProvider.SetError(roomNumberTextBox, null);
                    return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show($"Вы уверены, что хотите выселить гостей из комнаты {number}?",
                    "Подтверждение операции",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    errorProvider.SetError(roomNumberTextBox, null);
                    return;
                }

            }

            try
            {
                guests.UnsettleGuests(number);
                MessageBox.Show($"Комната {number} успешно освобождена.",
                    "Выселение успешно",
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
