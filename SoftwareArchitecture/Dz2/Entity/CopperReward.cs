using SoftwareArchitecture.Dz2.Interfaces;

namespace SoftwareArchitecture.Dz2.Entity
{
    /// <summary>
    /// Медь
    /// </summary>
    internal class CopperReward : GameItem
    {
        /// <summary>
        /// метод для вызывания придмета в консоль
        /// </summary>
        public void open()
        {
            Console.WriteLine("Copper");
        }
    }
}

