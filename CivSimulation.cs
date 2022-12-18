using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilizations
{
    internal class CivSimulation
    { 
        List<Civilization> civilizations = new List<Civilization>();

        public void StartSimulation()
        {
            CreateCiv();

            foreach (var civilization in civilizations)
            {
                civilization.StartCiv();
            }
        }
        public void CreateCiv()
        {
            civilizations.Add(new Civilization("KyivanRus"));
            civilizations.Add(new Civilization("Moskovia"));                        
        }

    }
}
