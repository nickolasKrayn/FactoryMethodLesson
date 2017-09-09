using Factory.Enemies;

namespace Factory.Factories
{
    /// <summary>
    /// Класс редставляет реализацию шаблона "Фабричный метод"
    /// Для создания противников среднего уровня сложности
    /// </summary>
    class MiddleLevelEnemiesFactory : IEnemiesFactory
    {
        private static readonly int hardEnemiesToCreate = 10;
        private static int hardEnemiesCreated = 0;

        public IEnemy Create()
        {
            if (hardEnemiesCreated < hardEnemiesToCreate) // проверяем созданы ли 10 сильных мобов
            {
                hardEnemiesCreated++;
                return new Gopnik(); // если нет, то создаём
            }

            // если 10 сильных врагов созданы, то генерируем остальных рандомно
            var easyLevelFactory = new EasyLevelEnemiesFactory();
            return easyLevelFactory.Create();
        }

        public override string ToString() 
        {
            return "Средний уровень";
        }
    }
}
