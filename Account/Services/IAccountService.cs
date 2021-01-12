using System;

namespace Services
{
    public interface IAccountService
    {
        void AddTransactionToAccount(string uniqueAccountName, decimal transactionAmount);
    }
}
