interface ICanine
{
    string commonName{get; set;}
    int gestationDays{get; set;}
    string coatColor{get; set;}
    bool isDomesticated{get; set;}
    string getRange(string name);
}