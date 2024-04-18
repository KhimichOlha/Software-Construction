using DeviceFactoryLogic;
using FactorySubscription;

namespace DemoSubscription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoAbstractFactory();
            DemoFactotyMethod();

        }
        static void DemoAbstractFactory() 
        {
            IDevice proneDevice = new Prone();
            IDevice kiaomiDevice = new Kiaomi();
            IDevice balaxyDevice = new Balaxy();
            Console.WriteLine(proneDevice.CreateNetbook().Doing());
            Console.WriteLine(kiaomiDevice.CreateSmartphone().Doing());
            Console.WriteLine(balaxyDevice.CreateSmartphone().Doing());


        }

        static void DemoFactotyMethod()
        {
            CreatorSubscription creatorMobile = new MobileApp();
            ISubscription domesticSubscription = creatorMobile.CreateSubscription();
            CreatorSubscription creatorWeb = new WebSite();
            ISubscription educationalSubscription = creatorWeb.CreateSubscription();
            CreatorSubscription creatorManager = new ManagerCall();
            ISubscription premiumSubscription = creatorManager.CreateSubscription();
            Print(domesticSubscription);
            Print(educationalSubscription);
            Print(premiumSubscription);
        }
        static void Print(ISubscription subscription)
        {
            Console.WriteLine($"Monthly Fee: {subscription.MonthlyFee}");
            Console.WriteLine($"Minimum Subscription Months: {subscription.MinSubscriptionMonths}");
            Console.WriteLine("Channels:");
            foreach (var channel in subscription.Channels)
            {
                Console.WriteLine($"- {channel}");
            }
        }
    }
}
