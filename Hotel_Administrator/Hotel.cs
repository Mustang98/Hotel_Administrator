using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Administrator
{
    class Hotel
    {
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

        public void AddRoomRange(int Floor, int NumberFirst, int NumberLast, int Class, int Capacity, int PricePerDay)
        {
            if (Floor > FloorNumber || Floor <= 0)
                throw new UserError("Добавление невозможно. Этажа с таким номером не существует. Мне твои комнаты в воздух подвесить?");

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
            if (room == null) return;
            if (room.IsEmpty == false)
                throw new UserError("Номер занят. Удаление невозможно.");
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
            floorList.Add(new List<Room>());
        }

        public IReadOnlyList<Room> FindEmptyRooms(string criteria/*"YYY"*/, int Class, int Capacity, int MaxPrice)
        {
            if (criteria.Length != 3)
                throw new ArgumentException();
            List<Room> Result = new List<Room>();

            foreach (List<Room> floor in floorList)
            {
                foreach (Room room in floor)
                {
                    if (room.IsEmpty == false)//комната занята
                        continue;
                    if (criteria[0] == 'Y' && room.Class != Class)//не подходит класс
                        continue;
                    if (criteria[1] == 'Y' && room.Capacity != Capacity)//не подходит ёмкость
                        continue;
                    if (criteria[2] == 'Y' && room.PricePerDay > MaxPrice)//не подходит цена
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
