using SoftwareArchitecture.Dz2.Abstract;
using SoftwareArchitecture.Dz2.Model;

Random random = new Random();
List<ItemGenerator> generatorList = new();
generatorList.Add(new GemGenerator());
generatorList.Add(new GoldGenerator());

for (int i = 0; i < 10; i++)
{
    int index = Math.Abs(random.Next() % 2 == 0 ? 0 : 1);
    ItemGenerator itemGenerator = generatorList[index];
    itemGenerator.openReward();
}