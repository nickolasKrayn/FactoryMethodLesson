using System;

namespace Factory
{
    /// <summary>
    /// Вспомогательный класс для генерации случайных чисел
    /// </summary>
    public static class RngProvider
    {
        /// <summary>
        /// Хранит экземпляр класса <see cref="Random"/> для генерации случайных чисел
        /// </summary>
        public static Random Random { get; }

        static RngProvider()
        {
            Random = new Random();
        }
    }
}
