using Domain;
using ServicesImp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DataAccess;

namespace Tests
{
    [TestClass]
    public class AccountServiceTests
    {
        private AccountServiceBuilder _accountServiceBuilder;

        [TestInitialize]
        public void Setup()
        {
            _accountServiceBuilder = new AccountServiceBuilder();
        }

        [TestMethod]
        public void AddingTransactionToAccountDelegatesToAccountInstance()
        {
            //Arrange
            var sut = _accountServiceBuilder
                .WithAccountCalled("Trading Account")
                .Build();

            //Act
            sut.AddTransactionToAccount("Trading Account", 200m);

            // Assert
            Assert.AreEqual(200m, _accountServiceBuilder.Account.Balance);
        }
    }
}
