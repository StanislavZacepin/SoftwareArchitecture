using SoftwareArchitecture.Dz2.Abstract;
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

for (int i = 0; i < 20; i++)
{
    int index = Math.Abs(random.Next(1,7));
    ItemGenerator itemGenerator = generatorList[index];
    itemGenerator.openReward();
}