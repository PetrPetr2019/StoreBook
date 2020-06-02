using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreBook
{
    public class Order // Заказ
    {
        public int  Id { get;}
        private List<OrderItem> items;
        public IReadOnlyCollection<OrderItem>Items
        {
            get { return items; }
            set => items = (List<OrderItem>)value;
        }
        public  int TotalCount
        {
            get { return items.Sum(item => item.Count); }
        }
        public  decimal TotalPrice
        {
            get { return items.Sum(item => item.Price * item.Count); }
        }
        public Order(int id, IEnumerable<OrderItem> items)
        {
            if(items==null)
                throw new ArgumentOutOfRangeException(nameof(items));
            Id = id;
            this.Items = new List<OrderItem>(items);
        }

        public  void AddItem( Book book, int count) // Метод для добавление заказа
        {
            if(book==null)
                throw  new ArgumentOutOfRangeException(nameof(book));

            var item = items.SingleOrDefault(s => s.BookId == book.Id);
            if (item == null)
            {
                items.Add(new OrderItem(book.Id, count, book.Price));
            }
            else
            {
                items.Remove(item);
                items.Add(new OrderItem(book.Id, item.Count + count, book.Price));
            }
        }
    }
}
