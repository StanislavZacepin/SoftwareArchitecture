using SoftwareArchitecture.Dz2.Abstract;
using SoftwareArchitecture.Dz2.Entity;
using SoftwareArchitecture.Dz2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Dz2.Model
{
    /// <summary>
    /// Фабрика
    /// </summary>
    public class GoldGenerator : ItemGenerator
    {
        /// <summary>
        /// Переоприделения от наследуемоего асбтрактнаго класса ItemGenerator создания новго придмета
        /// </summary>
        /// <returns></returns>
        public override GameItem createItem()
        {
            return new GoldReward();
        }
    }
}
