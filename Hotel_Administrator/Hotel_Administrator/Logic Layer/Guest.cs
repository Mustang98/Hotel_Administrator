using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Administrator
{
    // Класс гостя гостинницы.
    public class Guest
    {
        private DateTime leave;

        // Конструктор.
        public Guest(string name, string surname, string phone)
        {
            if (name == "" || surname == "")
            {
                throw new ArgumentException("Имя и фамилия не могут быть пустыми.");
            }
            Name = name;
            SurName = surname;
            Phone = phone;
        }

        // Имя.
        public string Name { get; private set; }

        // Фамилия.
        public string SurName { get; private set; }

        // Номер телефона.
        public string Phone { get; private set; }

        // Номер комнаты проживания.
        public int Room { get; set; }

        // Дата заселения.
        public DateTime Enter { get; set; }

        // Дата отъезда.
        public DateTime Leave
        {
            get
            {
                return leave;
            }
            set
            {
                if (value < Enter.AddDays(1))
                {
                    throw new ArgumentException($"Дата выезда должна быть позже даты въезда ({Enter.ToShortDateString()}).");
                }
                leave = value;
            }
        }
        
        // Размещение гостя в комнате.
        public void Settle(int room, DateTime leave)
        {
            if (leave <= DateTime.Today)
            {
                throw new ArgumentOutOfRangeException("Дата отъезда должна быть позже текущей.");
            };
            Room = room;
            Enter = DateTime.Today;
            Leave = leave;
        }
    }
}
