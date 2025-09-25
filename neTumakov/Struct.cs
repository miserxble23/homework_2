using System;
using System.Security.Cryptography.X509Certificates;
using Enums;

namespace Struct
{
    public struct Drink
    {
        public string Name;
        public double Percent;
    }
    public struct Student
    {
        public string LastName;
        public string FirstName;
        public int ID;
        public DateTime BirthDate;
        public Alcohol Category;
        public Drink DrinkType;
        public double V;

        public double alcV => V * DrinkType.Percent / 100;
    }
    internal class Struct
    {
    }
}
