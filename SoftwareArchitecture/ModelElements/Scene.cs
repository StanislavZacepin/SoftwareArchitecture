using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.ModelElements
{
    /// <summary>
    /// Сцена.
    /// </summary>
    public class Scene <T>
    {
        /// <summary>
        /// Номерация.
        /// </summary>
        public int Id;

        /// <summary>
        /// Модели.
        /// </summary>
        public PoligonalModel Models;

        /// <summary>
        /// Вспышки.
        /// </summary>
        public Flash Flashes;

        /// <summary>
        /// Метод 1.
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public T method1(T Type)
        {
            return Type;
        }

        /// <summary>
        /// Метод 2.
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public T method2(T Type, T Type2)
        {
            return Type;
        }
    }
}
