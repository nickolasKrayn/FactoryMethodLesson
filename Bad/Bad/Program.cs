using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bad.Games;

namespace Bad
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame[] lvls = new IGame[] { // инициализируем уровни сложности, пользователь будет их выбирать
                new EzGame(),
                new MiddleGame(),
                new HardGame()
            };

            Console.WriteLine("Выберете уровень сложности и введите его номер:");

            for (int i = 0; i < lvls.Length; i++) // выведем все уровни сложности пользователю
            {
                Console.WriteLine($"{i + 1}. {lvls[i].ToString()}"); // i+1 потому что нормальные люди считают с 1, а не с 0
            }

            int lvlNumber = Convert.ToInt32(Console.ReadLine()) - 1; // -1 потому что нормальные люди всё ещё считают с 1)))

            if (lvlNumber > -1 && lvlNumber < lvls.Length) // проверяем находится ли число в пределах массива
            {
                IGame game = lvls[lvlNumber]; // создаём игру с выбранным уровнем сложности
                game.StartGame();
            }
            else
            {
                Console.WriteLine("Недопустимое число");
            }

            Console.ReadKey();
        }
    }
}
