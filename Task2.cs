using System;
using System.Collections.Generic;
using System.Linq;

namespace laba3
{
     class SortStation // Создаём класс сортировочной станции
    {
        public  List<Garbage> AllObjects = new List<Garbage>();

         public void sort(List<Garbage> AllObjects) // метод сортировки мусора по весу

        {
            Console.WriteLine(new String('-', 50));
            AllObjects.Sort((x, y) => x.weight > y.weight ? -1 : 1);
            Console.WriteLine("Сортировка мусора (по весу) ");
            foreach (var obj in AllObjects)
                Console.WriteLine(obj.name + " " + obj.weight);
            AllObjects.Sort((x, y) => x.weight > y.weight ? 1 : -1);
            Console.WriteLine(new String('-', 50));
        }

        public void sortGarbageTYPES(List<Garbage> AllObjects) // метод сортировки мусора по классам мусора
        {
            var musor = AllObjects.OrderBy(p => p.material);

            foreach (var p in musor)
                Console.WriteLine($"{p.material} - {p.name}");

            Console.WriteLine(new String('-', 50));
        }

        public void sortGarbagebyweight(List<Garbage> AllObjects)  // вывод мусора, вес которых меньше 300 г
        {
            foreach (var obj in AllObjects)
            {
                if (obj.weight < 300)
                    Console.WriteLine("Предметы, вес которых меньше 300 г - " + obj.name);
            }
            Console.WriteLine(new String('-', 50));
        }
    }
    class Garbage : SortStation  // Создаём класс мусора
    {
        public string name { get; set; }
        public int weight { get; set; }           // конструктор мусора
        public string material { get; set; }

    }


         class Glass : Garbage { } // создаём классы видов мусора, наследуя от базового
         class Plastic : Garbage { }
         class Paper : Garbage { }
         class Other : Garbage { }




        class Go
        {
            public static void Main()
            {
            

            var banana = new Garbage
                {
                    name = "Банан",
                    weight = 90,
                    material = "Other",
                };

                var cup = new Garbage
                {
                    name = "Чашка",
                    weight = 300,                          // создаём разные экземпляры мусора
                    material = "Glass",
                };

                var bottle = new Garbage
                {
                    name = "Бутылка",
                    weight = 50,
                    material = "Plastic",
                };

                var karton = new Garbage
                {
                    name = "Картон",
                    weight = 5,
                    material = "Paper",
                };

                var chair = new Garbage
                {
                    name = "Стул",
                    weight = 1000,
                    material = "Other",
                };

            var station = new SortStation { };

            station.AllObjects.Add(chair);
            station.AllObjects.Add(banana);
            station.AllObjects.Add(cup);      // добавляем весь в мусор в лист
            station.AllObjects.Add(bottle);
            station.AllObjects.Add(karton);
            station.sort(station.AllObjects);
            station.sortGarbageTYPES(station.AllObjects);
            station.sortGarbagebyweight(station.AllObjects);



        }


        }
    
}
