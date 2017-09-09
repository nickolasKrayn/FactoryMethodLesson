using System;

namespace Factory.Enemies
{
    /// <summary>
    /// Класс представляющий врага 'Гопник'
    /// </summary>
    class Gopnik : IEnemy
    {
        /// <summary>
        /// Издает боевой клич
        /// </summary>
        public void BattleRoar()
        {
            Console.WriteLine("Есть чё позвонить?");
        }

        public override string ToString()
        {
            return "Гопник";
        }
    }
}
