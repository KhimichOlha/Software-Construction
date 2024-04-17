using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySubscription
{
    internal class EducationalSubscription : ISubscription
    {

        internal decimal MonthlyFee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ISubscription.MinSubscriptionMonths { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<string> ISubscription.Channels { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
