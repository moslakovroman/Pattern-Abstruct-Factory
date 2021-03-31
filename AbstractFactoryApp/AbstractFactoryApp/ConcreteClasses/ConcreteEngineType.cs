using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryApp.Interfaces.EngineTypeInterfaces;

namespace AbstractFactoryApp.ConcreteClasses
{
    public class ConcreteEngineType : IAbstractEngineType
    {
        public string Name { get; set; }

        public ConcreteEngineType()
        {
            
        }
        public ConcreteEngineType(string name)
        {
            Name = name;
        }
        public string GetEngineType()
        {
            string resault = $"Your engine type is - {Name}";
            return resault;
        }
    }
}
