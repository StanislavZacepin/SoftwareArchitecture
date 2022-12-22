using SoftwareArchitecture.Dz2.Abstract;
using SoftwareArchitecture.Dz2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture.Dz2.Entity.People
{
    /// <summary>
    /// Игрок с методом раскза о себе и что у него в инвентаре
    /// </summary>
    internal class Human : Ihuman
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public List<ItemGenerator> inventory { get; set; } = new List<ItemGenerator>();

        public void speak()
        {
            Console.WriteLine("Имя: " + this.Name + ". Фамилия: " + this.LastName + ". Лет: " + this.Age + ". Рост: " + this.Height + ".");
            Console.WriteLine("Инвтентарь: ");
            foreach (var item in inventory)
            {
                item.openReward();
            }
        }


    }
}
