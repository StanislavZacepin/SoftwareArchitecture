using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.InMemoryModel
{
    /// <summary>
    /// Наблюдатель с измененной моделью.
    /// </summary>
    internal interface IModelChangedObserver
    {
        /// <summary>
        /// Применить модель обновления.
        /// </summary>
        public void ApplyUpdateModel();
    }
}
