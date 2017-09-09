using System;

namespace Factory.Enemies
{
    /// <summary>
    /// Класс представляющий врага 'Алкаш'
    /// </summary>
    class Boozer : IEnemy
    {
        /// <summary>
        /// Издает боевой клич
        /// </summary>
        public void BattleRoar()
        {
            Console.WriteLine("Дай пятюню, мне на проезд");
        }
        
        public override string ToString()
        {
            return "Алкаш";
        }
    }
}
