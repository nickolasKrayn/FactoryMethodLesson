using System;

using Good.Factories;

namespace Good
{
    class Program
    {
        static void Main(string[] args)
        {
            IBidloFactory[] lvls = new IBidloFactory[] { // инициализируем уровни сложности, пользователь будет их выбирать
                new EzLvlBidloFactory(),
                new MidleLvlBidloFactory(),
                new HardLvlBidloFactory()
            };

            Console.WriteLine("Выберете уровень сложности и введите его номер:");

            for (int i = 0; i < lvls.Length; i++) // выведем все уровни сложности пользователю
            {
                Console.WriteLine($"{i+1}. {lvls[i].ToString()}"); // i+1 потому что нормальные люди считают с 1, а не с 0
            }

            int lvlNumber = Convert.ToInt32(Console.ReadLine()) - 1; // -1 потому что нормальные люди всё ещё считают с 1)))

            if(lvlNumber > -1 && lvlNumber < lvls.Length) // проверяем находится ли число в пределах массива
            {
                Game game = new Game(lvls[lvlNumber]); // создаём игру с выбранным уровнем сложности
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
