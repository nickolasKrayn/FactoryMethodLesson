using System;

using Bad.GameObjects;
using Bad.Bidlos;

namespace Bad.Games
{

    /// <summary>
    /// 
    /// Портянка
    /// 
    /// Класс представляет игру лёгкой сложности
    /// 
    /// p.s. Обратите внимание, что большое количество кода среди классов,
    /// представляющих лёгкую, среднюю и тяжёлую игру совпадает
    /// 
    /// </summary>
    class EzGame : IGame
    {
        private static Random rnd = new Random();

        private Park location;
        private Hero gamer;

        public EzGame()
        {
            gamer = new Hero(); // В игре должен быть главный герой, за которого бы будем играть

            Tree[] trees = new Tree[] { // Задаём список деревьев, которые будут на локации
                new Tree(),
                new Tree(),
                new Tree()
            };

            Bench[] benches = new Bench[] { // Задаём список скамеек, которые буду на локации
                new Bench(),
                new Bench(),
                new Bench()
            };

            IBidlo[] bidlos = new IBidlo[100];

            string[] bidlosEnum = new string[] {
                "Алконафт",
                "Нудист",
                "Гопник"
            };

            for (int i = 0; i < bidlos.Length; i++)
            {
                switch (bidlosEnum[rnd.Next(0, bidlosEnum.Length)]) // Рандомно выбираем из всех
                {
                    case "Алконафт":
                        bidlos[i] = new Alkash();
                        break;
                    case "Нудист":
                        bidlos[i] = new Exhibitionist();
                        break;
                    case "Гопник":
                        bidlos[i] = new Gopnik();
                        break;
                    default:
                        throw new Exception("Таких конкретных классов нет D:");
                }
            }

            location = new Park(bidlos, trees, benches); // инициализируем игровую локацию
        }

        public void StartGame()
        {
            Console.WriteLine("Локация загружена");
            Console.WriteLine("Деревья расставлены");
            Console.WriteLine("Скамейки расставлены");
            Console.WriteLine("Монстры на местах");
            Console.WriteLine("Игрок загружен");
            Console.WriteLine("И тут игра, такая, начинается");

            location.BidloInfo(); // Выведем инфу о том, сколько и каких типов быдло у нас сгенерилось 
        }

        public override string ToString()
        {
            return "Лёгкий уровень сложности";
        }
    }
}
