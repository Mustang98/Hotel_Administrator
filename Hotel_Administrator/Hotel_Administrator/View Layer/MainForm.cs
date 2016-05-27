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
    public delegate void Delegate();

    public partial class MainForm : Form
    {
        private Guests guests;
        private Hotel hotel;
        private DataBase dataBase;

        public MainForm()
        {
            dataBase = new DataBase("..\\..\\database.xml");
            try
            {
                dataBase = new DataBase("..\\..\\database.xml");
            }
            catch
            {
                errorMessageShow("Произошла ошибка чтения данных. Приложение будет закрыто.");
                Environment.Exit(0);
            }
            hotel = new Hotel(dataBase);
            guests = new Guests(hotel, dataBase);
            InitializeComponent();
            hotelBindingSource.DataSource = hotel;
            guestsBindingSource.DataSource = guests;
            InformChange += updateMainFormData;
            InformChange();
        }

        private void showHotelPanel()
        {
            int DELTA_Y = 46, DELTA_X = 57;
            int LABEL_START_Y = 444, LABEL_START_X = 3;
            int BUTTON_START_Y = 437, BUTTON_START_X = 55;

            hotelPanel.Controls.Clear();

            for (int i = 0; i < hotel.FloorNumber; i++)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                label.Location = new System.Drawing.Point(LABEL_START_X, LABEL_START_Y - DELTA_Y * i);
                label.Name = "labelFloor" + (i + 1);
                label.Size = new System.Drawing.Size(46, 15);
                label.Text = (i + 1) + " этаж";
                this.hotelPanel.Controls.Add(label);

                List<Room> floor = hotel.FloorList[i];
                for (int j = 0; j < floor.Count; j++)
                {
                    Room room = floor[j];
                    Button button = new Button();
                    button.Click += room_Click;
                    button.BackColor = room.IsEmpty ? Color.LightGreen : Color.Tomato;
                    button.FlatAppearance.BorderSize = 0;
                    button.Location = new System.Drawing.Point(BUTTON_START_X + DELTA_X * j, BUTTON_START_Y - DELTA_Y * i);
                    button.Name = "buttonRoom" + room.Number;
                    button.Size = new System.Drawing.Size(51, 30);
                    button.Text = room.Number.ToString();
                    button.UseVisualStyleBackColor = false;
                    this.hotelPanel.Controls.Add(button);
                }
            }
        }

        private void updateMainFormData()
        {
            todayLabel.Text = $"Сегодня {DateTime.Today.ToShortDateString()}";
            hotelBindingSource.ResetBindings(false);
            guestsBindingSource.ResetBindings(false);
            showHotelPanel();
        }

        private void errorMessageShow(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Обработчики событий.
        // Функции гостиницы.
        private void addFloor_Click(object sender, EventArgs e)
        {
            try
            {
                hotel.AddFloor();
                InformChange();
            }    
            catch (Exception exception)
            {
                errorMessageShow(exception.Message);
            }                    
        }
       
        private void deleteFloor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить последний этаж вместе со всеми комнатами на нем?", 
                "Подтверждение операции", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                hotel.DeleteLastFloor();
                InformChange();
            }
            catch (Exception exception)
            {
                errorMessageShow(exception.Message);
            }

        }

        private void addRooms_Click(object sender, EventArgs e)
        {
            if (hotel.FloorNumber == 0)
            {
                errorMessageShow("Для добавление номеров должен быть как минимум 1 этаж.");
                return;
            }
            if ((new AddRoomsForm(hotel)).ShowDialog() == DialogResult.OK)
            {
                InformChange();
            }
        }

        private void deleteRoom_Click(object sender, EventArgs e)
        {
            if (hotel.RoomNumber == 0)
            {
                errorMessageShow("Для удаления должен быть как минимум 1 номер.");
                return;
            }
            if ((new DeleteRoomForm(hotel)).ShowDialog() == DialogResult.OK)
            {
                InformChange();
            }
        }

        private void findEmptyRooms_Click(object sender, EventArgs e)
        {
            if (hotel.RoomNumber == 0)
            {
                errorMessageShow("Для поиска должен быть как минимум 1 номер.");
                return;
            }
            (new FindRoomsForm(hotel)).ShowDialog();
        }

        private void room_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Room room = hotel.FindRoomByNumber(Int32.Parse(button.Text));
            (new RoomInfoForm(room)).ShowDialog();
        }

        // Функции гостей.
        private void addGuests_Click(object sender, EventArgs e)
        {
            if (hotel.EmptyRoomNumber == 0)
            {
                errorMessageShow("Для заселения гостей должен быть как минимум 1 свободный номер.");
                return;
            }
            if ((new AddGuestsForm(guests)).ShowDialog() == DialogResult.OK)
            {
                InformChange();
            }
        }

        private void deleteGuests_Click(object sender, EventArgs e)
        {
            if (guests.GuestNumber == 0)
            {
                errorMessageShow("В данный момент в гостиннице нет гостей.");
                return;
            }
            if ((new DeleteGuestsForm(guests, hotel)).ShowDialog() == DialogResult.OK)
            {
                InformChange();
            }
        }

        private void changeLeaveDate_Click(object sender, EventArgs e)
        {
            if (guests.GuestNumber == 0)
            {
                errorMessageShow("В данный момент в гостиннице нет гостей.");
                return;
            }
            if ((new ChangeLeaveForm(guests)).ShowDialog() == DialogResult.OK)
            {
                InformChange();
            }
        }

        private void findGuests_Click(object sender, EventArgs e)
        {
            if (guests.GuestNumber == 0)
            {
                errorMessageShow("В данный момент в гостиннице нет гостей.");
                return;
            }
            (new FindGuestsForm(guests)).ShowDialog();
        }

        private void viewInvoices_Click(object sender, EventArgs e)
        {
            (new InvoicesForm()).ShowDialog();
        }


        // Другие функции.
        private void SaveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataBase.SaveToFile();
                MessageBox.Show("Изменения успешно сохранены", "Сохранение успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                errorMessageShow("При сохранении данных произошла ошибка. Повторите операцию.");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?\n\nВсе изменения будут сохранены.", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    dataBase.SaveToFile();
                    Environment.Exit(0);
                }
                catch
                {
                    errorMessageShow("При сохранении данных произошла ошибка. Повторите операцию.");
                }
            }            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                dataBase.SaveToFile();
                Environment.Exit(0);
            }
            catch
            {
                errorMessageShow("При сохранении данных произошла ошибка. Повторите операцию.");
            }
        }


        private event Delegate InformChange;
    }
   
}
