using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hotel_Administrator
{
    // Статический класс для создания квитанций.
    static class Invoice
    {
        // Создание квитанции по заселению.
        public static void AddSettleInvoice(Room room)
        {
            string path = $"..\\..\\Invoices\\Квитанция от {DateTime.Now.ToString().Replace(':','-')} Заселение комната {room.Number}.txt";
            FileStream file = File.Create(path);
            StreamWriter invoice = new StreamWriter(file);
            invoice.WriteLine("----Квитанция о заселении----");
            invoice.WriteLine($"Комната: {room.Number}");
            invoice.WriteLine($"Дата заселения: {DateTime.Today.ToShortDateString()}");
            invoice.WriteLine($"Дата выселения: {room.DateLeave.ToShortDateString()}");
            invoice.WriteLine();
            invoice.WriteLine("_Гости___________________");

            foreach (Guest g in room.GuestList)
            {
                invoice.WriteLine(g.SurName + " " + g.Name + " " + g.Phone);
            }
            int days = (room.DateLeave - DateTime.Today).Days;
            invoice.WriteLine("_________________________");
            invoice.WriteLine();
            invoice.WriteLine($"Стоимость за 1 сутки: {room.PricePerDay} грн.");
            invoice.WriteLine($"Количество суток: {days}");
            invoice.WriteLine();
            invoice.WriteLine($"ИТОГО {room.PricePerDay} x {days} = {room.PricePerDay*(double)days}");
            invoice.WriteLine("------------------------------");
            invoice.WriteLine($"Выписано {DateTime.Now.ToString()}");
            invoice.Close();
            file.Close();
        }

        // Создание квитанции в связи с изменением даты отъезда.
        public static void AddReSettleInvoice(Room room, DateTime oldLeave)
        {
            bool ret = oldLeave > room.DateLeave;//возврат ли
            string path;
            if (ret)
            {
                path = $"..\\..\\Invoices\\Квитанция от {DateTime.Now.ToString().Replace(':', '-')} Возврат комната {room.Number}.txt";
            }
            else
            {
                path = $"..\\..\\Invoices\\Квитанция от {DateTime.Now.ToString().Replace(':', '-')} Доплата комната {room.Number}.txt";
            }
            FileStream file = File.Create(path);
            StreamWriter invoice = new StreamWriter(file);
            invoice.WriteLine(ret ? "----Квитанция о возврате----" : "----Квитанция о доплате----");
            invoice.WriteLine($"Комната: {room.Number}");
            invoice.WriteLine($"Дата заселения: {DateTime.Today.ToShortDateString()}");
            invoice.WriteLine($"Старая дата выселения: {oldLeave.ToShortDateString()}");
            invoice.WriteLine($"Новая дата выселения: {room.DateLeave.ToShortDateString()}");
            invoice.WriteLine();
            invoice.WriteLine("_Гости___________________");

            foreach (Guest g in room.GuestList)
            {
                invoice.WriteLine(g.SurName + " " + g.Name + " " + g.Phone);
            }
            int days = Math.Abs((room.DateLeave - oldLeave).Days);
            invoice.WriteLine("_________________________");
            invoice.WriteLine();
            invoice.WriteLine($"Стоимость за 1 сутки: {room.PricePerDay} грн.");
            invoice.WriteLine((ret ? "Сокращено" : "Продлено") + $" на {days} суток.");
            invoice.WriteLine();
            invoice.WriteLine((ret ? "ВОЗВРАТ" : "ДОПЛАТА") + $" {room.PricePerDay} x {days} = {room.PricePerDay * (double)days} грн.");
            invoice.WriteLine("------------------------------");
            invoice.WriteLine($"Выписано {DateTime.Now.ToString()}");
            invoice.Close();
            file.Close();
        }
    }
}
