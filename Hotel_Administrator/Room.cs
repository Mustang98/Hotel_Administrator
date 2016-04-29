using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hotel_Administrator
{
    class Room
    {
        public readonly int Number;
        public bool IsEmpty { get; private set; }
        public int Class { get; private set; }
        public int Capacity { get; private set; }
        public int PricePerDay { get; private set; }

        private List<Guest> guestList = new List<Guest>();

        public IReadOnlyList<Guest> GuestList
        {
            get
            {
                return guestList.AsReadOnly();
            }
        }

        public int NumberOfGuests
        {
            get
            {
                return guestList.Count;
            }
        }

        public Room(int number, int _class, int capacity, int price)
        {
            if (number <= 0 || _class <= 0 || capacity <= 0 || price < 0)
                throw new UserError("Неправильный формат данных");
            Number = number;
            IsEmpty = true;
            Class = _class;
            Capacity = capacity;
            PricePerDay = price;
        }

        public void MakeEmpty()
        {
            if (IsEmpty)
                throw new UserError("Комната уже пустая.");
            IsEmpty = true;
            guestList.Clear();
        }

        public void SettleGuests(params Guest[] par)
        {
            if (par.Length == 0)
                throw new UserError("Ошибка добавления. Необходимо передать как минимум одного гостя.");
            if (par.Length > Capacity)
                throw new UserError(String.Format("Ошибка добавления. В данную комнату можно добавить не более {0} гостей.", Capacity));
            if (IsEmpty == false)
                throw new UserError("Ошибка добавления. Номер занят.");
            foreach (Guest G in par)
                guestList.Add(G);
            IsEmpty = false;
        }
    }
}
