using System;
using Good.GameObjects;

namespace Good
{
    /// <summary>
    /// Портянка представляющая игру.
    /// </summary>
    class Game
    {
        private Park location;
        private Hero gamer;

        public Game(IBidloFactory factory)
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

            IBidlo[] bidlos = new IBidlo[100]; // Задаём список монстров на локации

            for(int i = 0; i < bidlos.Length; i++)
            {
                bidlos[i] = factory.Create(); // заполнение массива делегировано фабричному методу
            }

            location = new Park(bidlos, trees, benches); // инициализируем игровую локацию

            // Обратите внимание, что эта портянка вообще ничего не знает о пространстве имён с 
            // конкретными монстрами. Вместо этого происходит манипуляция абстракциями и фабриками.
            // Теперь насколько бы большой не бела бы иерархия наследования быдла, она не будет нам мешать
            // при разработки этой части приложения (да и вообще какой-то другой части).
            // О конкретном быдло (Alkash, Exhibitionist, Gopnik) знает только конкретные фабрики, которые
            // работают с быдлом. Но при этом фабрики ничего не знают о других частях программы.
            // Инкапсуляция, мать её.
        }

        /// <summary>
        /// Здесь все игровые элементы взаимодействуют и рендерятся.
        /// (на самом деле нет, потому что не в этом суть данного урока)
        /// </summary>
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
    }
}
