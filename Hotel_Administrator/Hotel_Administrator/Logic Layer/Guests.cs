using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Administrator
{
    // Класс управления гостями гостинницы.
    public class Guests
    {
        // Сслыка на гостинницу.
        public readonly Hotel hotel;
        private List<Guest> guestList = new List<Guest>();

        // Конструктор.
        public Guests(Hotel h, DataBase dataBase)
        {
            hotel = h;
            guestList = dataBase.Guests;
        }
        
        // Список гостей только для чтения.
        public IReadOnlyList<Guest> GuestList
        {
            get
            {
                return guestList.AsReadOnly();
            }
        }

        // Количество гостей в гостиннице в данный момент.
        public int GuestNumber
        {
            get
            {
                return guestList.Count;
            }
        }

        // Количество гостей, выезжающих из гостинницы сегодня.
        public int TodayLeaveNumber
        {
            get
            {
                return FindGuests("NNNNY", null, null, null, new DateTime(), DateTime.Today).Count;
            }
        }

        // Размещение гостей в комнате.
        public void SettleGuests(int roomNumber, DateTime leave, List<Guest> guests)
        {
            // В комнату нужно передать уже готовых гостей с датой отъезда, поэтому сначала делаем гостей, потом комнату.
            Room room = hotel.FindRoomByNumber(roomNumber);
            if (room == null)
            {
                throw new ArgumentException(String.Format("Комнаты с номером {0} не существует.", roomNumber));
            }

            foreach (Guest curGuest in guests)
            {
                curGuest.Settle(roomNumber, leave);
            }
            
            room.SettleGuests(guests);
            guestList.AddRange(guests);
            try
            {
                Invoice.AddSettleInvoice(room);
            }
            catch
            {
                throw new Exception("Произошла ошибка при создании квитанции.");
            }
        }

        // Выселение гостей из комнаты.
        public void UnsettleGuests(int roomNumber)
        {
            Room room = hotel.FindRoomByNumber(roomNumber);
            if (room == null)
            {
                throw new ArgumentOutOfRangeException(String.Format("Комнаты с номером {0} не существует.", roomNumber));
            }
            foreach (Guest guest in room.GuestList)
            {
                guestList.Remove(guest);
            }
            room.MakeEmpty();
        }

        // Поиск гостей по ряду параметров.
        public IReadOnlyList<Guest> FindGuests(string criteria/*"YYYYY"*/, string name, string surname, string phone, DateTime enter, DateTime leave)
        {
            if (criteria.Length != 5)
            {
                throw new ArgumentException();
            }
            List<Guest> Result = new List<Guest>();

            foreach (Guest guest in guestList)
            {
                if (criteria[0] == 'Y' && guest.Name != name)//не подходит имя
                    continue;
                if (criteria[1] == 'Y' && guest.SurName != surname)//не подходит фамилия
                    continue;
                if (criteria[2] == 'Y' && guest.Phone != phone)//не подходит телефон
                    continue;
                if (criteria[3] == 'Y' && guest.Enter.ToShortDateString() != enter.ToShortDateString())//не подходит день въезда
                    continue;
                if (criteria[4] == 'Y' && guest.Leave.ToShortDateString() != leave.ToShortDateString())//не подходит день выезда
                    continue;
                Result.Add(guest);
            }

            return Result.AsReadOnly();
        }

        // Изменить дату отъезда гостей комнаты.
        public void ChangeLeaveDate(int roomNumber, DateTime newDate)
        {
            Room room = hotel.FindRoomByNumber(roomNumber);
            if (room == null)
            {
                throw new ArgumentException($"Комнаты с номером {roomNumber} не существует.");
            }
            if (room.IsEmpty)
            {
                throw new InvalidOperationException($"В комнате {roomNumber} отсутствуют гости.");
            }
            if (newDate == room.DateLeave)
            {
                throw new ArgumentException("Новая дата отъезда не должна совпадать с текущей.");
            }
            if (newDate < DateTime.Today)
            {
                throw new ArgumentException("Дата уже прошла.");
            }
            DateTime oldLeave = room.DateLeave;
            room.DateLeave = newDate;

            try
            {
                Invoice.AddReSettleInvoice(room, oldLeave);
            }
            catch
            {
                throw new Exception("Произошла ошибка при создании квитанции.");
            }
        }
    }
}
