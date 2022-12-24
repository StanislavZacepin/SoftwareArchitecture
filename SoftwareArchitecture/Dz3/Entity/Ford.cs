using SoftwareArchitecture.Dz3.Abstract;
using SoftwareArchitecture.Dz3.Enumeration;
using SoftwareArchitecture.Dz3.Interfaces;

namespace SoftwareArchitecture.Dz3.Entity
{
    public class Ford : Car//, iRefueling
    {

        #region Пробы
        /*
        public bool CheckFuel(double Fuel)
        {
            double resultat = Fuel + fuelTank;
            if (Fuel > MaxfuelTank || resultat > MaxfuelTank)
                return false;
            return true;
        }

        public bool CheckFuelTank(TypeFuel typeFuel)
        {
            if (typeFuel == this.fuelType)
                return true;
            return false;
        }

        public bool fuel(double Fuel, TypeFuel typeFuel)
        {
            if (CheckFuel(Fuel) == true && CheckFuelTank(typeFuel) == true)
                return true;
            return false;

        } 
        */
        #endregion
    }
}
