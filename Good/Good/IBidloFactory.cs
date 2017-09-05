namespace Good
{ 
  /// <summary>
  /// Абстракция для фабрики
  /// 
  /// Если не понятно зачем нужны интерфейсы чекай этот видос:
  /// https://youtu.be/fu13d1V73K4
  /// 
  /// </summary>
    interface IBidloFactory
    {
        /// <summary>
        /// Каждая конкретная фабрика должна реализовывать свой способ создания объекта
        /// </summary>
        /// <returns></returns>
        IBidlo Create();
    }
}
