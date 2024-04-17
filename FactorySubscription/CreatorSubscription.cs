﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySubscription
{
    public abstract class CreatorSubscription
    {
        public abstract ISubscription CreateSubscription();

    }
}
