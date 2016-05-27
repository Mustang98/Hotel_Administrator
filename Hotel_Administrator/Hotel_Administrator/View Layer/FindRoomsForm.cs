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
    // Форма поиска комнат.
    public partial class FindRoomsForm : Form
    {
        private Hotel hotel;
        private string _class;
        private int capacity;
        private double pricePerDay;

        public FindRoomsForm(Hotel h)
        {
            hotel = h;
            InitializeComponent();
            datePicker.MinDate = DateTime.Today;
        }
        

        // Валидаторы полей.
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

        // Формирование запроса на поиск.
        private void findButton_Click(object sender, EventArgs e)
        {
            //проверка всех полей формы
            string result;
            //флаг, все ли поля формы верны
            bool flag = true;
            
            if (classCheckBox.Checked && (result = classTextBox_Validate()) != "")
            {
                flag = false;
                errorProvider.SetError(classTextBox, result);
            }

            if (capacityCheckBox.Checked && (result = capacityTextBox_Validate()) != "")
            {
                flag = false;
                errorProvider.SetError(capacityTextBox, result);
            }

            if (priceCheckBox.Checked && (result = priceTextBox_Validate()) != "")
            {
                flag = false;
                errorProvider.SetError(priceLabel1, result);
            }

            if (flag == false)
                return;
            //проверка чекбоксов, составление критерия
            string criteria = "";
            criteria += classCheckBox.Checked ? "Y" : "N";
            criteria += capacityCheckBox.Checked ? "Y" : "N";
            criteria += priceCheckBox.Checked ? "Y" : "N";
            try
            {
                DateTime date = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day);
                IReadOnlyList<Room> foundRooms = hotel.FindEmptyRooms(criteria,
                    _class,
                    capacity,
                    pricePerDay,
                    date);
                showResult(foundRooms);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message,
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showResult(IReadOnlyList<Room> foundRooms)
        {
            if (foundRooms.Count == 0)
            {
                nothingFound.Visible = true;
            }
            else
            {
                nothingFound.Visible = false;
            }
            searchResult.Rows.Clear();
            foreach (Room room in foundRooms)
            {
                searchResult.Rows.Add(new object[] { room.Number,
                    room.Class,
                    room.Capacity,
                    room.PricePerDay,
                    room.IsEmpty,
                    room.IsEmpty ? null : room.DateLeave.ToShortDateString() });
            }
        }

        // Включение/отключение параметра поиска.
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox target = sender as CheckBox;
            switch (target.Name)
            {
                case "classCheckBox":
                    {
                        classTextBox.Enabled = !classTextBox.Enabled;
                        errorProvider.SetError(classTextBox, null);
                        break;
                    }
                case "capacityCheckBox":
                    {
                        capacityTextBox.Enabled = !capacityTextBox.Enabled;
                        errorProvider.SetError(capacityTextBox, null);
                        break;
                    }
                case "priceCheckBox":
                    {
                        priceTextBox.Enabled = !priceTextBox.Enabled;
                        errorProvider.SetError(priceLabel1, null);
                        break;
                    }
            }
        }
    }
}
