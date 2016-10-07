using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Wolf wolf = new Wolf 
            {
                commonName = "Timber Wolf",
                gestationDays = 60,
                coatColor = "grey",
                isDomesticated = false,

            };
                string range = wolf.getRange(wolf.commonName);

            Console.WriteLine($"The {wolf.coatColor} {wolf.commonName} is very beautiful.\nIt takes it {wolf.gestationDays} days to process its food. Their range is {range}");
        }
    }
}
