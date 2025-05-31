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
    public partial class EmployeeMenu : Form
    {
        private readonly IBl bl;

        public EmployeeMenu()
        {
            InitializeComponent();

        }

        private void returnBtn5_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrdersPage order = new OrdersPage();
            //bl.order.DoOrder(new BO.Order());
            order.Show();
            this.Hide();
        }
    }
}
