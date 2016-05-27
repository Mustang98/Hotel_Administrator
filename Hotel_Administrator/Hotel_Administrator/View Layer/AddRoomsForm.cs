using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hotel_Administrator
{
    // Форма добавления новых комнат.
    public partial class AddRoomsForm : Form
    {
        private Hotel hotel;
        private int numberFirst, numberLast;
        private string _class;
        private int capacity;
        private double pricePerDay;

        // Конструктор.
        public AddRoomsForm(Hotel h)
        {
            hotel = h;
            InitializeComponent();

            for (int i = 1; i <= hotel.FloorNumber; i++)
            {
                floorComboBox.Items.Add(i);
            }
            floorComboBox.SelectedIndex = 0;
        }

        // Валидаторы полей.
        private string roomNumberTextBox_Validate()
        {
            string text = roomNumberTextBox.Text;
            if (text == "")
            {
                return "Заполните это поле";
            }
            Regex single = new Regex(@"^\d{1,9}$");
            Regex range = new Regex(@"^\d{1,9}-\d{1,9}$");
            if (single.IsMatch(text))
            {
                numberFirst = numberLast = Int32.Parse(text);
                if (numberFirst == 0)
                {
                    return "Введите положительное число меньше миллиарда";
                }
                return "";
            }

            if (range.IsMatch(text))
            {
                numberFirst = Int32.Parse(text.Split('-')[0]);
                numberLast = Int32.Parse(text.Split('-')[1]);

                if (numberFirst == 0 || numberLast == 0)
                {
                    return "Номер комнаты должен быть от нуля до миллиарда";
                }
                return "";
            }

            return "Неверный формат";
        }

        private string classTextBox_Validate()
        {
            _class = classTextBox.Text;
            if (_class == "")
            {
                return "Заполните это поле";
            }            
            return "";
        }

        private string capacityTextBox_Validate()
        {
            if (capacityTextBox.Text == "")
            {
                return "Заполните это поле";
            }

            if (!Int32.TryParse(capacityTextBox.Text, out capacity) || capacity <= 0)
            {
                return "Введите положительное число меньше миллиарда";
            }
            return "";
        }

        private string priceTextBox_Validate()
        {
            if (priceTextBox.Text == "")
            {
                return "Заполните это поле";
            }

            if (!Double.TryParse(priceTextBox.Text, out pricePerDay) || pricePerDay < 0)
            {
                return "Введите неотрицательное число меньше миллиарда";
            }
            return "";
        }
        
        // Удаление предупреждения при изменении текста.
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox target = sender as TextBox;
            if (target == priceTextBox)
            {
                errorProvider.SetError(priceLabel1, null);
            }
            else
            {
                errorProvider.SetError(target, null);
            }
        }
        
        // Обработка добавления комнат.
        private void submitButton_Click(object sender, EventArgs e)
        {
            // Проверка всех полей формы.
            string result;
            // Флаг, все ли поля формы верны.
            bool flag = true;
            if ((result = roomNumberTextBox_Validate()) != "")
            {
                flag = false;
                errorProvider.SetError(roomNumberTextBox, result);
            }

            if ((result = classTextBox_Validate()) != "")
            {
                flag = false;
                errorProvider.SetError(classTextBox, result);
            }

            if ((result = capacityTextBox_Validate()) != "")
            {
                flag = false;
                errorProvider.SetError(capacityTextBox, result);
            }

            if ((result = priceTextBox_Validate()) != "")
            {
                flag = false;
                errorProvider.SetError(priceLabel1, result);
            }

            if (flag == false)
                return;

            try
            {
                hotel.AddRoomRange(floorComboBox.SelectedIndex + 1,
                    numberFirst,
                    numberLast,
                    _class,
                    capacity,
                    pricePerDay);
                MessageBox.Show("Комнаты успешно добавлены.",
                    "Добавление успешно",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message,
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
