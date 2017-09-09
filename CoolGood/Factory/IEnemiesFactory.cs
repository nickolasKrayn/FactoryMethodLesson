
namespace Factory
{
    /// <summary>
    /// Представляет интерфейс для шаблона "Фабричный метод"
    /// Для создания противников
    /// </summary>
    interface IEnemiesFactory
    {
        /// <summary>
        /// Создает новый объект реализующий <see cref="IEnemy"/>
        /// </summary>
        /// <returns>Экземпляр реализующий интерфейс <see cref="IEnemy"/></returns>
        IEnemy Create();
    }
}
