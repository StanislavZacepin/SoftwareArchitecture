using SoftwareArchitecture.Dz2.Interfaces;

namespace SoftwareArchitecture.Dz2.Entity
{
    /// <summary>
    /// Титан
    /// </summary>
    internal class TitanReward : GameItem
    {
        /// <summary>
        /// метод для вызывания придмета в консоль
        /// </summary>
        public void open()
        {
            Console.WriteLine("Titan");
        }
    }
}

