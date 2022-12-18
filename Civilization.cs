namespace Civilizations
{
    public enum Age { Bronze, Iron, Golden }
    public class Civilization
    {
        List<Human> humans = new List<Human>();

        public int year = 0;
        public int humanCount = 100;
        public int maleCount;
        public int femaleCount;
        public int resourcesToWar = 5000;
        public int resources = 10000;

        public string civilizationName = "Default";
        public string civilizatioAge = Age.Bronze.ToString();

        public Civilization( string name)
        {
            civilizationName = name;
        }

        public void StartCiv()
        {
            SpawnHuman();
            StartYearCount();
        }


        public void SpawnHuman()
        {
            for (int i = 0; i < humanCount; i++)
            {
                humans.Add(new Human(new Random().Next(20, 55)));
                if (humans[i].gender == "Male")
                {
                    maleCount++;
                }
                if (humans[i].gender == "Female")
                {
                    femaleCount++;
                }
            }
            Console.WriteLine($"Civ {civilizationName} | Males = {maleCount} \nFemales = {femaleCount}");
        }

        public void StartYearCount()
        {
            while (year < 2022)
            {                                            
                Console.WriteLine($"It is {year} year |  Civ {civilizationName} | Human count = {humans.Count} | Resources = {resources}");

                AddAge();
                RemoveHuman();
                ResourceCount();

                year++;
            }
        }

        public void RemoveHuman()
        {
            for (int i = 0; i < humanCount; i++)
            {
                //Console.WriteLine($"Age {humans[i]._age} | Die Age {humans[i].dieAge}");

                if (humans[i]._age > humans[i].dieAge)
                {
                    humans.Remove(humans[i]);
                    humanCount--;
                }
            }
        }

        public void AddAge()
        {
            for (int i = 0; i < humanCount; i++)
            {
                humans[i].Growing();
            }

            Thread.Sleep(1000);
            //Console.Clear();
        }

        public void ResourceCount()
        {
            for (int i = 0; i < humanCount; i++)
            {
                humans[i].ResourceDependence();
                resources += humans[i].resoursProducingPerYear;
                resources -= humans[i].resoursUsagePerYear;
            }
        }
    }
}
