using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace assignment7
{
    using OrderApp;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void queryGroupBox_Enter(object sender, EventArgs e)
        {
            // Add logic here if needed
        }

        private void controlGroupBox_Enter(object sender, EventArgs e)
        {
            // Add logic here if needed
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("输入需要删除的id号", "输入需要删除的id号");
            MyClass.orderService.RemoveOrder(int.Parse(input));
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = MyClass.orderService.orders;
        }

        private void displayOrdersButton_Click(object sender, EventArgs e)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = MyClass.orderService.orders;
        }

        private void refreshOrdersButton_Click(object sender, EventArgs e)
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DataSource = MyClass.orderService.orders;
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add logic here if needed
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add logic here if needed
        }

        private void sortOrdersButton_Click(object sender, EventArgs e)
        {
            if (sortComboBox.SelectedIndex != -1)
            {
                if (sortComboBox.SelectedIndex == 0)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.DataSource = MyClass.orderService.orders;
                }
                else if (sortComboBox.SelectedIndex == 1)
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                    Comparison<Order> orderComparison = (x, y) => x.Id.CompareTo(y.Id);
                    MyClass.orderService.Sort(orderComparison);
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.DataSource = MyClass.orderService.orders;
                }
                else if (sortComboBox.SelectedIndex == 2)
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                    Comparison<Order> orderComparison = (x, y) => x.TotalPrice.CompareTo(y.TotalPrice);
                    MyClass.orderService.Sort(orderComparison);
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.DataSource = MyClass.orderService.orders;
                }
            }
            else
            {
                MessageBox.Show("请选择一个选项");
            }
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("提示信息输入", "输入");
            if (queryComboBox.SelectedIndex == 0)
            {
                Predicate<Order> condition = o => o.Id == int.Parse(input);
                IEnumerable<Order> result = MyClass.orderService.Query(condition);
                if (result.Any())
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    BindingList<Order> bindingResult = new BindingList<Order>(result.ToList());
                    dataGridView.DataSource = bindingResult;
                }
                else
                {
                    MessageBox.Show("无效的ID");
                }
            }
            else if (queryComboBox.SelectedIndex == 1)
            {
                Predicate<Order> condition = o => o.Customer.Name == input;
                IEnumerable<Order> result = MyClass.orderService.Query(condition);
                if (result.Any())
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                    BindingList<Order> bindingResult = new BindingList<Order>(result.ToList());
                    dataGridView.DataSource = bindingResult;
                }
                else
                {
                    MessageBox.Show("无效的客户名");
                }
            }
            else if (queryComboBox.SelectedIndex == 2)
            {
                List<Order> orders = new List<Order>();
                var queryResult = MyClass.orderService.orders
                   .Where(order => order.Details != null && order.Details.Any(detail => detail.Product.Name == input));
                foreach (var order in queryResult)
                {
                    orders.Add(order);
                }
                if (orders.Any())
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                    BindingList<Order> bindingResult = new BindingList<Order>(orders.ToList());
                    dataGridView.DataSource = bindingResult;
                }
                else
                {
                    MessageBox.Show("无效的产品名");
                }
            }
            else
            {
                Predicate<Order> condition = o => o.TotalPrice == float.Parse(input);
                IEnumerable<Order> result = MyClass.orderService.Query(condition);
                if (result.Any())
                {
                    dataGridView.DataSource = null;
                    dataGridView.Rows.Clear();
                    BindingList<Order> bindingResult = new BindingList<Order>(result.ToList());
                    dataGridView.DataSource = bindingResult;
                }
                else
                {
                    MessageBox.Show("无效的总金额");
                }
            }
        }
    }

    public class MyClass
    {
        public static OrderService orderService = new OrderService();
    }
}
