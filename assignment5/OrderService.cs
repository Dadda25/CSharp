using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using OrderManagement.Models;

namespace OrderManagement.Services
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new ApplicationException("订单已存在！");
            orders.Add(order);
        }

        public void DeleteOrder(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
                throw new ApplicationException("删除失败：订单不存在！");
            orders.Remove(order);
        }

        public void ModifyOrder(int orderId, Customer newCustomer)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
                throw new ApplicationException("修改失败：订单不存在！");
            order.Customer = newCustomer;
        }

        public List<Order> QueryOrders(Func<Order, bool> predicate)
        {
            return orders.Where(predicate)
                         .OrderByDescending(o => o.TotalAmount)
                         .ToList();
        }

        public void Sort(Comparison<Order> comparison = null)
        {
            if (comparison == null)
                orders.Sort((o1, o2) => o1.OrderId.CompareTo(o2.OrderId));
            else
                orders.Sort(comparison);
        }

        public void ShowAll()
        {
            foreach (var order in orders)
                Console.WriteLine(order);
        }
    }
}

