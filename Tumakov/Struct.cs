using System;
using Enums;

namespace Struct
{
    public struct dataBank
    {
        public long Number;
        public string Type;
        public double Balance; // можно decimal т.к у нее более высокая точность с десятичными числами(для финансов, денег)
    }
    public struct Worker 
    {
        public string Name;
        public Vuz Vuz;
    }
    internal class @struct
    {
    }
}
