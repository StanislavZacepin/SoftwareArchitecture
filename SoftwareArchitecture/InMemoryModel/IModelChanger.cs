using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.InMemoryModel
{
    /// <summary>
    /// Средство смены моделей
    /// </summary>
    internal interface IModelChanger
    {
        /// <summary>
        /// Изменение уведомления
        /// </summary>
        /// <param name="sender"></param>
        public void NotifyChange(IModelChanger sender);
    }
}
