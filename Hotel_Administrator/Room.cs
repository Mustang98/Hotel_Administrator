using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hotel_Administrator
{
    //класс комната 
    public class Room
    {
        private List<Guest> guestList = new List<Guest>();

        //конструктор
        public Room(int number, string _class, int capacity, double price)
        {
            if (number <= 0  || _class == "" || capacity <= 0 || price < 0)
                throw new UserError("Неправильный формат данных");
            Number = number;
            IsEmpty = true;
            Class = _class;
            Capacity = capacity;
            PricePerDay = price;
        }

        //номер комнаты
        public int Number { get; private set; }
        //Дата освобождения
        public DateTime DateLeave { get; private set; }
        //пустая ли комната
        public bool IsEmpty { get; private set; }
        //класс  комнаты
        public string Class { get; private set; }
        //емкость (количество мест)
        public int Capacity { get; private set; }
        //цена за сутки (на всю комнату)
        public double PricePerDay { get; private set; }
        //коллекция гостей, находящихсяв данный момент в комнате
        public IReadOnlyList<Guest> GuestList
        {
            get
            {
                return guestList.AsReadOnly();
            }
        }
        //количество гостей, находящихся в данный момент в комнате
        public int NumberOfGuests
        {
            get
            {
                return guestList.Count;
            }
        }

        //освободить комнату
        public void MakeEmpty()
        {
            if (IsEmpty)
            {
                throw new UserError("Комната уже пустая.");

            }
            IsEmpty = true;
            guestList.Clear();
        }
        //разместить гостей в комнате
        public void SettleGuests(params Guest[] par)
        {
            if (par.Length == 0)
            {
                throw new UserError("Ошибка добавления. Необходимо передать как минимум одного гостя.");
            }
            if (par.Length > Capacity)
            {
                throw new UserError(String.Format("Ошибка добавления. В данную комнату можно добавить не более {0} гостей.", Capacity));
            }
            if (IsEmpty == false)
            {
                throw new UserError("Ошибка добавления. Номер занят.");
            }
            foreach (Guest G in par)
            {
                guestList.Add(G);
            }
            DateTime leave = par[0].Leave;
            leave = new DateTime(leave.Year, leave.Month, leave.Day);
            DateLeave = leave;
            IsEmpty = false;
        }
    }
}
