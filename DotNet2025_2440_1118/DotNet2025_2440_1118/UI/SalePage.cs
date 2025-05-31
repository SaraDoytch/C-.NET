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
    public partial class SalePage : Form
    {
        private readonly IBl bl = Factory.Get();

        public SalePage()
        {
            InitializeComponent();
            SaledataGridView.AutoGenerateColumns = true;

            try
            {
                closeAllSalesPanel();
                SaledataGridView.DataSource = bl.Sale.ReadAll();
                var sales = bl.Sale.ReadAll();
                SaledataGridView.Visible = true;
            }
            catch
            {
                MessageBox.Show("משהו השתבש בעת הצגת המבצעים");
            }
        }
        public void closeAllSalesPanel()
        {
            AddSalepanel1.Visible = false;
            UpdateSalepanel.Visible = false;
            SaledataGridView.Visible = false;

        }

        private void returnBtn4_Click(object sender, EventArgs e)
        {
            ManagerMenu managerMenu = new ManagerMenu();
            managerMenu.Show();
            this.Hide();
        }

        private void SaleShowBtn_Click(object sender, EventArgs e)
        {
           
            if (SaledataGridView.CurrentRow != null)
            {
                var cells = SaledataGridView.CurrentRow.Cells;
                string info = "";

                foreach (DataGridViewCell cell in cells)
                {
                    info += $"{cell.OwningColumn.HeaderText}: {cell.Value}\n";
                }

                MessageBox.Show(info, "פרטי המבצע");
                closeAllSalesPanel();
                SaledataGridView.Visible = true;
            }
            else
            {
                MessageBox.Show("לא נבחר מבצע להצגה");
            }
        }



        private void SaleUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {

                closeAllSalesPanel();
                UpdateSalepanel.Visible = true;
                SaleIdlabel1.Text = SaledataGridView.CurrentRow.Cells["Id"].Value.ToString();
                numericUpDownProductId.Value = Convert.ToInt32(SaledataGridView.CurrentRow.Cells["ProductId"].Value);
                UpdateSaleMinAmountnumericUpDown.Value = Convert.ToInt32(SaledataGridView.CurrentRow.Cells["RequiredAmount"].Value);
                UpdateSalePricetrackBar.Value = Convert.ToInt32(SaledataGridView.CurrentRow.Cells["SalePrice"].Value);
                UpdateSalePricelabel.Text= SaledataGridView.CurrentRow.Cells["SalePrice"].Value.ToString();
                if((bool)SaledataGridView.CurrentRow.Cells["IsForClubMembers"].Value)
                UpdateSaleIsClubMembercheckBox1.Checked= true;
                else
                    UpdateSaleIsClubMembercheckBox1.Checked = false;
                UpdateSaleStartdatedateTimePicker1.Value= (DateTime)SaledataGridView.CurrentRow.Cells["StartDate"].Value;
                UpdateSaleEnddatedateTimePicker2.Value= (DateTime)SaledataGridView.CurrentRow.Cells["EndDate"].Value;
                UpdateSaleStartdatedateTimePicker1.MinDate = DateTime.Now;
                UpdateSaleEnddatedateTimePicker2.MinDate = UpdateSaleStartdatedateTimePicker1.Value;

                closeAllSalesPanel();
                SaledataGridView.Visible = true;
            }
            catch
            {
                MessageBox.Show("שגיאה בעדכון המבצע");

            }
        }



        private void SaleAddedBtn_Click(object sender, EventArgs e)
        {
            closeAllSalesPanel();
            AddSalepanel1.Visible = true;
            AddSalePricelabel1.Text = AddSalePricetrackBar1.Value.ToString();

            SaleIdlabel1.Text = "";
            numericUpDownProductId.Value = 100;
            UpdateSaleMinAmountnumericUpDown.Value =1;
            UpdateSalePricetrackBar.Value =1;
            UpdateSalePricelabel.Text = UpdateSalePricetrackBar.Value.ToString();
            UpdateSaleIsClubMembercheckBox1.Checked =true;
            UpdateSaleStartdatedateTimePicker1.MinDate= DateTime.Now;
            UpdateSaleStartdatedateTimePicker1.Value = DateTime.Now;
            UpdateSaleEnddatedateTimePicker2.MinDate = UpdateSaleStartdatedateTimePicker1.Value;
            UpdateSaleEnddatedateTimePicker2.Value = UpdateSaleStartdatedateTimePicker1.Value;
            closeAllSalesPanel();
            SaledataGridView.Visible = true;
        }

        private void SaleShowAllBtn_Click(object sender, EventArgs e)
        {
            SaledataGridView.AutoGenerateColumns = true;

            closeAllSalesPanel();
            SaledataGridView.Visible = true;
            var sales = bl.Sale.ReadAll();
            //MessageBox.Show("מספר מבצעים: " + sales.Count());
            SaledataGridView.DataSource = bl.Sale.ReadAll();
            closeAllSalesPanel();
            SaledataGridView.Visible = true;
        }

        private void SaleDeleteBtn_Click(object sender, EventArgs e)
        {
           
            if (SaledataGridView.CurrentRow != null)
            {
                string tzString = SaledataGridView.CurrentRow.Cells["Id"].Value.ToString();
                if (int.TryParse(tzString, out int id))
                {
                    try
                    {
                        bl.Sale.Delete(id);
                        //MessageBox.Show("הלקוח נמחק בהצלחה");
                        SaledataGridView.DataSource = bl.Sale.ReadAll();
                        closeAllSalesPanel();
                        SaledataGridView.Visible = true;
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                closeAllSalesPanel();
                SaledataGridView.Visible = true;

                if (SaleFiltercheckBox1.Checked == true)
                {
                    SaledataGridView.DataSource = bl.Sale.ReadAll(s => s.IsForClubMembers == true);
                }
                else
                 if (SaleFiltercheckBox1.Checked == false)
                {
                    SaledataGridView.DataSource = bl.Sale.ReadAll(s => s.IsForClubMembers == false);
                }
                closeAllSalesPanel();
                SaledataGridView.Visible = true;
            }
            catch
            {
                MessageBox.Show("סינון המבצעים נכשל");
            }


        }
        private void UpdateProductbutton_Click(object sender, EventArgs e)
        {
            if (SaledataGridView.CurrentRow != null)
            {
                string tzString = SaledataGridView.CurrentRow.Cells["Id"].Value.ToString();
                if (int.TryParse(tzString, out int id))
                {
                    try
                    {

                        SaleIdlabel1.Text = id.ToString();
                        int ProductId = (int)numericUpDownProductId.Value;
                        int CountInSale = (int)UpdateSaleMinAmountnumericUpDown.Value;
                        int TotalPrice = (int)UpdateSalePricetrackBar.Value;
                        bool AllCustomer = !UpdateSaleIsClubMembercheckBox1.Checked;
                        DateTime StartSale = UpdateSaleStartdatedateTimePicker1.Value;
                        DateTime EndSale = UpdateSaleEnddatedateTimePicker2.Value;
                        BO.Sale s = new BO.Sale(id, ProductId, CountInSale, TotalPrice, AllCustomer, StartSale, EndSale);
                        bl.Sale.Update(s);
                        SaledataGridView.DataSource = bl.Sale.ReadAll();

                        //MessageBox.Show("המבצע עודכן");
                        SaledataGridView.DataSource = bl.Sale.ReadAll();
                        closeAllSalesPanel();
                        SaledataGridView.Visible = true;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("שגיאה במחיקה: " + ex.Message);
                    }
                    catch
                    {
                        MessageBox.Show("שגיאה בעדכון מוצר");
                    }
                }
                else
                {
                    MessageBox.Show("תעודת הזהות אינה חוקית");
                }

            }
        }
        private void AddSalebutton1_Click(object sender, EventArgs e)
        {
            try
            {

                int idProduct = int.Parse(AddSaleIdnumericUpDown2.Text);
                int count = int.Parse(AddSaleMinAmountnumericUpDown1.Text);
                double price = Convert.ToDouble(AddSalePricetrackBar1.Value);
                bool club = AddSaleIsClubMembercheckBox2.Checked;
                DateTime start = AddSaleStartdateTimePicker4.Value;
                DateTime finish = AddSaleEnddateTimePicker3.Value;
                bl.Sale.Create(new BO.Sale(1,idProduct, count, price, club, start, finish));
                SaledataGridView.DataSource = bl.Sale.ReadAll();
                SaledataGridView.Visible=true;
                closeAllSalesPanel();
                SaledataGridView.Visible = true;
                //MessageBox.Show("המבצע נוסף בהצלחה!");
            }
            catch (BL_NoExistException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("אירעה שגיאה: " + ex.Message);
            }
        }

        private void AddSalePricetrackBar1_Scroll(object sender, EventArgs e)
        {
            AddSalePricelabel1.Text = AddSalePricetrackBar1.Value.ToString();

        }

        private void UpdateSalePricetrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateSalePricelabel.Text = UpdateSalePricetrackBar.Value.ToString();

        }


    }
}
