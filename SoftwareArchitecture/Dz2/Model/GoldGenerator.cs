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
    public class GoldGenerator : ItemGenerator
    {
        public override GameItem createItem()
        {
            return new GoldReward();
        }
    }
}
