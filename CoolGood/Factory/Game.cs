using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using Factory.World;
using Factory.World.Builder;

namespace Factory
{
    /// <summary>
    /// Класс предоставляющий базовые параметры настройки игры
    /// </summary>
    class Game : IGame
    {
        /// <summary>
        /// Текущая фабрика для создания врагов
        /// </summary>
        private IEnemiesFactory _factory;

        /// <summary>
        /// Игровой мир
        /// </summary>
        private IGameWorld _world;

        /// <summary>
        /// Игрок
        /// </summary>
        private IPlayer _player;

        /// <summary>
        /// Добавляет объект реализующий <see cref="IEnemiesFactory"/> 
        /// для создания врагов в зависимости от уровня сложности
        /// </summary>
        /// <param name="factory">Объект реализующий <see cref="IEnemiesFactory"/></param>
        /// <returns><see cref="IGame"/></returns>
        public IGame AddEnemyFactory(IEnemiesFactory factory)
        {
            _factory = factory;
            return this;
        }

        /// <summary>
        /// Добавляет игрока в игру
        /// </summary>
        /// <param name="player">Объект реализующий <see cref="IPlayer"/></param>
        /// <returns><see cref="IGame"/></returns>
        public IGame AddPlayer(IPlayer player)
        {
            _player = player;
            return this;
        }

        /// <summary>
        /// Старт игры
        /// </summary>
        public void Play()
        {
            if (_player == null)
            {
                throw new NullReferenceException(nameof(_player));
            }

            if (_factory == null)
            {
                throw new NullReferenceException(nameof(_factory));
            }

            var gameWorld = new GameWorldBuilder().Build(_factory); // Строим игровой мир
            PrintGameWorldInfo(gameWorld); // Выводим информацию о мире
        }

        private void PrintGameWorldInfo(IGameWorld world)
        {
            var enemies = world.Enemies;

            PrintByType("Алкаш", enemies);
            PrintByType("Эксгибиционист", enemies);
            PrintByType("Гопник", enemies);
        }

        private void PrintByType(string name, IEnumerable<IEnemy> enemies)
        {
            var enemy = enemies.Count(item => item.ToString() == name);
            Console.WriteLine($"{enemy} {name}");
        }
        
    }
}
