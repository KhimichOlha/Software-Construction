namespace FactorySubscription
{
    public interface  ISubscription
    {
        public decimal MonthlyFee { get; protected set; }
        public int MinSubscriptionMonths {  get; protected set; }
        public List<string> Channels { get; protected set; }

    }

}
