
namespace Factory
{
    /// <summary>
    /// Интерфейс предоставляющий базовые параметры настройки игры
    /// </summary>
    interface IGame
    {
        /// <summary>
        /// Добавляет объект реализующий <see cref="IEnemiesFactory"/> 
        /// для создания врагов в зависимости от уровня сложности
        /// </summary>
        /// <param name="factory">Объект реализующий <see cref="IEnemiesFactory"/></param>
        /// <returns><see cref="IGame"/></returns>
        IGame AddEnemyFactory(IEnemiesFactory factory);

        /// <summary>
        /// Добавляет игрока в игру
        /// </summary>
        /// <param name="player">Объект реализующий <see cref="IPlayer"/></param>
        /// <returns><see cref="IGame"/></returns>
        IGame AddPlayer(IPlayer player);

        /// <summary>
        /// Старт игры
        /// </summary>
        void Play();
    }
}
