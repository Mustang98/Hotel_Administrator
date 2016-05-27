using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace Hotel_Administrator
{
    // Класс для доступа к БД(XML)
    public class DataBase
    {
        private string source;

        // Конструктор с параметром (источник данных).
        public DataBase(string source)
        {
            this.source = source;
            LoadFromFile();
        }

        // Список этажей, полученный из БД.
        public List<List<Room>> Floors { get; set; }
        
        // Список гостей из БД.
        public List<Guest> Guests { get; set; }

        // Загружает данные из БД source.
        public void LoadFromFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(source);
            Floors = new List<List<Room>>();
            Guests = new List<Guest>();
            
            foreach(XmlNode floorNode in doc.ChildNodes[1].ChildNodes)
            {
                List<Room> floor = new List<Room>();

                foreach (XmlNode roomNode in floorNode.ChildNodes)
                {
                    int number = Int32.Parse(roomNode.ChildNodes[0].InnerText);
                    string _class = roomNode.ChildNodes[1].InnerText;
                    int capacity = Int32.Parse(roomNode.ChildNodes[2].InnerText);
                    double price = Double.Parse(roomNode.ChildNodes[3].InnerText);
                    bool isEmpty = Boolean.Parse(roomNode.ChildNodes[4].InnerText);
                    Room room = new Room(number, _class, capacity, price);
                    floor.Add(room);

                    if (!isEmpty)
                    {
                        List<Guest> curRoomGuests = new List<Guest>(); 
                        foreach (XmlNode guestNode in roomNode.ChildNodes[5].ChildNodes)
                        {
                            string name = guestNode.ChildNodes[0].InnerText;
                            string surName = guestNode.ChildNodes[1].InnerText;
                            string phone = guestNode.ChildNodes[2].InnerText;
                            DateTime enter = DateTime.Parse(guestNode.ChildNodes[3].InnerText);
                            DateTime leave = DateTime.Parse(guestNode.ChildNodes[4].InnerText);
                            Guest guest = new Guest(name, surName, phone);
                            guest.Room = number;
                            guest.Enter = enter;
                            guest.Leave = leave;
                            curRoomGuests.Add(guest);
                        }
                        Guests.AddRange(curRoomGuests);
                        room.SettleGuests(curRoomGuests);
                    }
                }
                Floors.Add(floor);
            }
        }

        // Сохраняет изменения в БД.
        public void SaveToFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(source);
            doc.RemoveChild(doc.ChildNodes[1]);
            XmlNode hotelNode = doc.CreateElement("hotel");
            foreach (List<Room> floor in Floors)
            {
                XmlNode floorNode = doc.CreateElement("floor");
                foreach(Room room in floor)
                {
                    XmlNode roomNode = doc.CreateElement("room");

                    XmlNode numberNode = doc.CreateElement("number");
                    numberNode.InnerText = room.Number.ToString();
                    roomNode.AppendChild(numberNode);

                    XmlNode classNode = doc.CreateElement("class");
                    classNode.InnerText = room.Class.ToString();
                    roomNode.AppendChild(classNode); 

                    XmlNode capacityNode = doc.CreateElement("capacity");
                    capacityNode.InnerText = room.Capacity.ToString();
                    roomNode.AppendChild(capacityNode);

                    XmlNode priceNode = doc.CreateElement("price");
                    priceNode.InnerText = room.PricePerDay.ToString();
                    roomNode.AppendChild(priceNode);

                    XmlNode isEmptyNode = doc.CreateElement("isempty");
                    isEmptyNode.InnerText = room.IsEmpty.ToString();
                    roomNode.AppendChild(isEmptyNode);

                    XmlNode guestsNode = doc.CreateElement("guests");
                    if (!room.IsEmpty)
                    {
                        foreach(Guest guest in room.GuestList)
                        {
                            XmlNode guestNode = doc.CreateElement("guest");

                            XmlNode nameNode = doc.CreateElement("name");
                            nameNode.InnerText = guest.Name;
                            guestNode.AppendChild(nameNode);

                            XmlNode surNameNode = doc.CreateElement("surname");
                            surNameNode.InnerText = guest.SurName;
                            guestNode.AppendChild(surNameNode);

                            XmlNode phoneNode = doc.CreateElement("phone");
                            phoneNode.InnerText = guest.Phone;
                            guestNode.AppendChild(phoneNode);

                            XmlNode enterNode = doc.CreateElement("enter");
                            enterNode.InnerText = guest.Enter.ToShortDateString();
                            guestNode.AppendChild(enterNode);

                            XmlNode leaveNode = doc.CreateElement("leave");
                            leaveNode.InnerText = guest.Leave.ToShortDateString();
                            guestNode.AppendChild(leaveNode);

                            guestsNode.AppendChild(guestNode);
                        }
                    }
                    roomNode.AppendChild(guestsNode);

                    floorNode.AppendChild(roomNode);
                }
                hotelNode.AppendChild(floorNode);
            }
            doc.AppendChild(hotelNode);
            doc.Save(source);
        }
   }
}
