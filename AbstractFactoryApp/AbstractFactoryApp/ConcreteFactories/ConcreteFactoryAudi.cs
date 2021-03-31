using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryApp.Interfaces;
using AbstractFactoryApp.Interfaces.BodyTypeInterfaces;
using AbstractFactoryApp.Interfaces.EngineTypeInterfaces;
using AbstractFactoryApp.Interfaces.TransmissionInterfaces;

namespace AbstractFactoryApp.ConcreteClasses
{
    class ConcreteFactoryAudi : IAbstractFactory
    {
        public IAbstractEngineVolume ChoseEngineVolume()
        {
            return new ConcreteEngineVolume();
        }

        public IAbstractBodyType ChoseBodyType()
        {
            return new ConcreteBodyType();
        }

        public IAbstractTransmission ChoseTransmission()
        {
            return new ConcreteTransmission();
        }

        public IAbstractEngineType ChoseEngineType()
        {
            return new ConcreteEngineType();
        }

        public IAbstractEngineVolume ChoseEngineVolume(string item)
        {
            return new ConcreteEngineVolume(item);
        }

        public IAbstractBodyType ChoseBodyType(string item)
        {
            return new ConcreteBodyType(item);
        }

        public IAbstractTransmission ChoseTransmission(string item)
        {
            return new ConcreteTransmission(item);
        }

        public IAbstractEngineType ChoseEngineType(string item)
        {
            return new ConcreteEngineType(item);
        }
    }
}
