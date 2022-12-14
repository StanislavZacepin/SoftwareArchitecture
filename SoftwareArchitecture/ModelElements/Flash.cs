using SoftwareArchitecture.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.ModelElements
{
    /// <summary>
    /// Вспышка.
    /// </summary>
    public class Flash
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
        /// Цвет.
        /// </summary>
        public Color Color;

        /// <summary>
        /// питания вспышки или сила вспышки.
        /// </summary>
        public float Power;

        /// <summary>
        /// Вращать.
        /// </summary>
        /// <param name=""></param>
        public void Rotate(Angle3D angle3)
        {

        }

        /// <summary>
        /// Подвинуть.
        /// </summary>
        /// <param name="point"></param>
        public void Move(Point3D point)
        {

        }
    }
}
