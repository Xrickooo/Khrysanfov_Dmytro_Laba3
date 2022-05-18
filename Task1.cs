using System;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Створити об'єкт класу Держава, використовуючи класи Область, Район, Місто.
            //Методи: вивести на консоль столицю, кількість областей, площу, обласні центри.
            var country = new Country
            {
                name = "Ukraine"
            };
            var regions = new Country.Regions
            {
                regions = new string[]
                {
                    "Kyiv region", "Sumy region", "Kharkiv region", "Lviv region", "Donetsk region"
                }
            };
            var count = new Country.Regions
            {
                count = regions.regions.Length
            };
            var cities = new Country.Cities
            {
                cities = new string[]
                {
                    "Kyiv", "Sumy", "Kharkivn", "Lviv", "Donetsk", "Dnipro"
                }
            };
            var count2 = new Country.Cities
            {
                count2 = cities.cities.Length
            };
            var districts = new Country.District
            {
                squares = new int[]
                {
                    5, 6, 7, 10, 12, 7, 8, 4, 9
                }
            };
            GetCapital();
            GetRegNum();
            GetSquare();
            GetCities();
            GetInfo();
            void GetInfo()
            {
                Console.WriteLine(country.ToString());

                bool regcount = count.Equals(count2);
                Console.WriteLine(regcount);
                Console.WriteLine(count.GetHashCode());

                bool citycount = count2.Equals(districts.squares.Length);
                Console.WriteLine(citycount);
                Console.WriteLine(count2.GetHashCode());

            }
            void GetCapital()
            {
                Console.WriteLine($"Capital is {cities.cities[0]}");
            }
            void GetRegNum()
            {
                Console.WriteLine($"Number of regions is {count.count}");
            }
            void GetSquare()
            {
                int s = 0;
                for (int i = 0; i < districts.squares.Length; i++)
                {
                    s += districts.squares[i];
                }
                Console.WriteLine($"Square of country is {s}");
            }
            void GetCities()
            {
                Console.WriteLine("Region's centers:");
                for (int i = 0; i < count2.count2; i++)
                {
                    Console.WriteLine(cities.cities[i]);
                }
            }
        }
    }
    class Country
    {
        public string name { get; set; }
        public override string ToString()
        {
            return $"Country: {name}";
        }
        public class Regions
        {
            public string[] regions { get; set; }
            public int count { get; set; }
            public override bool Equals(object obj)
            {
                if (obj is Cities reg) return count == reg.count2;
                return false;
            }
            public override int GetHashCode() => count.GetHashCode();
        }
        public class District
        {
            public int[] squares { get; set; }
        }
        public class Cities
        {
            public string[] cities { get; set; }
            public int count2 { get; set; }
            public override bool Equals(object obj)
            {
                if (obj is District ct) return count2 == ct.squares.Length;
                return false;
            }
            public override int GetHashCode() => count2.GetHashCode();
        }
    }
}