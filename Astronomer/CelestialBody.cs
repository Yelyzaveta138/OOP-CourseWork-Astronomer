using System;

namespace Astronomer
{
    // Клас, що представляє модель небесного тіла з його астрономічними характеристиками
    public class CelestialBody
    {
        
        public string Name { get; set; }        
        public string Type { get; set; }        
        public double Distance { get; set; }    
        public double Magnitude { get; set; }
        public string Constellation { get; set; } 
        public string RightAscension { get; set; } 
        public string Declination { get; set; }

        // Конструктор для створення нового об'єкта зі всіма параметрами
        public CelestialBody(string name, string type, double distance, double magnitude, string constellation, string ra, string dec)
        {
            Name = name;
            Type = type;
            Distance = distance;
            Magnitude = magnitude;
            Constellation = constellation;
            RightAscension = ra;
            Declination = dec;
        }
        public CelestialBody() { }
    }
    
}