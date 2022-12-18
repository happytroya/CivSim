using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Civilizations
{
    public class Human
    {
        public string gender;
        public int _age;
        public int dieAge;
        public int resoursUsagePerYear;
        public int resoursProducingPerYear;
        public string[] genderType = { "Male", "Female"};
        
        public Human(int age)
        {
            _age = age;
            //dieAge gender dependence
            GenderDependance();
            //producing and using resources dependence
            ResourceDependence();

        }

        public void Growing()
        {
            _age++;
        }
        
        public void GenderDependance()
        {
            gender = genderType[new Random().Next(0, 2)];
            if (gender == "Male")
            {
                dieAge = new Random().Next(75, 90);
            }
            else
            {
                dieAge = new Random().Next(80, 95);
            }
        }

        public void ResourceDependence()
        {
            if (_age < 18)
            {
                resoursUsagePerYear = 2;
                resoursProducingPerYear = 0;
            }
            else if (_age >= 18 && _age < 35)
            {
                resoursUsagePerYear = 1;
                resoursProducingPerYear = 2;
            }
            else if (_age >= 35 && _age < 60)
            {
                resoursUsagePerYear = 2;
                resoursProducingPerYear = 2;
            }
            else if(_age >= 60 && _age < dieAge)
            {
                resoursUsagePerYear = 1;
                resoursProducingPerYear = 0;
            }
        }
    }
}
