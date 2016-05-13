using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Administrator
{
    public class Hotel
    {
        private readonly int MAX_FLOOR_COUNT = 10;

        private List<List<Room>> floorList = new List<List<Room>>();

        public IReadOnlyList<List<Room>> FloorList
        {
            get
            {
                return floorList.AsReadOnly();
            }
        }

        public int FloorNumber
        {
            get
            {
                return floorList.Count;
            }
        }

        public int RoomNumber
        {
            get
            {
                int result = 0;
                foreach (List<Room> floor in floorList)
                    result += floor.Count;
                return result;               
            }
        }

        public int EmptyRoomNumber
        {
            get
            {
                int result = 0;
                foreach (List<Room> floor in floorList)
                    foreach (Room room in floor)
                        if (room.IsEmpty) result++;
                return result;
            }
        }

        public int BusyRoomNumber
        {
            get
            {
                int result = 0;
                foreach (List<Room> floor in floorList)
                    foreach (Room room in floor)
                        if (!room.IsEmpty) result++;
                return result;
            }
        }

        public void AddRoomRange(int Floor, int NumberFirst, int NumberLast, string Class, int Capacity, double PricePerDay)
        {
            if (Floor > FloorNumber || Floor <= 0)
                throw new UserError("Добавление невозможно. Этажа с таким номером не существует. Мне твои комнаты в воздух подвесить?");

            if (NumberFirst > NumberLast)
                throw new UserError("Конечный номер комнаты не может быть меньше начального.");

            for (int i = NumberFirst; i <= NumberLast; i++)
                if (FindRoomByNumber(i) != null)
                    throw new UserError(String.Format("Комната с номером {0} уже существует.", i));

            for (int i = NumberFirst; i <= NumberLast; i++)
            {
                Room room = new Room(i, Class, Capacity, PricePerDay);
                floorList[Floor - 1].Add(room);
            }
        }

        public void DeleteRoom(int Number)
        {
            Room room = FindRoomByNumber(Number);
            if (room == null)
            {
                throw new ArgumentException($"Комнаты с номером {Number} не существует.");
            }
            if (room.IsEmpty == false)
            {
                throw new ArgumentException("Номер занят. Удаление невозможно.");
            }
            foreach (List<Room> floor in floorList)
            {
                floor.Remove(room);
            }
        }

        public void DeleteLastFloor()
        {
            if (FloorNumber == 0)
                throw new UserError("Для удаления должен быть как минимум 1 этаж.");
            foreach (Room room in floorList[FloorNumber - 1])
                if (room.IsEmpty == false)
                    throw new UserError("Невозможно удалить этаж, т.к. на нем не все комнаты пустые.");
            floorList.RemoveAt(FloorNumber - 1);
        }

        public void AddFloor()
        {
            if (floorList.Count == MAX_FLOOR_COUNT)
                throw new UserError("Достигнуто максимально возможное количество этажей.");
            floorList.Add(new List<Room>());
        }

        public IReadOnlyList<Room> FindEmptyRooms(string criteria/*"YYY"*/, string _class, int capacity, double maxPrice, DateTime date)
        {
            if (criteria.Length != 3)
            {
                throw new ArgumentException();
            }

            //сбрасываем точность до дня
            DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            date = new DateTime(date.Year, date.Month, date.Day);

            if (date < today)
            {
                throw new ArgumentException("Дата уже прошла.");
            }

            List<Room> Result = new List<Room>();

            foreach (List<Room> floor in floorList)
            {
                foreach (Room room in floor)
                {
                    if (room.IsEmpty == false && room.DateLeave > date)//комната занята в указанную дату
                        continue;
                    if (criteria[0] == 'Y' && room.Class != _class)//не подходит класс
                        continue;
                    if (criteria[1] == 'Y' && room.Capacity < capacity)//не подходит ёмкость
                        continue;
                    if (criteria[2] == 'Y' && room.PricePerDay > maxPrice)//не подходит цена
                        continue;
                    Result.Add(room);
                }
            }

            return Result.AsReadOnly();
        }

        internal Room FindRoomByNumber(int num)
        {
            foreach (List<Room> floor in floorList)
            {
                foreach (Room room in floor)
                    if (room.Number == num) return room;
            }
            return null;
        }
    }
}
