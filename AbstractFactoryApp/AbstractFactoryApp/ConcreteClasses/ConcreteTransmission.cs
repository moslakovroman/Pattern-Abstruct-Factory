using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryApp.Interfaces.EngineTypeInterfaces;
using AbstractFactoryApp.Interfaces.TransmissionInterfaces;

namespace AbstractFactoryApp.ConcreteClasses
{
    public class ConcreteTransmission : IAbstractTransmission
    {
        public string Name { get; set; }

        public ConcreteTransmission()
        {
            
        }
        public ConcreteTransmission(string name)
        {
            Name = name;
        }
        public string GetTransmission()
        {
            string resault = $"Your transmission type is - {Name}";
            return resault;
        }
    }
}
