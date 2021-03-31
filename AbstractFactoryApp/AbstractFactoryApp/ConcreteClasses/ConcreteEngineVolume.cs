using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryApp.Interfaces;
using AbstractFactoryApp.Interfaces.EngineTypeInterfaces;
using AbstractFactoryApp.Interfaces.TransmissionInterfaces;

namespace AbstractFactoryApp.ConcreteClasses
{
    public class ConcreteEngineVolume : IAbstractEngineVolume
    {
        public string Name { get; set; }

        public ConcreteEngineVolume()
        {
            
        }
        public ConcreteEngineVolume(string name)
        {
            Name = name;
        }
        public string GetEngineVolume()
        {
            string resault = $"Your engine volume is - {Name}";
            return resault;
        }
    }
}
