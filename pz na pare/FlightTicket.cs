using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_na_pare
{
    internal class FlightTicket
    {
        public enum TicketCategory
        {
            Economy,
            Business
        }

        public static int EconomyTicketsSold { get; private set; }
        public static int BusinessTicketsSold { get; private set; }

        private string seatNumber;
        private string passengerName;
        private DateTime passengerBirthday;
        private DateTime departureTime;

        public TicketCategory Category { get; }
        public string SeatNumber
        {
            get { return seatNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Недопустимый номер места, выберите допустимое");
                    Console.Write("Ваш номер: ");
                    SeatNumber = Console.ReadLine();
                }
                else
                {
                    seatNumber = value;
                }
            }
        }

        public string PassengerName
        {
            get { return passengerName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Имя пассажира недопустимо. Введите правильно");
                    Console.Write("Пассажирское имя ");
                    PassengerName = Console.ReadLine();
                }
                else
                {
                    passengerName = value;
                }
            }
        }

        public DateTime PassengerBirthday
        {
            get { return passengerBirthday; }
            set { passengerBirthday = value; }
        }

        public DateTime DepartureTime
        {
            get { return departureTime; }
            set
            {
                if (value == DateTime.MinValue)
                {
                    Console.WriteLine("Время вылета не заполнено. Введите не пустое значение");
                    Console.Write("Время вылета ");
                    DepartureTime = DateTime.Parse(Console.ReadLine());
                }
                else
                {
                    departureTime = value;
                }
            }
        }

        public decimal TicketPrice
        {
            get
            {
                if (Category == TicketCategory.Business)
                {
                    return (PassengerBirthday > DateTime.Today.AddYears(-10)) ? 10000 : 10000;
                }
                else if (Category == TicketCategory.Economy)
                {
                    return (PassengerBirthday > DateTime.Today.AddYears(-10)) ? 3500 : 7000;
                }

                return 0;
            }
        }

        public FlightTicket(TicketCategory category, string seatNumber, string passengerName, DateTime passengerBirthday, DateTime departureTime)
        {
            if (category == TicketCategory.Economy && EconomyTicketsSold >= 30)
            {
                Console.WriteLine("Нельзя продать более тридцати билетов эконом-класса");
                return;
            }
            else if (category == TicketCategory.Business && BusinessTicketsSold >= 6)
            {
                Console.WriteLine("Нельзя продать более шести билетов бизнесс-класса");
                return;
            }

            Category = category;
            SeatNumber = seatNumber;
            PassengerName = passengerName;
            PassengerBirthday = passengerBirthday;
            DepartureTime = departureTime;

            if (category == TicketCategory.Economy)
            {
                EconomyTicketsSold++;
            }
            else if (category == TicketCategory.Business)
            {
                BusinessTicketsSold++;
            }
        }

        public void DisplayTicketInformation()
        {
            Console.WriteLine("Информация о билете:");
            Console.WriteLine("Номер посадочного места: " + SeatNumber);
            Console.WriteLine("Дата отправления и время вылета " + DepartureTime.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine("ФИО пассажира " + PassengerName);
            Console.WriteLine("Категория билета: " + Category.ToString());
        }

        public void DisplayTimeRemaining()
        {
            TimeSpan timeRemaining = DepartureTime - DateTime.Now;
            Console.WriteLine("Сколько времени осталось: " + timeRemaining.ToString(@"dd\.hh\:mm"));
        }

        public static void DisplaySoldTicketsCount()
        {
            Console.WriteLine("Билетов эконом-класса распродано: " + EconomyTicketsSold);
            Console.WriteLine("Билетов бизнес-класса распродано: " + BusinessTicketsSold);
        }
    }
}

