using System;
using System.Collections.Generic;

using Factory.Factories;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var levels = new List<IEnemiesFactory>()
            {
                new EasyLevelEnemiesFactory(),
                new MiddleLevelEnemiesFactory(),
                new HardLevelEnemiesFactory()
            };


            Console.WriteLine("Выберете уровень сложности и введите его номер:");

            for (int i = 0; i < levels.Count; i++) // выведем все уровни сложности пользователю
            {
                Console.WriteLine($"{i + 1}. {levels[i]}"); // i+1 потому что нормальные люди считают с 1, а не с 0
            }

            int selectedLevel;
            var userEnteredValue = Console.ReadLine();

            var isSuccess = Int32.TryParse(userEnteredValue, out selectedLevel);

            if (!isSuccess)
            {
                Console.WriteLine("Critical error, all system crashed, pleaze reboooot ue pc");
                Console.ReadKey();
                return;
            }

            selectedLevel--; // -1 потому что нормальные люди всё ещё считают с 1)))

            if (selectedLevel > -1 && selectedLevel < levels.Count) // проверяем находится ли число в пределах массива
            {

                IGame game = new Game();
                IEnemiesFactory factory = levels[selectedLevel];

                game.AddPlayer(new Player())
                    .AddEnemyFactory(factory);

                game.Play();
            }
            else
            {
                Console.WriteLine("Недопустимое число");
            }

            Console.ReadKey();
        }
    }
}
