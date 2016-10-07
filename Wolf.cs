using System;

namespace ConsoleApplication
{
    public class Wolf : ICanine
    {
        public string commonName{get; set;}
        public int gestationDays{get; set;}
        public string coatColor{get; set;}
        public bool isDomesticated{get; set;}
        public string getRange(string name)
        {
            return $"North America in the Tundra.";
        }

    }
}
