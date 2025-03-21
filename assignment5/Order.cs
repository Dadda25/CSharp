using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetails> DetailsList { get; set; } = new List<OrderDetails>();

        public double TotalAmount => DetailsList.Sum(d => d.Amount);

        public Order(int orderId, Customer customer)
        {
            OrderId = orderId;
            Customer = customer;
        }

        public void AddDetails(OrderDetails details)
        {
            if (DetailsList.Contains(details))
                throw new ApplicationException("订单明细重复！");
            DetailsList.Add(details);
        }

        public override bool Equals(object obj)
        {
            return obj is Order order && OrderId == order.OrderId;
        }

        public override int GetHashCode() => OrderId.GetHashCode();

        public override string ToString()
        {
            string details = string.Join("\n\t", DetailsList.Select(d => d.ToString()));
            return $"订单号：{OrderId}，{Customer}，总金额：{TotalAmount}\n\t{details}";
        }
    }
}

