using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryApp.ConcreteClasses;
using AbstractFactoryApp.Interfaces;

namespace AbstractFactoryApp.ClientClass
{
    class AudiClass
    {
        public void CallMethod()
        {
            AudiMethod(new ConcreteFactoryAudi());
        }
        void AudiMethod(IAbstractFactory factory)
        {
            var carBodyType = factory.ChoseBodyType("SUV");
            var carEngineType = factory.ChoseEngineType("Diesel");
            var carEngineVolume = factory.ChoseEngineVolume("3.0");
            var carTransmission = factory.ChoseTransmission("Auto");

            Console.WriteLine(carBodyType.GetBodyType());
            Console.WriteLine(carEngineType.GetEngineType());
            Console.WriteLine(carEngineVolume.GetEngineVolume());
            Console.WriteLine(carTransmission.GetTransmission());
        }
    }
}
