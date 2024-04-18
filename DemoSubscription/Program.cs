using FactorySubscription;

namespace DemoSubscription
{
    internal class Program
    {
        static void Main(string[] args)
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
