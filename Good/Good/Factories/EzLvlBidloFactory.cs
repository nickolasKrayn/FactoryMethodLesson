using System;

using Good.Bidlos;

namespace Good.Factories
{
    /// <summary>
    /// 
    /// Класс представляющий фабрику, которая генерирует монстров
    /// для лёгкого уровня сложности
    /// 
    /// (абсолютно рандомно)
    /// 
    /// </summary>
    class EzLvlBidloFactory : IBidloFactory
    {
        private static Random rnd = new Random();

        public IBidlo Create()
        {
            string[] bidlos = new string[] {
                "Алконафт",
                "Нудист",
                "Гопник"
            };

            switch(bidlos[rnd.Next(0, bidlos.Length)]) // Рандомно выбираем из всех
            {
                case "Алконафт":
                    return new Alkash();
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
            return "Лёгкий уровень сложности";
        }
    }
}
