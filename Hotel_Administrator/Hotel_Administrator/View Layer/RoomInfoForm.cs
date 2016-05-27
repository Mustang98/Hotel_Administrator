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
    // Форма информации о комнате.
    public partial class RoomInfoForm : Form
    {
        public RoomInfoForm(Room r)
        {
            InitializeComponent();
            numberLabel.Text += r.Number.ToString();
            if (r.IsEmpty)
            {
                isEmptyLabel.Text = "свободна";
                isEmptyLabel.ForeColor = Color.Green;
                Controls.Remove(leaveLabel);
                Controls.Remove(guestLabel);
                this.Height = 200;
            }
            else
            {
                isEmptyLabel.Text = "занята";
                isEmptyLabel.ForeColor = Color.Red;
                leaveLabel.Text += r.DateLeave.ToShortDateString();
            }
            classLabel.Text += r.Class;
            capacityLabel.Text += r.Capacity;
            priceLabel.Text += r.PricePerDay + " грн.";
            guestTabel.DataSource = r.GuestList;
        }
    }
}
