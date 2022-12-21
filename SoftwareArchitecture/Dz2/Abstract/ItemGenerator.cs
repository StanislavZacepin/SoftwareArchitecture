using SoftwareArchitecture.Dz2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Dz2.Abstract
{
    /// <summary>
    /// абстрактный класс для Генерация придметов
    /// </summary>
    public abstract class ItemGenerator
    {
        /// <summary>
        /// Метод выдода в консоь придмета
        /// </summary>
        public void openReward()
        {
            GameItem gameItem = createItem();
            gameItem.open();
        }
        /// <summary>
        /// абстрактный метод 
        /// создания придмета
        /// </summary>
        /// <returns></returns>
        public abstract GameItem createItem();
    }
}
