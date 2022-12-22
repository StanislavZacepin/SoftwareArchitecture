using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Dz2.Interfaces
{
    /// <summary>
    /// интерфес человека имя фамилия рост левт 
    /// </summary>
    public interface Ihuman
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        void speak();
    }
}
