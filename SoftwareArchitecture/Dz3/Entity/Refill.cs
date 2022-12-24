using SoftwareArchitecture.Dz3.Abstract;
using SoftwareArchitecture.Dz3.Enumeration;
using SoftwareArchitecture.Dz3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Dz3.Entity
{
    public class Refill : iRefueling, iWipe
    {

        TypeFuel typeFuelBenz = TypeFuel.BENZINE;
        TypeFuel typeFuelGaz = TypeFuel.GASOLIN;
        TypeFuel typeFuelDizel = TypeFuel.DIESEL;
        TypeFuel typeFuelELect = TypeFuel.ELECTRICITY;

        Car car;
     

        public bool CheckFuel(double Fuel)
        {
            double resultat = Fuel + car.fuelTank;
            if (Fuel > car.MaxfuelTank || resultat > car.MaxfuelTank)
            {
                Console.WriteLine("Проврка влезит ли бенз  упращоная версия. НЕ ВЛЕЗИТ!!!");
                return false;
            }
            Console.WriteLine("Проврка влезит ли бенз  упращоная версия. Прошла отлична");
            return true;
        }

        public bool CheckFuelTank(TypeFuel typeFuel)
        {
            if (typeFuel == car.fuelType)
            {
                Console.WriteLine("Проврка топлива. Прошла отлична");
                return true;              
            }                   
            Console.WriteLine("Проврка топлива. Не то топливо");
            return false;
        }

        public bool fuel(Car car, TypeFuel typeFuel, double Fuel)
        {
            this.car = car;
            if (CheckFuel(Fuel) == true && CheckFuelTank(typeFuel) == true)
            {
                Console.WriteLine("Заправился");
                return true;
            }
            Console.WriteLine("Не заправился");
            return false;

        }

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
