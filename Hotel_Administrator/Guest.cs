using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Administrator
{
    class Guest
    {
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public string Phone { get; private set; }
        public Room LiveRoom { get; private set; }
        public DateTime Enter { get; private set; }
        public DateTime Leave { get; private set; }

        public Guest(string name, string surname, string phone)
        {
            if (name == "" || surname == "")
                throw new UserError("Имя и фамилия не могут быть пустыми.");
            Name = name;
            SurName = surname;
            Phone = phone;
        }

        public void Settle(Room liveroom, DateTime leave)
        {
            if (liveroom == null)
                throw new ArgumentException("Ошибка заселения. Комната не передана.");
            if (leave > DateTime.Now)
                throw new UserError("Дата отъезда не может быть раньше текущей.");
            LiveRoom = liveroom;
            Enter = DateTime.Now;
            Leave = leave;
        }
    }
}
