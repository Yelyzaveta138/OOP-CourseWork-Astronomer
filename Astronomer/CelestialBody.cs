using System;

namespace Astronomer
{
   
    public class CelestialBody
    {
        
        public string Name { get; set; }        
        public string Type { get; set; }        
        public double Distance { get; set; }    
        public double Magnitude { get; set; }   

        
        public CelestialBody(string name, string type, double distance, double magnitude)
        {
            Name = name;
            Type = type;
            Distance = distance;
            Magnitude = magnitude;
        }
    }
}