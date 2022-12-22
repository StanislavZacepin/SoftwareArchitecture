using SoftwareArchitecture.Dz2.Abstract;
using SoftwareArchitecture.Dz2.Entity;
using SoftwareArchitecture.Dz2.Interfaces;

namespace SoftwareArchitecture.Dz2.Model
{
    /// <summary>
    /// Фабрика
    /// </summary>
    internal class TreeGenerator : ItemGenerator
    {
        /// <summary>
        /// Переоприделения от наследуемоего асбтрактнаго класса ItemGenerator создания новго придмета
        /// </summary>
        /// <returns></returns>
        public override GameItem createItem()
        {
            return new TreeReward();
        }
    }
}