using System;
using AbstractFactoryApp.ClientClass;
using AbstractFactoryApp.ConcreteClasses;

namespace AbstractFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AudiClass audiS6 = new AudiClass();
            audiS6.CallMethod();
            Console.WriteLine(new string('-', 30));

            FordClass mondeo = new FordClass();
            mondeo.CallMethod();
            Console.WriteLine(new string('-', 30));

            PeugeotClass peugeot207 = new PeugeotClass();
            peugeot207.CallMethod();
        }
    }
}
