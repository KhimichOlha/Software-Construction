using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySubscription
{
    internal class ManagerCall : CreatorSubscription
    {
        public override ISubscription CreateSubscription()
        {
            throw new NotImplementedException();
        }
    }
}
