using DataAccess;
using Domain;
using Moq;
using ServicesImp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    public class AccountServiceBuilder
    {
        private readonly AccountService _accountService;
        private readonly Mock<IAccountRepository> _mockAccountRepo;
       
        public Account Account
        {
            get;
            private set;
        }

        public AccountServiceBuilder()
        {
            _mockAccountRepo = new Mock<IAccountRepository>();
            _accountService = new AccountService(_mockAccountRepo.Object);
        }

        public AccountServiceBuilder WithAccountCalled(string accountName)
        {
            Account = new Account();
            _mockAccountRepo.Setup(r => 
                r.GetByName(accountName)).Returns(Account);

            return this;
        }

        public AccountService Build()
        {
            return _accountService;
        }
    }
}
