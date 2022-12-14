using SoftwareArchitecture.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.ModelElements
{
    /// <summary>
    /// Камера.
    /// </summary>
    public class Camera
    {
        /// <summary>
        /// Местоположение.
        /// </summary>
        public Point3D Location;

        /// <summary>
        /// Угол.
        /// </summary>
        public Angle3D Angle;

        /// <summary>
        /// Вращать камеру.
        /// </summary>
        /// <param name=""></param>
        public void Rotate(Angle3D angle3)
        {

        }

        /// <summary>
        /// Подвинуть камеру.
        /// </summary>
        /// <param name="point"></param>
        public void Move(Point3D point)
        {

        }
    }
}
