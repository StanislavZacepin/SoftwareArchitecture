using SoftwareArchitecture.Dz2.Abstract;
using SoftwareArchitecture.Dz2.Entity.People;
using SoftwareArchitecture.Dz2.Interfaces;
using SoftwareArchitecture.Dz2.Model;
using SoftwareArchitecture.Dz3.Entity;
using SoftwareArchitecture.Dz3.Enumeration;

#region Dz2
/*Random random = new Random();
List<ItemGenerator> generatorList = new();

generatorList.Add(new GemGenerator());
generatorList.Add(new GoldGenerator());
generatorList.Add(new CopperGenerator());
generatorList.Add(new SilverGenerator());
generatorList.Add(new SkinGenerator());
generatorList.Add(new TitanGenerator());
generatorList.Add(new TreeGenerator());
Human humanVlad = new Human { Name = "vlad", LastName = "vladch", Age = 15, Height = 200 };
for (int i = 0; i < 20; i++)
{
    int index = Math.Abs(random.Next(1, 7));
    ItemGenerator itemGenerator = generatorList[index];
    humanVlad.inventory.Add(itemGenerator);
    itemGenerator.openReward();


}


humanVlad.speak();
*/
#endregion
#region Dz3
/*
    * Задание 1. (Доделать 11 пункт)
11. Создать путём наследования класса «Car» два автомобиля: с бензиновым и дизельным двигателями,
имплементировать метод «Заправка топливом» интерфейса «Заправочная станция». Реализовать заправку
каждого автомобиля подходящим топливом. Провести проверку принципа DIP.
Задание 2. Сдать код с семинара и сделать UML-диаграмму по коду. UML-диаграмму можно сделать в любом редакторе. Диаграмма сдается файлом формата jpg.
   */

Ford ford = new Ford { fuelType = SoftwareArchitecture.Dz3.Enumeration.TypeFuel.BENZINE, MaxfuelTank = 60, fuelTank = 15 };
Porter porter = new Porter { fuelType = SoftwareArchitecture.Dz3.Enumeration.TypeFuel.DIESEL, MaxfuelTank = 60, fuelTank = 15 };
Refill refill = new Refill();

refill.fuel(ford, TypeFuel.BENZINE, 15); // заехал на заправку
refill.fuel(ford, TypeFuel.DIESEL, 15); // заехал на заправку
refill.fuel(ford, TypeFuel.BENZINE, 50); // заехал на заправку
refill.fuel(ford, TypeFuel.BENZINE, 60); // заехал на заправку

refill.fuel(porter, TypeFuel.BENZINE, 15); // заехал на заправку
refill.fuel(porter, TypeFuel.DIESEL, 15); // заехал на заправку
refill.fuel(porter, TypeFuel.BENZINE, 50); // заехал на заправку
refill.fuel(porter, TypeFuel.BENZINE, 60); // заехал на заправку

#endregion