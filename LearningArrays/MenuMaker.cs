using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningArrays
{
    public class MenuMaker
    {
      
        public Random Randomizer;
        string[] Meats = { "Pieczona wołowina", "Salami", "Indyk", "Szynka", "Karkówka" };
        string[] Condiments = { "żółta musztarda", "brązowa musztarda", "musztarda miodowa", "majonez", "przyprawy", "sos francuski" };
        string[] Breads = { "chleb ryżowy", "chleb biały", "chleb zbożowy", "pumpernikiel", "chleb włoski", "bułka" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)]; // Checking length of our string, and taking one random component
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + ", " + randomCondiment + ", "+ randomBread;
        }
    }
    
}
