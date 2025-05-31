using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class OrdersPage : Form
    {
        private static IBl bl = Factory.Get();
        
        private Order order;
        public OrdersPage()
        {
            InitializeComponent();
            order = new Order();
            OrderProductIdcomboBox1.DataSource =bl.Product.ReadAll().Select(p => p.Id).ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////int productId = int.Parse(OrderProductIdcomboBox1.SelectedItem.ToString());
            ////int amount = int.Parse(countForOrderUpDown.Value.ToString());

            ////try
            ////{
            ////    bl.Order.AddProductToOrder(order, productId, amount);
            ////    CartlistBox.Items.AddRange(order.productInOrder.Last().ToStringProperty().Split("\n"));
            ////    CartlistBox.Items.AddRange(("Final Price: " + order.finalPrice + "\n").Split("\n"));


            ////}
            ////catch 
            ////{
            ////    MessageBox.Show("");
            ////}


            //int productId = int.Parse(OrderProductIdcomboBox1.SelectedItem.ToString());
            //int amount = int.Parse(countForOrderUpDown.Value.ToString());

            //try
            //{
            //    bl.Order.AddProductToOrder(order, productId, amount);
            //    CartlistBox.Items.AddRange(order.productInOrder.Last().ToStringProperty().ToString().Split("\n"));

            //    //listBoxScreen.Items.Add(order.ProductsInOrderList.Last().ToString());
            //    //List<SaleInProduct> salesInProduct = order.ProductsInOrderList.Last().SalesInProduct;
            //    //List<String> salesInProductList = salesInProduct.Select(s => s.ToStringProperty()).ToList();
            //    //listBoxScreen.Items.AddRange(salesInProductList.ToArray());
            //    //listBoxScreen.Items.Add("First Product Price: " + order.ProductsInOrderList.Last().ProductBasicPrice);
            //    //listBoxScreen.Items.Add("Final Product Price: " + order.ProductsInOrderList.Last().ProductEndPrice);
            //    CartlistBox.Items.AddRange(("Final Price: " + order.finalPrice + "\n").Split("\n"));


            //}
            //catch 
            //{
            //    MessageBox.Show("????");
            //}



        }
        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeMenu employeeMenu = new EmployeeMenu();
            employeeMenu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    bl.Order.DoOrder(order);
            //    MessageBox.Show("ההזמנה הושלמה בהצלחה!!!");
            //}
            //catch
            //{
            //    MessageBox.Show("ההזמנה לא בוצעה !!!");

            //}

            //bl.Order.DoOrder(order);
            //MessageBox.Show("Total Price: " + order.finalPrice);
            //CartlistBox.Items.Clear();
            //order = new Order();
        }

        private void ProductListlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void countForOrderUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
