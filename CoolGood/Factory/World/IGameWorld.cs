using System.Collections.Generic;

namespace Factory.World
{
    /// <summary>
    /// Интерфейс представляющий игровой мир
    /// </summary>
    interface IGameWorld
    {
        /// <summary>
        /// Список объектов в игровом мире
        /// </summary>
        IEnumerable<GameObject> Objects { get; set; }

        /// <summary>
        /// Список врагов в игровом мире
        /// </summary>
        IEnumerable<IEnemy> Enemies { get; set; }
    }
}
