using SoftwareArchitecture.ModelElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.InMemoryModel
{
    /// <summary>
    /// Магазин моделей.
    /// </summary>
    internal class ModelStore : IModelChanger
    {
        /// <summary>
        /// Модели.
        /// </summary>
        public PoligonalModel Models;

        /// <summary>
        /// Сцены.
        /// </summary>
        public Scene<?> Scenes;

        /// <summary>
        /// Вспышки.
        /// </summary>
        public Flash Flashes;

        /// <summary>
        /// Камеры.
        /// </summary>
        public Camera Cameras;

        /// <summary>
        /// Измененный наблюдатель, интерфейс.
        /// </summary>
        private IModelChangedObserver changedObserver;

        /// <summary>
        /// Получите сцену.
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public Scene GetScena(int Type)
        {
            return;
        }

        /// <summary>
        /// Изменение уведомления.
        /// </summary>
        /// <param name="sender"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void NotifyChange(IModelChanger sender)
        {
            throw new NotImplementedException();
        }
    }
}
