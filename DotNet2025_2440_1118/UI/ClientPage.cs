using BlApi;
using BO;
using DO;
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
    public partial class ClientPage : Form
    {
        private readonly IBl bl = Factory.Get();


        public ClientPage()
        {
            InitializeComponent();
            try
            {
                closeAllClientsPanel();
                ClientDataGridView.DataSource = bl.Client.ReadAll();
                var sales = bl.Client.ReadAll();


                ClientDataGridView.Visible = true;
            }
            catch { MessageBox.Show("שגיאה בטעינת הלקוחות"); }

        }

        public void closeAllClientsPanel()
        {
            UpdateClientpanel1.Visible = false;
            AddClientpanel1.Visible = false;
            ClientDataGridView.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (ClientDataGridView.CurrentRow != null)
            {
                var cells = ClientDataGridView.CurrentRow.Cells;
                string info = "";

                foreach (DataGridViewCell cell in cells)
                {
                    info += $"{cell.OwningColumn.HeaderText}: {cell.Value}\n";
                }

                MessageBox.Show(info, "פרטי לקוח");
                closeAllClientsPanel();
                ClientDataGridView.Visible = true;
            }
            else
            {
                MessageBox.Show("לא נבחר לקוח להצגה");
            }
           
        }
        private void returnBtn3_Click(object sender, EventArgs e)
        {
            ManagerMenu managerMenu = new ManagerMenu();
            managerMenu.Show();
            this.Hide();
        }

        private void ClientShowAllBtn_Click(object sender, EventArgs e)
        {
            
            ClientDataGridView.AutoGenerateColumns = true;

            closeAllClientsPanel();
            ClientDataGridView.Visible = true;
            var clients = bl.Client.ReadAll();
            MessageBox.Show("מספר מבצעים: " + clients.Count());
            ClientDataGridView.DataSource = bl.Client.ReadAll();
            closeAllClientsPanel();
            ClientDataGridView.Visible = true;
        }

        private void ClientAddedBtn_Click(object sender, EventArgs e)
        {
            closeAllClientsPanel();
            AddClientpanel1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
        }

        private void ClientUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                closeAllClientsPanel();
                UpdateClientpanel1.Visible = true;
                ClientIdlabel1.Text = ClientDataGridView.CurrentRow.Cells["Id"].Value.ToString();
                textBox4.Text = ClientDataGridView.CurrentRow.Cells["Name"].Value.ToString();
                textBox3.Text = ClientDataGridView.CurrentRow.Cells["Address"].Value.ToString();
                maskedTextBox2.Text = ClientDataGridView.CurrentRow.Cells["Phone"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("שגיאה בעדכון המבצע");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            closeAllClientsPanel();
            ClientDataGridView.Visible = true;
            ClientDataGridView.DataSource = bl.Client.ReadAll(c => c.Name == ClientTextBox.Text);
        }
        private void ClientDeleteBtn_Click(object sender, EventArgs e)
        {

            if (ClientDataGridView.CurrentRow != null)
            {
                string tzString = ClientDataGridView.CurrentRow.Cells["Id"].Value.ToString();
                if (int.TryParse(tzString, out int id))
                {
                    try
                    {
                        bl.Client.Delete(id);
                        MessageBox.Show("הלקוח נמחק בהצלחה");
                        ClientDataGridView.DataSource = bl.Client.ReadAll();
                        closeAllClientsPanel();
                        ClientDataGridView.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("שגיאה במחיקה: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("תעודת הזהות אינה חוקית");
                }
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            
            if (ClientDataGridView.CurrentRow == null)
            {
                MessageBox.Show("בחר לקוח לעדכון");
                return;
            }

            string tzString = ClientDataGridView.CurrentRow.Cells["Id"].Value.ToString();
            if (int.TryParse(tzString, out int id))
            {
                ClientIdlabel1.Text=id.ToString();
                string name = textBox4.Text;
                string address = textBox3.Text;
                string phone = maskedTextBox2.Text;
              
                BO.Client customer = new BO.Client(id, name, address, phone);
                bl.Client.Update(customer);
                ClientDataGridView.DataSource=bl.Client.ReadAll();
                //MessageBox.Show("עודכן בהצלחה!");
                closeAllClientsPanel();
            ClientDataGridView.Visible = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDown1.Value;
                string name = textBox1.Text;
                string address = textBox2.Text;
                string phone = maskedTextBox1.Text;
                bl.Client.Create(new BO.Client(id, name, address, phone));

                //MessageBox.Show("הלקוח נוסף");
                textBox1.Text = "";
                textBox2.Text = "";
                maskedTextBox1.Text = "";
                ClientDataGridView.DataSource = bl.Client.ReadAll();
                closeAllClientsPanel();
                ClientDataGridView.Visible = true;
            }
            catch
            {
                MessageBox.Show("תקלה בהוספת לקוח");
            }
        }
    }
}
