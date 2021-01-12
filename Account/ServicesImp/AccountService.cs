using DataAccess;
using Domain.Exceptions;
using Services;
using ServicesImp.Exceptions;
using System;

namespace ServicesImp

{
    public class AccountService : IAccountService
    {
        private IAccountRepository AccountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            if(accountRepository == null)
            {
                throw new ArgumentNullException();
            }

            AccountRepository = accountRepository;
        }

        public void AddTransactionToAccount(string uniqueAccountName, decimal transactionAmount)
        {
            var account = AccountRepository.GetByName(uniqueAccountName);
            if(account != null)
            {
                try
                {
                    account.AddTransaction(transactionAmount);
                }
                catch(DomainException domainException)
                {
                    throw new ServiceException("Invalid transaction", domainException);
                }
            }
        }
    }
}
