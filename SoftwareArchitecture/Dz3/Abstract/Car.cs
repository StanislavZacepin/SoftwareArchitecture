using SoftwareArchitecture.Dz3.Enumeration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Dz3.Abstract
{

    /// <summary>
    /// Абстрактный класс машины
    /// </summary>
    public abstract class Car
    {
        public string make { get; init; }
        public string model { get; init; }
        public Color color { get; init; }
        public TypeCar bodyType { get; init; }
        /// <summary>
        /// тип двигателя
        /// </summary>
        public TypeFuel fuelType { get; init; }
        /// <summary>
        ///  тип каробки
        /// </summary>
        public TypeGearBox transmission { get; init; }
        public int numberWheels { get; init; }
        public double engineCapacity { get; init; }
        /// <summary>
        /// Сколько бенза в баке
        /// </summary>
        public double fuelTank { get; set; }
        /// <summary>
        /// вместимость в бак
        /// </summary>
        public double MaxfuelTank { get; init; }
      

        public void movement() { }// передвижения автомабиля
        public void maintenance() { }// обслуживания
        public bool gearShifting() { return false; }
        public bool switchHeadLight() { return false; }
        public bool switchWipers() { return false; }
    }


}
