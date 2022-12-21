using SoftwareArchitecture.Dz2.Interfaces;

namespace SoftwareArchitecture.Dz2.Entity
{
    /// <summary>
    /// шкура
    /// </summary>
    internal class SkinReward : GameItem
    { 
        /// <summary>
       /// метод для вызывания придмета в консоль
       /// </summary>
        public void open()
        {
            Console.WriteLine("Skin");
        }
    }
}

