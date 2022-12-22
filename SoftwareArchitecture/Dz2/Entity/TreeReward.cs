using SoftwareArchitecture.Dz2.Interfaces;

namespace SoftwareArchitecture.Dz2.Entity
{
    /// <summary>
    /// Дерево
    /// </summary>
    internal class TreeReward : GameItem
    {
        /// <summary>
        /// метод для вызывания придмета в консоль
        /// </summary>
        public void open()
        {
            Console.WriteLine("Tree");
        }
    }
}

