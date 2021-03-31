using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryApp.ConcreteClasses;
using AbstractFactoryApp.Interfaces;

namespace AbstractFactoryApp.ClientClass
{
    class PeugeotClass
    {
        public void CallMethod()
        {
            PeugeotMethod(new ConcreteFactoryPeugeot());
        }

        void PeugeotMethod(IAbstractFactory factory)
        {
            var carBodyType = factory.ChoseBodyType("Hatchback");
            var carEngineType = factory.ChoseEngineType("Petrol");
            var carEngineVolume = factory.ChoseEngineVolume("1.4");
            var carTransmission = factory.ChoseTransmission("Mechanic");

            Console.WriteLine(carBodyType.GetBodyType());
            Console.WriteLine(carEngineType.GetEngineType());
            Console.WriteLine(carEngineVolume.GetEngineVolume());
            Console.WriteLine(carTransmission.GetTransmission());
        }
    }
}
