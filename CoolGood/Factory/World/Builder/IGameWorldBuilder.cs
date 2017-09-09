
namespace Factory.World.Builder
{
    /// <summary>
    /// Представляет интерфейс для построения игрового мира
    /// </summary>
    interface IGameWorldBuilder
    {
        /// <summary>
        /// Добавляет врага к игровому миру
        /// </summary>
        /// <param name="enemy">Экземпляр <see cref="IEnemy"/></param>
        /// <returns>Экземпляр <see cref="IGameWorldBuilder"/></returns>
        IGameWorldBuilder AddEnemy(IEnemy enemy);

        /// <summary>
        /// Добавляет игровой объект к игровому миру
        /// </summary>
        /// <param name="obj">Экземпляр <see cref="GameObject"/></param>
        /// <returns>Экземпляр <see cref="IGameWorldBuilder"/></returns>
        IGameWorldBuilder AddGameObject(GameObject obj);

        /// <summary>
        /// Собирает игровой мир из предоставленых материалов
        /// </summary>
        /// <param name="enemiesFactory">Экземпляр фабрики для создания врагов</param>
        /// <returns>Экземпляр <see cref="IGameWorld"/></returns>
        IGameWorld Build(IEnemiesFactory enemiesFactory);
    }
}
