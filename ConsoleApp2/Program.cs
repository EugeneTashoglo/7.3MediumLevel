using System;

namespace Tashoglo7.MediumLevel
{
    class Program
    {
        public struct Cinema
        {
            public string NameFilm;
            public DateTime DateSeans;
            public DateTime TimeLapse;
            public string Genre;
            public int Budget;
        }
        static void Main(string[] args)
        {
            Cinema[] cinemas = new Cinema[2];
            for (int i = 0; i < cinemas.Length; i++)
            {
                Console.WriteLine("введите название фильма");
                cinemas[i].NameFilm = Console.ReadLine();
                Console.WriteLine("введите дату и веремя начала сеанса");
                cinemas[i].DateSeans = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("продолжительность сеанса");
                cinemas[i].TimeLapse = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Жанр");
                cinemas[i].Genre = Console.ReadLine();
                Console.WriteLine("Бюджет");
                cinemas[i].Budget = int.Parse(Console.ReadLine());
            }
            foreach (Cinema i in cinemas)
            {
                Console.WriteLine("введите время 18 00");
                DateTime date = DateTime.Parse(Console.ReadLine());
                if (i.DateSeans <= date)
                {
                    Console.WriteLine("введите время 1 30 ");
                    DateTime date1 = DateTime.Parse(Console.ReadLine());
                    if (i.TimeLapse! >= date1)
                    {
                        Console.WriteLine($"Название фильма {i.NameFilm}");
                        Console.WriteLine($"Дата и время начала сеанса {i.DateSeans}");
                        Console.WriteLine($"Продолжительность сеанса {i.TimeLapse}");
                        Console.WriteLine($"Жанр {i.Genre}");
                        Console.WriteLine($"Бюджет {i.Budget}");

                    }
                }               
            }
        }
    }
}