using BlApi;
using BO;
using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace UI
{
    public partial class ProductPage : Form
    {
        private readonly IBl bl = BlApi.Factory.Get();
        private int ProductId;

        public ProductPage()
        {
            InitializeComponent();

            try
            {
                closeAllProductsPanel();
                ProdectDataGridView.DataSource = bl.Product.ReadAll();
                var sales = bl.Product.ReadAll();
                ProdectDataGridView.Visible = true;
            }
            catch
            {
                MessageBox.Show("משהו השתבש בעת הצגת המבצעים");
            }
        }
        public void closeAllProductsPanel()
        {
            UpdateProductpanel.Visible = false;
            ProductPanel.Visible = false;
            ProductPanel.Visible = false;
        }
        private void ProdectShowAllBtn_Click(object sender, EventArgs e)
        {
           
            ProdectDataGridView.AutoGenerateColumns = true;

            closeAllProductsPanel();
            ProdectDataGridView.Visible = true;
            var products = bl.Product.ReadAll();
            //MessageBox.Show("מספר מבצעים: " + products.Count());
            ProdectDataGridView.DataSource = bl.Product.ReadAll();
           
        }

        private void ProductShowBtn_Click(object sender, EventArgs e)
        {
            if (ProdectDataGridView.CurrentRow != null)
            {
                var cells = ProdectDataGridView.CurrentRow.Cells;
                string info = "";

                foreach (DataGridViewCell cell in cells)
                {
                    info += $"{cell.OwningColumn.HeaderText}: {cell.Value}\n";
                }

                MessageBox.Show(info, "פרטי המבצע");
            }
            else
            {
                MessageBox.Show("לא נבחר מבצע להצגה");
            }
            closeAllProductsPanel();
            ProdectDataGridView.Visible = true;
        }

        private void ProdectAddedBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("הוסף");
            closeAllProductsPanel();
            ProductPanel.Visible = true;

        }

        private void ProdectUpdatedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                closeAllProductsPanel();
                UpdateProductpanel.Visible = true;

                ProducrIdlabel2.Text = ProdectDataGridView.CurrentRow.Cells["Id"].Value?.ToString();
                UpdateProductNametextBox.Text = ProdectDataGridView.CurrentRow.Cells["Name"].Value?.ToString();
                UpdateProductCategorycomboBox.Text = ProdectDataGridView.CurrentRow.Cells["Category"].Value?.ToString();

                UpdateProductPricetrackBar.Value = Convert.ToInt32(ProdectDataGridView.CurrentRow.Cells["Price"].Value);
                UpdateProductAmountnumericUpDown.Value = Convert.ToInt32(ProdectDataGridView.CurrentRow.Cells["InStock"].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show("!!!שגיאה בעדכון המוצר\n\n" + ex.Message);
            }
        }


        private void ProdectDeletedBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("מחק  מוצר");
            closeAllProductsPanel();
            ProdectDataGridView.Visible = true;
            try
            {
                if (ProdectDataGridView.CurrentRow != null)
                {
                    string tzString = ProdectDataGridView.CurrentRow.Cells["Id"].Value.ToString();
                    if (int.TryParse(tzString, out int id))
                    {
                        try
                        {
                            bl.Product.Delete(id);
                            //MessageBox.Show("הלקוח נמחק בהצלחה");
                            ProdectDataGridView.DataSource = bl.Product.ReadAll();
                            closeAllProductsPanel();
                            ProdectDataGridView.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("שגיעה במחיקה: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("תעודת הזהות אינה חוקית");
                    }
                }
            }
            catch { }
        }

        private void ProductFilterbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                closeAllProductsPanel();
                ProdectDataGridView.Visible = true;

                if (ProductFiltercomboBox1.SelectedItem != null)
                {
                    ProdectDataGridView.DataSource = bl.Product.ReadAll(s => s.Category == (BO.Categories)Enum.Parse(typeof(BO.Categories), (ProductFiltercomboBox1.SelectedItem.ToString())));                    
                }
                else
                {
                    ProdectDataGridView.DataSource = bl.Product.ReadAll();
                }
                closeAllProductsPanel();
                ProdectDataGridView.Visible = true;
            }
            catch
            {
                MessageBox.Show("סינון המבצעים נכשל");
            }
        }

        private void returnBtn2_Click(object sender, EventArgs e)
        {
            ManagerMenu managerMenu = new ManagerMenu();
            managerMenu.Show();
            this.Hide();
        }

        private void AddProducrbutton_Click_1(object sender, EventArgs e)
        {
            try
            {

                //BO.Product product = new BO.Product();
                string name = ProductNaneTextBox.Text;
                double price = trackBar1.Value;
                int count = (int)ProducrAmountnumericUpDown.Value;
                BO.Categories category = (BO.Categories)Enum.Parse(typeof(BO.Categories), (ProducrCategoryComboBox.SelectedItem.ToString()));
                //(BO.Categories)ProducrCategoryComboBox.SelectedItem;
                bl.Product.Create((new BO.Product(name, price, count, category)));
              
                ProductNaneTextBox.Text = "";
                trackBar1.Value = 1;
                ProducrAmountnumericUpDown.Value = 1;
                ProdectDataGridView.DataSource = bl.Product.ReadAll();
                ProdectDataGridView.Visible = true;
                //MessageBox.Show("המוצר נוסף ");
                closeAllProductsPanel();
                ProdectDataGridView.Visible = true;
            }
            catch
            {
                MessageBox.Show("שגיעה בהוספת המוצר");

            }
        }

        private void UpdateProductbutton_Click(object sender, EventArgs e)
        {

            if (ProdectDataGridView.CurrentRow != null)
            {
                string tzString = ProdectDataGridView.CurrentRow.Cells["Id"].Value.ToString();
                if (int.TryParse(tzString, out int id))
                {
                    try
                    {
                        //SaleIdlabel1.Text = id.ToString();
                        string name = UpdateProductNametextBox.Text;
                        double price = UpdateProductPricetrackBar.Value;
                        int count = (int)UpdateProductAmountnumericUpDown.Value;
                        BO.Categories category = (BO.Categories)Enum.Parse(typeof(BO.Categories), (UpdateProductCategorycomboBox.SelectedItem.ToString()));

                        BO.Product s = new BO.Product(id,name, price, count, category);
                        bl.Product.Update(s);

                        //MessageBox.Show("המבצע עודכן");
                        ProdectDataGridView.DataSource = bl.Product.ReadAll();
                        ProdectDataGridView.Visible = true;
                    }
                
                    catch
                    {
                        MessageBox.Show("שגיעה בעדכון מוצר");
                    }
                }
                else
                {
                    MessageBox.Show("תעודת הזהות אינה חוקית");
                }


            }
        }

        private void UpdateProductPricetrackBar_Scroll(object sender, EventArgs e)
        {
            ProductPricelabel7.Text = UpdateProductPricetrackBar.Value.ToString();

        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ProductPriceLabel.Text = trackBar1.Value.ToString();
        }

        private void ProductFiltercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateProductPricetrackBar_Scroll_1(object sender, EventArgs e)
        {
            ProductPricelabel7.Text = UpdateProductPricetrackBar.Value.ToString();
        }

      
    }
}
