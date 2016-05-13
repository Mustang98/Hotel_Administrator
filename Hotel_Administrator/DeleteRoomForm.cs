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
    public partial class DeleteRoomForm : Form
    {
        private Hotel hotel;
        public DeleteRoomForm(Hotel h)
        {
            InitializeComponent();
            hotel = h;
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

            DialogResult result = MessageBox.Show($"Вы уверены, что хотите удалить комнату с номером {number}?", 
                "Подтверждение операции",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                errorProvider.SetError(roomNumberTextBox, null);
                return;
            }

            try
            {
                hotel.DeleteRoom(number);
                MessageBox.Show($"Комната {number} успешно удалена.",
                    "Удаление успешно",
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
