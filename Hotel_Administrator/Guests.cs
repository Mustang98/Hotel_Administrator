﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Administrator
{
    public class Guests
    {
        //сслыка на гостинницу
        public readonly Hotel hotel;
        private List<Guest> guestList = new List<Guest>();

        //конструктор
        public Guests(Hotel h)
        {
            hotel = h;
        }

        
        public IReadOnlyList<Guest> GuestList
        {
            get
            {
                return guestList.AsReadOnly();
            }
        }

        public int GuestNumber
        {
            get
            {
                return guestList.Count;
            }
        }

        public int TodayLeaveNumber
        {
            get
            {
                return FindGuests("NNNNY", null, null, null, new DateTime(), DateTime.Now).Count;
            }
        }

        //в комнату нужно передать уже готовых гостей с датой отъезда, поэтому сначала делаем гостей, потом комнату
        public void SettleGuests(int roomNumber, DateTime leave, params Guest[] guests)
        {
            Room room = hotel.FindRoomByNumber(roomNumber);
            if (room == null)
            {
                throw new UserError(String.Format("Комнаты с номером {0} не существует.", roomNumber));
            }

            foreach (Guest curGuest in guests)
            {
                curGuest.Settle(room, leave);
            }
            
            room.SettleGuests(guests);
            guestList.AddRange(guests);
        }

        public void UnsettleGuests(int roomNumber)
        {
            Room room = hotel.FindRoomByNumber(roomNumber);
            if (room == null)
                throw new UserError(String.Format("Комнаты с номером {0} не существует.", roomNumber));

            foreach (Guest guest in room.GuestList)
                guestList.Remove(guest);

            room.MakeEmpty();
        }

        public IReadOnlyList<Guest> FindGuests(string criteria/*"YYYYY"*/, string name, string surname, string phone, DateTime enter, DateTime leave)
        {
            if (criteria.Length != 5)
                throw new ArgumentException();
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
    }
}
