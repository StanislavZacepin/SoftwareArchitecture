using SoftwareArchitecture.Dz2.Abstract;
using SoftwareArchitecture.Dz2.Entity.People;
using SoftwareArchitecture.Dz2.Interfaces;
using SoftwareArchitecture.Dz2.Model;

Random random = new Random();
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
    int index = Math.Abs(random.Next(1,7));
    ItemGenerator itemGenerator = generatorList[index];
    humanVlad.inventory.Add(itemGenerator);
    itemGenerator.openReward();
    

}


humanVlad.speak();

