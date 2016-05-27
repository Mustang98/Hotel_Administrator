using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hotel_Administrator
{
    // Класс комнаты гостинницы.
    public class Room
    {
        private List<Guest> guestList = new List<Guest>();

        // Конструктор.
        public Room(int number, string _class, int capacity, double price)
        {
            if (number <= 0 || _class == "" || capacity <= 0 || price < 0)
            {
                throw new ArgumentException("Неправильный формат данных");
            }
            Number = number;
            IsEmpty = true;
            Class = _class;
            Capacity = capacity;
            PricePerDay = price;
        }

        // Номер комнаты.
        public int Number { get; private set; }

        // Дата освобождения.
        public DateTime DateLeave
        {
            get
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException("В комнате нет гостей.");
                }
                return guestList[0].Leave;
            }
            set
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException("В комнате нет гостей.");
                }

                foreach (Guest guest in guestList)
                {
                    guest.Leave = value;
                }
            }
        }                 
        
        // Нустая ли комната.
        public bool IsEmpty { get; private set; }
      
        // Класс  комнаты.
        public string Class { get; private set; }
        
        // Емкость (количество мест).
        public int Capacity { get; private set; }
        
        // Цена за сутки (на всю комнату).
        public double PricePerDay { get; private set; }
        
        // Коллекция гостей, находящихся в данный момент в комнате.
        public IReadOnlyList<Guest> GuestList
        {
            get
            {
                return guestList.AsReadOnly();
            }
        }
        
        // Количество гостей, находящихся в данный момент в комнате.
        public int NumberOfGuests
        {
            get
            {
                return guestList.Count;
            }
        }

        // Освободить комнату.
        public void MakeEmpty()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Комната уже пустая.");
            }
            IsEmpty = true;
            guestList.Clear();
        }

        // Разместить гостей в комнате.
        public void SettleGuests(List<Guest> guests)
        {
            if (guests.Count == 0)
            {
                throw new InvalidOperationException("Ошибка добавления. Необходимо передать как минимум одного гостя.");
            }
            if (guests.Count > Capacity)
            {
                throw new InvalidOperationException(String.Format("Ошибка добавления. В данную комнату можно добавить не более {0} гостей.", Capacity));
            }
            if (IsEmpty == false)
            {
                throw new InvalidOperationException("Ошибка добавления. Номер занят.");
            }
            guestList = guests;
            IsEmpty = false;
        }
    }
}
