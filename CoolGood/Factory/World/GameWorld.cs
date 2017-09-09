using System.Collections.Generic;

namespace Factory.World
{
    /// <summary>
    /// Класс представляющий игровой мир
    /// </summary>
    class GameWorld : IGameWorld
    {
        /// <summary>
        /// Список объектов в игровом мире
        /// </summary>
        public IEnumerable<GameObject> Objects { get; set; }

        /// <summary>
        /// Список врагов в игровом мире
        /// </summary>
        public IEnumerable<IEnemy> Enemies { get; set; }
    }
}
