using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Account
    {
        public virtual void AddTransaction(decimal amount)
        {
            Balance += amount;
        }

        public virtual decimal Balance
        {
            get;
            private set;
        }
    }
}
