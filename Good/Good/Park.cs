using System;
using System.Linq;
using Good.GameObjects;

namespace Good
{
    /// <summary>
    /// Класс представляющий локацию
    /// </summary>
    class Park
    {
        /// <summary>
        /// Монстры, обитающие на локации
        /// </summary>
        private IBidlo[] bidlos;
        
        /// <summary>
        /// Деревья на локации 
        /// </summary>
        private Tree[] trees;

        /// <summary>
        /// Скамейки на локации
        /// </summary>
        private Bench[] benches;

        public Park(IBidlo[] bidlos, Tree[] trees, Bench[] benches)
        {
            this.bidlos = bidlos;
            this.trees = trees;
            this.benches = benches;
        }

        /// <summary>
        /// Выводит информацию по количеству быдла определённого типа в консоль
        /// 
        /// Например:
        /// 15 Алкаш
        /// 100 Эксгибицонистов
        /// 55 Гопников
        /// 
        /// 
        /// P.S. если вам не понятно, что в этом методе происходит
        /// то не заморачивайтесь, для понимания темы паттернов это не нужно
        /// просто знайте, что этот метод считает кого и сколько у нас в парке.
        /// Этот метод нужен просто для наглядности, что бы знать, что генерация объектов
        /// сработала правильно
        /// 
        /// </summary>
        public void BidloInfo()
        {
            var alkash = bidlos.Where((item) => {
                return item.ToString() == "Алкаш";
            }).Count();

            Console.WriteLine($"{alkash} Алкаш");


            var exhibitionist = bidlos.Where((item) => {
                return item.ToString() == "Эксгибиционист";
            }).Count();

            Console.WriteLine($"{exhibitionist} Эксгибиционист");


            var gopnik = bidlos.Where((item) => {
                return item.ToString() == "Гопник";
            }).Count();

            Console.WriteLine($"{gopnik} Гопник");
        }
       
    }
}
