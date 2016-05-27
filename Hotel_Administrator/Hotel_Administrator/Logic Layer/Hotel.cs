using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Administrator
{
    // Класс гостинницы 
    public class Hotel
    {
        private readonly int MAX_FLOOR_COUNT = 15;
        private List<List<Room>> floorList = new List<List<Room>>();

        public Hotel(DataBase dataBase)
        {
            // Загрузка из БД.
            floorList = dataBase.Floors;
        }
        
        // Список этажений и комнат только для чтения.
        public IReadOnlyList<List<Room>> FloorList
        {
            get
            {
                return floorList.AsReadOnly();
            }
        }

        // Количество этажей в гостиннице.
        public int FloorNumber
        {
            get
            {
                return floorList.Count;
            }
        }

        // Количество номеров в гостиннице.
        public int RoomNumber
        {
            get
            {
                int result = 0;
                foreach (List<Room> floor in floorList)
                {
                    result += floor.Count;
                }
                return result;               
            }
        }

        // Количество свободных номеров.
        public int EmptyRoomNumber
        {
            get
            {
                int result = 0;
                foreach (List<Room> floor in floorList)
                {
                    foreach (Room room in floor)
                    {
                        if (room.IsEmpty) result++;
                    }
                }
                return result;
            }
        }

        // Количествозанятых номеров.
        public int BusyRoomNumber
        {
            get
            {
                int result = 0;
                foreach (List<Room> floor in floorList)
                {
                    foreach (Room room in floor)
                    {
                        if (!room.IsEmpty) result++;
                    }
                }
                return result;
            }
        }

        // Добавление комнат в гостинницу.
        public void AddRoomRange(int Floor, int NumberFirst, int NumberLast, string Class, int Capacity, double PricePerDay)
        {
            if (Floor > FloorNumber || Floor <= 0)
            {
                throw new ArgumentException("Добавление невозможно. Этажа с таким номером не существует. Мне твои комнаты в воздух подвесить?");
            }

            if (NumberFirst > NumberLast)
            {
                throw new ArgumentException("Конечный номер комнаты не может быть меньше начального.");
            }

            for (int i = NumberFirst; i <= NumberLast; i++)
            {
                if (FindRoomByNumber(i) != null)
                {
                    throw new InvalidOperationException(String.Format("Комната с номером {0} уже существует.", i));
                }
            }

            for (int i = NumberFirst; i <= NumberLast; i++)
            {
                Room room = new Room(i, Class, Capacity, PricePerDay);
                floorList[Floor - 1].Add(room);
            }
        }

        // Удаление комнаты из гостинницы.
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

        // Удаление последнего этажа.
        public void DeleteLastFloor()
        {
            if (FloorNumber == 0)
            {
                throw new InvalidOperationException("Для удаления должен быть как минимум 1 этаж.");
            }

            foreach (Room room in floorList[FloorNumber - 1])
            {
                if (room.IsEmpty == false)
                {
                    throw new InvalidOperationException("Невозможно удалить этаж, т.к. на нем не все комнаты пустые.");
                }
            }
                floorList.RemoveAt(FloorNumber - 1);
        }

        // Добавление нового этажа сверху.
        public void AddFloor()
        {
            if (floorList.Count == MAX_FLOOR_COUNT)
            {
                throw new InvalidOperationException("Достигнуто максимально возможное количество этажей.");
            }
            floorList.Add(new List<Room>());
        }

        // Поиск комнат по различным параметрам.
        public IReadOnlyList<Room> FindEmptyRooms(string criteria/*"YYY"*/, string _class, int capacity, double maxPrice, DateTime date)
        {
            if (criteria.Length != 3)
            {
                throw new ArgumentException();
            }

            if (date < DateTime.Today)
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

        // Плучение комнаты по номеру или null если не существует комнаты с таким номером.
        internal Room FindRoomByNumber(int num)
        {
            foreach (List<Room> floor in floorList)
            {
                foreach (Room room in floor)
                {
                    if (room.Number == num) return room;
                }
            }
            return null;
        }
    }
}
