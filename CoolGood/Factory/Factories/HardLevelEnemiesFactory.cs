using System;
using System.Collections.Generic;

using Factory.Enemies;

namespace Factory.Factories
{
    /// <summary>
    /// Класс редставляет реализацию шаблона "Фабричный метод"
    /// Для создания противников тяжелого уровня сложности
    /// </summary>
    class HardLevelEnemiesFactory : IEnemiesFactory
    {
        private readonly List<Type> _enemies = new List<Type>()
        {
            typeof(Exebitionist),
            typeof(Gopnik)
        };

        public IEnemy Create()
        {
            var enemyIndex = RngProvider.Random.Next(0, _enemies.Count);
            var typeOfEnemy = _enemies[enemyIndex]; // Выбираем случайно

            return Activator.CreateInstance(typeOfEnemy) as IEnemy; // Создаем экземпляр
        }

        public override string ToString()
        {
            return "Сложный уровень";
        }
    }
}
