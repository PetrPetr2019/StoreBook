using StoreBook;
using System;
using Xunit;

namespace XUnitTest.Store
{
    public class OrderTests
    {
        [Fact]
        public void OrderWidthNullTest_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentOutOfRangeException>((() => new Order(1, null)));
        }
        [Fact]
        public void TotalCount_WidthEmptyItems_ReturnZero()
        {
            var order = new Order(1, new OrderItem[0]);
            Assert.Equal(0, order.TotalCount);

        }
        [Fact]
        public void TotalPrice_WidthEmptyItems_ReturnZero()
        {
            var order = new Order(1, new OrderItem[0]);
            Assert.Equal(0m, order.TotalCount);
        }
        [Fact]
        public void TotalCountWidthEmptyItem_CalculateTotal()
        {
            var order = new Order(1, new[]
            {
                new OrderItem(1, 3, 10m),
                new OrderItem(2, 5, 100m),
            });
            Assert.Equal(3 + 5, order.TotalCount);
        }
         [Fact]
         public  void TotalCountWidthPrice_CalculatePrice()
        {
           var order = new Order(1, new []
           {
               new OrderItem(1, 3, 10m), 
               new OrderItem(2, 5, 100m),
               
           });
            Assert.Equal(3 * 10m + 5 * 100m, order.TotalPrice);
        }
    }
}
