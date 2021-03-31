using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryApp.Interfaces;
using AbstractFactoryApp.Interfaces.BodyTypeInterfaces;
using AbstractFactoryApp.Interfaces.EngineTypeInterfaces;
using AbstractFactoryApp.Interfaces.TransmissionInterfaces;

namespace AbstractFactoryApp.ConcreteClasses
{
    class ConcreteFactoryFord : IAbstractFactory
    {
        public IAbstractEngineVolume ChoseEngineVolume()
        {
            throw new NotImplementedException();
        }

        public IAbstractBodyType ChoseBodyType()
        {
            throw new NotImplementedException();
        }

        public IAbstractTransmission ChoseTransmission()
        {
            throw new NotImplementedException();
        }

        public IAbstractEngineType ChoseEngineType()
        {
            throw new NotImplementedException();
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
