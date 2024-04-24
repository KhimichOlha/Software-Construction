namespace DeviceFactoryLogic
{
    public abstract class Device
    {
        public string Brand { get; protected set; }
        public abstract string Doing();

    }
}
