using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryApp.Interfaces.BodyTypeInterfaces;
using AbstractFactoryApp.Interfaces.EngineTypeInterfaces;
using AbstractFactoryApp.Interfaces.TransmissionInterfaces;

namespace AbstractFactoryApp.ConcreteClasses
{
    public class ConcreteBodyType : IAbstractBodyType
    {
        public string Name { get; set; }

        public ConcreteBodyType()
        {

        }
        public ConcreteBodyType(string name)
        {
            Name = name;
        }
        public string GetBodyType()
        {
            string resault = $"Your body type is - {Name}";
            return resault;
        }
    }
}
