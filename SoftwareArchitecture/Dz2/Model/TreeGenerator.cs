using SoftwareArchitecture.Dz2.Abstract;
using SoftwareArchitecture.Dz2.Entity;
using SoftwareArchitecture.Dz2.Interfaces;

namespace SoftwareArchitecture.Dz2.Model
{
    internal class TreeGenerator : ItemGenerator
    {
        public override GameItem createItem()
        {
            return new TreeReward();
        }
    }
}