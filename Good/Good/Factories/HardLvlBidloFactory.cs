using System;

using Good.Bidlos;

namespace Good.Factories
{
    /// <summary>
    /// 
    /// Класс представляющий фабрику, которая генерирует монстров
    /// для сложного уровня сложности
    /// 
    /// (абсолютно рандомно без учёта самых слабых монстров - Алкашей)
    /// 
    /// </summary>
    class HardLvlBidloFactory : IBidloFactory
    {
        private static Random rnd = new Random();
        public IBidlo Create()
        {
            string[] bidlos = new string[] {
                "Нудист",
                "Гопник"
            };

            switch (bidlos[rnd.Next(0, bidlos.Length)]) // Рандомно выбираем из гопников и нудистов
            {
                case "Нудист":
                    return new Exhibitionist();
                case "Гопник":
                    return new Gopnik();
                default:
                    throw new Exception("Таких конкретных классов нет D:");
            }
        }

        public override string ToString() // реализуем приведение экземпляра класс к строке
        {
            return "Сложный уровень сложности";
        }
    }
}
