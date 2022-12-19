using SoftwareArchitecture.Dz2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Dz2.Abstract
{
    public abstract class ItemGenerator
    {
        public void openReward()
        {
            GameItem gameItem = createItem();
            gameItem.open();
        }

        public abstract GameItem createItem();
    }
}
