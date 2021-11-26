using System;
using Xunit;
using Lektion2;

namespace Lektion2.UnitTests
{
   public class WalletTest
    {
        [Fact]
        public void Wallet_WhenCalled_ReturnsTrue()
        {
            var emptyWallet = new Wallet();
            var kronor = new Kronor();

            Assert.True(emptyWallet.amount.IsZero());

        }

        [Fact]
        public void Add_WhenCalled_AddsMoneyToTheWallet()
        {
            //Arrange
            var wallet = new Wallet(new Kronor(2,0));
            var kronor = new Kronor(10, 0);
            

            //Act
            wallet.Add(kronor);
            var actualValue = wallet.amount.KronorPart();
            
            //Assert
            Assert.Equal(12, actualValue);

        }

        [Fact]
        public void Remove_RemovesInsertedMoneyFromTheWallet()
        {
            //Arrange
            var wallet = new Wallet(new Kronor(10, 0)); //en plånbok med pengar i
            var kronor = new Kronor(2, 0);

            //Act
            wallet.Remove(kronor);
            var actualValue = wallet.amount.KronorPart();

            //Assert
            Assert.Equal(8, actualValue);

        }

        [Fact]
        public void Remove_InsertNegativeValue_ReturnExeption()
        {
            //Arrange
            var wallet = new Wallet(); //en plånbok med pengar i
            wallet.amount = new Kronor(10, 0);
            var kronor = new Kronor(11, 0);

            //Act
            Action act = () => wallet.Remove(kronor);

            //Assert
            Assert.Throws<ArgumentException>(act);

        }

        [Fact]
        public void RemoveAll_WhenCalled_RemovesAllMoneyFromTheWallet()
        {
            //Arrange
            var wallet = new Wallet(new Kronor(10, 0));

            //Act
            wallet.RemoveAll();
            var actualValue = wallet.amount.KronorPart();

            //Assert
            Assert.Equal(0, actualValue);

        }




    }
}
