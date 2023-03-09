using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Ticket: IComparable
    {
        public string Flight { get; set; }
        public string Destination { get; set; }
        public int Number { get; set; }
        public string Time { get; set; }

        public Ticket(string flight, string destination, int number, string time)
        {
            Flight = flight;
            Destination = destination;
            Number = number;
            Time = time;
        }

        public override string ToString()
        {
            return string.Format("Данные о рейсе:\n" + "- Рейс: {0}\n" + "- Пункт назначения: {1}\n" + "- Время отправления: {2}\n"+ "- Номер места: {3}\n", Flight, Destination, Time, Number);
        }

        int IComparable.CompareTo(object obj)
        {
            const string s = "Сравниваемый объект не принадлежит классу Ticket";
            Ticket ticket = obj as Ticket;
            if (ticket != null) return this.Number.CompareTo(ticket.Number);
            else throw new ArgumentException(s);
        }
    }

}
