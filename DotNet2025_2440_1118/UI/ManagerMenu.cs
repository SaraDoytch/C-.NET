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
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            ProductPage p = new ProductPage();
            p.Show();
            this.Hide();
        }

        private void ClientsBtn_Click(object sender, EventArgs e)
        {
            ClientPage c = new ClientPage();
            c.Show();
            this.Hide();
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            SalePage s = new SalePage();
            s.Show();
            this.Hide();
        }

        private void returnBtn1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
