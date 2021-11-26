using System;
using Xunit;
using Lektion2;

namespace Lektion2.UnitTests
{
    public class KronorTests
    {
   

        [Fact]//tells xUnit that this is a test. 
        public void KronorPart_WhenCalled_ReturnsTheKronorPartOfTheKronor()
        {
            //arrange
            Kronor myKronor = new Kronor(4, 0);

            //act
            var actualValue = myKronor.KronorPart();

            //assert
            Assert.Equal(4, actualValue);
        }
        [Fact]//tells xUnit that this is a test. 
        public void ÖrenPart_WhenCalled_ReturnsTheÖrenPartOfTheKronor()
        {
            //arrange
            Kronor myKronor = new Kronor(1, 4);

            //act
            var actualValue = myKronor.ÖrenPart();

            //assert
            Assert.Equal(4, actualValue);
        }

        [Fact]
        public void IsZero_Value0_ReturrnsTrue()
        {
            //arrange
            Kronor myKronor = new Kronor(0, 0);

            //act
            var actualValue = myKronor.IsZero();

            //assert
            
            Assert.True(actualValue);
        }

        [Fact]
        public void IsZero_ValueNot0_ReturrnsFalse()
        {
            //arrange
            Kronor myKronor = new Kronor(10, 0);

            //act
            var actualValue = myKronor.IsZero();

            //assert

            Assert.False(actualValue);
        }

        [Fact]
        public void Add_WhenCalled_ReturrnsKronorObj()
        {
            //arrange
            Kronor myKronor = new Kronor(4, 0);

            //act
            var actualValue = myKronor.Add(new Kronor(2, 0));
            var kronePart = actualValue.KronorPart();
            var örenPart = actualValue.ÖrenPart();

            //assert

            Assert.IsType<Kronor>(actualValue);
            Assert.Equal(6, kronePart);
            Assert.Equal(0, örenPart);
        }


        [Fact]
        public void Add_InputNegative_ReturrnsException()
        {
            //arrange
            Kronor myKronor = new Kronor();

            //act
            Action act = () => myKronor.Add(new Kronor(-5, 0));

            //assert
            Assert.Throws<ArgumentException>(act);
        }

        [Fact]
        public void Subtract_WhenCalled_ReturrnsKronorObj()
        {
            //arrange
            Kronor myKronor = new Kronor(4, 0);

            //act
            var actualValue = myKronor.Subtract(new Kronor(2, 0));
            var kronePart = actualValue.KronorPart();
            var örenPart = actualValue.ÖrenPart();

            //assert
            Assert.IsType<Kronor>(actualValue);
            Assert.Equal(2, kronePart);
           Assert.Equal(0, örenPart);
        }

        



    }
}
