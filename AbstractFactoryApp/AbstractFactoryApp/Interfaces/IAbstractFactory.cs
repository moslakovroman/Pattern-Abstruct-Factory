using AbstractFactoryApp.Interfaces.BodyTypeInterfaces;
using AbstractFactoryApp.Interfaces.EngineTypeInterfaces;
using AbstractFactoryApp.Interfaces.TransmissionInterfaces;

namespace AbstractFactoryApp.Interfaces
{
    public interface IAbstractFactory
    {
        IAbstractEngineVolume ChoseEngineVolume(string item);
        IAbstractBodyType ChoseBodyType(string item);
        IAbstractTransmission ChoseTransmission(string item);

        IAbstractEngineType ChoseEngineType(string item);
    }
}