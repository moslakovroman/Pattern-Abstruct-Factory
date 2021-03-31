using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryApp.ConcreteClasses;
using AbstractFactoryApp.Interfaces;

namespace AbstractFactoryApp.ClientClass
{
    class FordClass
    {
        public void CallMethod()
        {
            FordMethod(new ConcreteFactoryFord());
        }

        void FordMethod(IAbstractFactory factory)
        {
            var carBodyType = factory.ChoseBodyType("Coupe");
            var carEngineType = factory.ChoseEngineType("Petrol");
            var carEngineVolume = factory.ChoseEngineVolume("2.5");
            var carTransmission = factory.ChoseTransmission("Auto");

            Console.WriteLine(carBodyType.GetBodyType());
            Console.WriteLine(carEngineType.GetEngineType());
            Console.WriteLine(carEngineVolume.GetEngineVolume());
            Console.WriteLine(carTransmission.GetTransmission());
        }
    }
}
