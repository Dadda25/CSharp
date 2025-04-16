using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderApp
{
    public class Order : IComparable<Order>
    {
        private readonly List<OrderDetail> _details = new List<OrderDetail>();

        public int Id { get; set; }

        public Customer Customer { get; set; }

        public DateTime CreateTime { get; set; }

        public float TotalPrice => _details.Sum(d => d.TotalPrice);

        public List<OrderDetail> Details => _details;

        public Order()
        {
            CreateTime = DateTime.Now;
        }

        public Order(int orderId, Customer customer, DateTime createTime)
        {
            Id = orderId;
            Customer = customer;
            CreateTime = createTime;
        }

        public void AddDetails(OrderDetail orderDetail)
        {
            if (_details.Contains(orderDetail))
            {
                throw new ApplicationException($"The product ({orderDetail.Product.Name}) already exists in order {Id}");
            }
            _details.Add(orderDetail);
        }

        public int CompareTo(Order other)
        {
            return other == null ? 1 : Id - other.Id;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && Id == order.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public void RemoveDetails(int index)
        {
            if (index >= 0 && index < _details.Count)
            {
                _details.RemoveAt(index);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Invalid index to remove details.");
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"OrderId: {Id}, Customer: ({Customer})");
            _details.ForEach(detail => result.Append($"\n\t{detail}"));
            return result.ToString();
        }
    }
}
