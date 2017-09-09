using System;

namespace Factory.Enemies
{
    /// <summary>
    /// Класс представляющий врага 'Эксгибиционист'
    /// </summary>
    class Exebitionist : IEnemy
    {
        /// <summary>
        /// Издает боевой клич
        /// </summary>
        public void BattleRoar()
        {
            Console.WriteLine("Здрасте, а вот что у меня под плащом");
        }

        public override string ToString()
        {
            return "Эксгибиционист";
        }
    }
}
