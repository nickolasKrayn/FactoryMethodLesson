using System;
using System.Collections.Generic;

namespace Factory.World.Builder
{
    /// <summary>
    /// Представляет класс для построения игрового мира
    /// </summary>
    class GameWorldBuilder : IGameWorldBuilder
    {
        /// <summary>
        /// Коллекция врагов
        /// </summary>
        private readonly List<IEnemy> _enemies;

        /// <summary>
        /// Коллекция игровых объектов
        /// </summary>
        private readonly List<GameObject> _gameObjects;

        /// <summary>
        /// Инициализирует объект для построения игрового мира
        /// </summary>
        public GameWorldBuilder()
        {
            _enemies = new List<IEnemy>();
            _gameObjects = new List<GameObject>();
        }

        /// <summary>
        /// Добавляет врага к игровому миру
        /// </summary>
        /// <param name="enemy">Экземпляр <see cref="IEnemy"/></param>
        /// <returns>Экземпляр <see cref="IGameWorldBuilder"/></returns>
        public IGameWorldBuilder AddEnemy(IEnemy enemy)
        {
            _enemies.Add(enemy);
            return this;
        }

        /// <summary>
        /// Добавляет игровой объект к игровому миру
        /// </summary>
        /// <param name="obj">Экземпляр <see cref="GameObject"/></param>
        /// <returns>Экземпляр <see cref="IGameWorldBuilder"/></returns>
        public IGameWorldBuilder AddGameObject(GameObject obj)
        {
            _gameObjects.Add(obj);
            return this;
        }

        /// <summary>
        /// Собирает игровой мир из предоставленых материалов
        /// </summary>
        /// <param name="enemiesFactory">Экземпляр фабрики для создания врагов</param>
        /// <returns>Экземпляр <see cref="IGameWorld"/></returns>
        public IGameWorld Build(IEnemiesFactory enemiesFactory)
        {
            #region "Build level"
            int count = RngProvider.Random.Next(10, 100);

            //Build trees
            Console.WriteLine("Build Trees");
            for (int i = 0; i < count; i++)
            {
                this.AddGameObject(new Tree());
            }

            Console.WriteLine("Build Benchs");
            count = RngProvider.Random.Next(10, 100);
            for (int i = 0; i < count; i++)
            {
                this.AddGameObject(new Bench());
            }


            Console.WriteLine("Create enemies");
            count = 100;
            for (int i = 0; i < count; i++)
            {
                this.AddEnemy(enemiesFactory.Create());
            }

#endregion

            return new GameWorld()
            {
                Enemies = _enemies,
                Objects = _gameObjects
            };
        }
    }
}
