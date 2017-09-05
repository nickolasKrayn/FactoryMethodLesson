using Good.Bidlos;

namespace Good.Factories
{ 
    /// <summary>
    /// 
    /// Класс представляющий фабрику, которая генерирует монстров
    /// для среднего уровня сложности
    /// 
    /// (абсолютно рандомно, но сначала генерит 10 сильных мобов, 
    /// что обеспечит небольшое отклонение по количеству сильных мобов в большую сторону)
    /// 
    /// </summary>
    class MidleLvlBidloFactory : IBidloFactory
    {
        private static int HardBidloCount = 0;

        public IBidlo Create()
        {
            if(HardBidloCount < 10) // проверяем созданы ли 10 сильных мобов
            {
                HardBidloCount += 1;
                return new Gopnik(); // если нет, то создаём
            }

            // если 10 сильных врагов созданы, то генерируем остальных рандомно
            IBidloFactory ezFactory = new EzLvlBidloFactory();
            return ezFactory.Create();
        }

        public override string ToString() // реализуем приведение экземпляра класс к строке
        {
            return "Средний уровень сложности";
        }
    }
}
