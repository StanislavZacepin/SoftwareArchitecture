using SoftwareArchitecture.Dz3.Abstract;
using SoftwareArchitecture.Dz3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Dz3.Entity
{
    public class PickUp : Car
    {
        public int loadCapacity { get; set; }

        

        public void wipHeadLight()
        {
            throw new NotImplementedException();
        }

        public void wipMirrors()
        {
            throw new NotImplementedException();
        }

        public void wipWindshield()
        {
            throw new NotImplementedException();
        }
    }
}
