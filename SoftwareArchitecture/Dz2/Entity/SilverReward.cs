using SoftwareArchitecture.Dz2.Interfaces;

namespace SoftwareArchitecture.Dz2.Entity
{
    /// <summary>
    /// Серебро
    /// </summary>
    internal class SilverReward : GameItem
    {
        /// <summary>
        /// метод для вызывания придмета в консоль
        /// </summary>
        public void open()
        {
            Console.WriteLine("Silver");
        }
    }
}

