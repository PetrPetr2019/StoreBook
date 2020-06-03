using StoreBook;
using System;
using Xunit;

namespace XUnitTest.Store
{

    public class OrderItemTests
    {
        [Fact]
        public void OrderItem_withNegativeCount_ThrowArgumentOutofException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                int count = -1;
                new OrderItem(1, count, 0m);
            });
        }
        [Fact]
        public void OrderItem_WithZeroCount()
        {
            var count = 0;
            Assert.Throws<ArgumentOutOfRangeException>((() => new OrderItem(1, count, 0m)));
        }
        [Fact]
        public void OrderItem_withPozitiveCount_SetCount()
        {
            var orderIten = new OrderItem(1, 2, 3m);
            Assert.Equal(1, orderIten.BookId);
            Assert.Equal(2, orderIten.Count);
            Assert.Equal(3m, orderIten.Price);
        }


    }
}


