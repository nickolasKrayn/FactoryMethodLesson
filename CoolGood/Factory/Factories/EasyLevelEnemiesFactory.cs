using System;
using System.Collections.Generic;

using Factory.Enemies;

namespace Factory.Factories
{
    /// <summary>
    /// Класс редставляет реализацию шаблона "Фабричный метод"
    /// Для создания противников легкого уровня сложности
    /// </summary>
    class EasyLevelEnemiesFactory : IEnemiesFactory
    {
        /// <summary>
        /// Типы врагов для этого уровня сложности
        /// </summary>
        private readonly List<Type> _enemies = new List<Type>()
        {
            typeof(Boozer),
            typeof(Exebitionist),
            typeof(Gopnik)
        };
        
        public IEnemy Create()
        {
            var enemyIndex = RngProvider.Random.Next(0, _enemies.Count); 
            var typeOfEnemy = _enemies[enemyIndex]; // Тип выбираем случайно

            return Activator.CreateInstance(typeOfEnemy) as IEnemy; // Создаем экземпляр класса
        }

        public override string ToString()
        {
            return "Легкий уровень";
        }
    }
}
