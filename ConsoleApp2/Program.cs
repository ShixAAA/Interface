using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Билет на междугородный транспорт.";
            Ticket ticket1 = new Ticket("23131", "Липецк", 12,"13:34");
            Ticket ticket2 = new Ticket("12372", "Казань", 2, "00:04");
            Ticket ticket3 = new Ticket("7767", "Владивосток", 25, "07:14");
            Ticket[] ticketLot = new Ticket[] { ticket1, ticket2, ticket3 };
            Array.Sort(ticketLot);
            Console.WriteLine("Рейсы, отсортированные по месту:\n");
            foreach (Ticket car in ticketLot)
                Console.WriteLine(car.ToString());
            Console.ReadKey();
        }
    }
}
