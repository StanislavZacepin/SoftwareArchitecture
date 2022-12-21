using SoftwareArchitecture.Dz2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Dz2.Entity
{
    /// <summary>
    /// Гем
    /// </summary>
    internal class GemReward : GameItem
    {
        /// <summary>
        /// метод для вызывания придмета в консоль
        /// </summary>
        public void open()
        {
            Console.WriteLine("Gem");
        }
    }
}

