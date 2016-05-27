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
    // Форма поиска гостей.
    public partial class FindGuestsForm : Form
    {
        private Guests guests;

        public FindGuestsForm(Guests g)
        {
            guests = g;
            InitializeComponent();
        }

        // Удаление предупреждения при изменении текста.
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox target = sender as TextBox;
            errorProvider.SetError(target, null);
        }

        // Формирование запроса на поиск.
        private void findButton_Click(object sender, EventArgs e)
        {
            // Флаг, все ли поля формы верны.
            bool flag = true;

            if (nameCheckBox.Checked && nameTextBox.Text == "")
            {
                flag = false;
                errorProvider.SetError(nameTextBox, "Заполните или деактивируйте поле.");
            }

            if (surNameCheckBox.Checked && surNameTextBox.Text == "")
            {
                flag = false;
                errorProvider.SetError(surNameTextBox, "Заполните или деактивируйте поле.");
            }

            if (phoneCheckBox.Checked && phoneTextBox.Text == "")
            {
                flag = false;
                errorProvider.SetError(phoneTextBox, "Заполните или деактивируйте поле.");
            }

            if (flag == false)
                return;
            //проверка чекбоксов, составление критерия
            string criteria = "";
            criteria += nameCheckBox.Checked ? "Y" : "N";
            criteria += surNameCheckBox.Checked ? "Y" : "N";
            criteria += phoneCheckBox.Checked ? "Y" : "N";
            criteria += enterCheckBox.Checked ? "Y" : "N";
            criteria += leaveCheckBox.Checked ? "Y" : "N";

            try
            {
                DateTime enter = new DateTime(enterDatePicker.Value.Year, enterDatePicker.Value.Month, enterDatePicker.Value.Day);
                DateTime leave = new DateTime(leaveDatePicker.Value.Year, leaveDatePicker.Value.Month, leaveDatePicker.Value.Day);
                IReadOnlyList<Guest> foundGuests = guests.FindGuests(criteria,
                    nameTextBox.Text,
                    surNameTextBox.Text,
                    phoneTextBox.Text,
                    enter,
                    leave);
                showResult(foundGuests);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message,
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showResult(IReadOnlyList<Guest> foundGuests)
        {
            if (foundGuests.Count == 0)
            {
                nothingFound.Visible = true;
            }
            else
            {
                nothingFound.Visible = false;
            }
            searchResult.Rows.Clear();
            foreach (Guest guest in foundGuests)
            {
                searchResult.Rows.Add(new object[] { guest.Name,
                    guest.SurName,
                    guest.Phone,
                    guest.Room,
                    guest.Enter.ToShortDateString(),
                    guest.Leave.ToShortDateString() });
            }
        }

        // Включение/отключение параметра поиска.
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox target = sender as CheckBox;
            switch (target.Name)
            {
                case "nameCheckBox":
                    {
                        nameTextBox.Enabled = !nameTextBox.Enabled;
                        errorProvider.SetError(nameTextBox, null);
                        break;
                    }
                case "surNameCheckBox":
                    {
                        surNameTextBox.Enabled = !surNameTextBox.Enabled;
                        errorProvider.SetError(surNameTextBox, null);
                        break;
                    }
                case "phoneCheckBox":
                    {
                        phoneTextBox.Enabled = !phoneTextBox.Enabled;
                        errorProvider.SetError(phoneTextBox, null);
                        break;
                    }
                case "enterCheckBox":
                    {
                        enterDatePicker.Enabled = !enterDatePicker.Enabled;
                        errorProvider.SetError(enterDatePicker, null);
                        break;
                    }
                case "leaveCheckBox":
                    {
                        leaveDatePicker.Enabled = !leaveDatePicker.Enabled;
                        errorProvider.SetError(leaveDatePicker, null);
                        break;
                    }
            }
        }
    }
}
