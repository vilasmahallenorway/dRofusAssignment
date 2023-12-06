using dRofusAssignment.Contract;
using dRofusAssignment.Services;
using Moq;

namespace VendingMachineTestProject
{
    public class VendingMachineTest
    {
        [Fact]
        public void OrderProduct_WithEnoughCredit_ShouldDispenseProductAndReduceCredit()
        {
            // Arrange
            var product = new Mock<IProduct>();
            product.Setup(p => p.Name).Returns("Coke");
            product.Setup(p => p.Price).Returns(20);

            var products = new List<IProduct> { product.Object };

            var vendingMachine = new VendingMachine(products);

            vendingMachine.InsertMoney(30);

            // Act
            vendingMachine.OrderProduct("Coke");

            // Assert
            Assert.Equal(10, vendingMachine.CurrentCredit);
        }

        [Fact]
        public void OrderProduct_WithInsufficientCredit_ShouldNotDispenseProductAndKeepCredit()
        {
            // Arrange
            var product = new Mock<IProduct>();
            product.Setup(p => p.Name).Returns("Coke");
            product.Setup(p => p.Price).Returns(20);

            var products = new List<IProduct> { product.Object };

            var vendingMachine = new VendingMachine(products);

            vendingMachine.InsertMoney(10); // Insert less than the product price

            // Act
            vendingMachine.OrderProduct("Coke");

            // Assert
            Assert.Equal(10, vendingMachine.CurrentCredit);
        }

        [Fact]
        public void OrderProduct_WithInvalidProductName_ShouldNotDispenseProductAndKeepCredit()
        {
            // Arrange
            var product = new Mock<IProduct>();
            product.Setup(p => p.Name).Returns("Coke");
            product.Setup(p => p.Price).Returns(20);

            var products = new List<IProduct> { product.Object };

            var vendingMachine = new VendingMachine(products);

            vendingMachine.InsertMoney(30);

            // Act
            vendingMachine.OrderProduct("InvalidProduct");

            // Assert
            Assert.Equal(30, vendingMachine.CurrentCredit);
        }
    }
}