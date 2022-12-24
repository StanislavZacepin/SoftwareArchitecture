using SoftwareArchitecture.Dz3.Abstract;
using SoftwareArchitecture.Dz3.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Dz3.Interfaces
{
    /// <summary>
    ///заправка 
    /// </summary>
    public interface iRefueling
    {
        /// <summary>
        /// заправка
        /// </summary>
        bool fuel(Car car, TypeFuel typeFuel, double Fuel);

        /// <summary>
        /// проверка топлива
        /// </summary>
        /// <param name="TypeFuel"></param>
        /// <returns></returns>
        bool CheckFuelTank(TypeFuel TypeFuel);

        /// <summary>
        /// Проврка влезит ли бенз  упращоная версия ))
        /// </summary>
        /// <param name="Fuel"></param>
        /// <returns></returns>
        bool CheckFuel(double Fuel);



    }
}
