
namespace UI
{
    partial class ProductPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPage));
            ProductFilterbutton1 = new Button();
            ProductFiltercomboBox1 = new ComboBox();
            UpdateProductpanel = new Panel();
            ProducrIdlabel2 = new Label();
            label1 = new Label();
            UpdateProductbutton = new Button();
            ProductPricelabel7 = new Label();
            UpdateProductPricetrackBar = new TrackBar();
            UpdateProductAmountnumericUpDown = new NumericUpDown();
            UpdateProductNametextBox = new TextBox();
            UpdateProductCategorycomboBox = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            returnBtn2 = new Button();
            ProductPanel = new Panel();
            AddProducrbutton = new Button();
            ProductPriceLabel = new Label();
            trackBar1 = new TrackBar();
            ProducrAmountnumericUpDown = new NumericUpDown();
            ProductNaneTextBox = new TextBox();
            ProducrCategoryComboBox = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ProdectDeletedBtn = new Button();
            ProdectUpdatedBtn = new Button();
            ProdectAddedBtn = new Button();
            ProdectShowAllBtn = new Button();
            ProductShowBtn = new Button();
            ProdectDataGridView = new DataGridView();
            UpdateProductpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateProductPricetrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateProductAmountnumericUpDown).BeginInit();
            ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProducrAmountnumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProdectDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductFilterbutton1
            // 
            ProductFilterbutton1.Location = new Point(611, 356);
            ProductFilterbutton1.Name = "ProductFilterbutton1";
            ProductFilterbutton1.Size = new Size(142, 29);
            ProductFilterbutton1.TabIndex = 40;
            ProductFilterbutton1.Text = "סנן לפי קטגוריה";
            ProductFilterbutton1.UseVisualStyleBackColor = true;
            ProductFilterbutton1.Click += ProductFilterbutton1_Click;
            // 
            // ProductFiltercomboBox1
            // 
            ProductFiltercomboBox1.FormattingEnabled = true;
            ProductFiltercomboBox1.Items.AddRange(new object[] { " קלויים", " טבעיים", " יבשים", " תבלינים", "שוקולדים" });
            ProductFiltercomboBox1.Location = new Point(437, 356);
            ProductFiltercomboBox1.Name = "ProductFiltercomboBox1";
            ProductFiltercomboBox1.Size = new Size(151, 28);
            ProductFiltercomboBox1.TabIndex = 39;
            ProductFiltercomboBox1.SelectedIndexChanged += ProductFiltercomboBox1_SelectedIndexChanged;
            // 
            // UpdateProductpanel
            // 
            UpdateProductpanel.Controls.Add(ProducrIdlabel2);
            UpdateProductpanel.Controls.Add(label1);
            UpdateProductpanel.Controls.Add(UpdateProductbutton);
            UpdateProductpanel.Controls.Add(ProductPricelabel7);
            UpdateProductpanel.Controls.Add(UpdateProductPricetrackBar);
            UpdateProductpanel.Controls.Add(UpdateProductAmountnumericUpDown);
            UpdateProductpanel.Controls.Add(UpdateProductNametextBox);
            UpdateProductpanel.Controls.Add(UpdateProductCategorycomboBox);
            UpdateProductpanel.Controls.Add(label8);
            UpdateProductpanel.Controls.Add(label9);
            UpdateProductpanel.Controls.Add(label10);
            UpdateProductpanel.Controls.Add(label11);
            UpdateProductpanel.Location = new Point(263, 18);
            UpdateProductpanel.Name = "UpdateProductpanel";
            UpdateProductpanel.Size = new Size(329, 273);
            UpdateProductpanel.TabIndex = 38;
            UpdateProductpanel.Visible = false;
            // 
            // ProducrIdlabel2
            // 
            ProducrIdlabel2.AutoSize = true;
            ProducrIdlabel2.Location = new Point(142, 27);
            ProducrIdlabel2.Name = "ProducrIdlabel2";
            ProducrIdlabel2.Size = new Size(0, 20);
            ProducrIdlabel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 28);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 12;
            label1.Text = "קוד מוצר";
            // 
            // UpdateProductbutton
            // 
            UpdateProductbutton.Location = new Point(128, 236);
            UpdateProductbutton.Name = "UpdateProductbutton";
            UpdateProductbutton.Size = new Size(94, 29);
            UpdateProductbutton.TabIndex = 11;
            UpdateProductbutton.Text = "עדכן";
            UpdateProductbutton.UseVisualStyleBackColor = true;
            UpdateProductbutton.Click += UpdateProductbutton_Click;
            // 
            // ProductPricelabel7
            // 
            ProductPricelabel7.AutoSize = true;
            ProductPricelabel7.Location = new Point(206, 152);
            ProductPricelabel7.Name = "ProductPricelabel7";
            ProductPricelabel7.Size = new Size(17, 20);
            ProductPricelabel7.TabIndex = 10;
            ProductPricelabel7.Text = "1";
            // 
            // UpdateProductPricetrackBar
            // 
            UpdateProductPricetrackBar.LargeChange = 1;
            UpdateProductPricetrackBar.Location = new Point(40, 135);
            UpdateProductPricetrackBar.Maximum = 100;
            UpdateProductPricetrackBar.Minimum = 1;
            UpdateProductPricetrackBar.Name = "UpdateProductPricetrackBar";
            UpdateProductPricetrackBar.Size = new Size(130, 56);
            UpdateProductPricetrackBar.TabIndex = 9;
            UpdateProductPricetrackBar.Value = 20;
            UpdateProductPricetrackBar.Scroll += UpdateProductPricetrackBar_Scroll_1;
            // 
            // UpdateProductAmountnumericUpDown
            // 
            UpdateProductAmountnumericUpDown.Location = new Point(57, 195);
            UpdateProductAmountnumericUpDown.Name = "UpdateProductAmountnumericUpDown";
            UpdateProductAmountnumericUpDown.Size = new Size(150, 27);
            UpdateProductAmountnumericUpDown.TabIndex = 8;
            // 
            // UpdateProductNametextBox
            // 
            UpdateProductNametextBox.Location = new Point(57, 59);
            UpdateProductNametextBox.Name = "UpdateProductNametextBox";
            UpdateProductNametextBox.Size = new Size(149, 27);
            UpdateProductNametextBox.TabIndex = 6;
            // 
            // UpdateProductCategorycomboBox
            // 
            UpdateProductCategorycomboBox.FormattingEnabled = true;
            UpdateProductCategorycomboBox.Items.AddRange(new object[] { " קלויים", " טבעיים", " יבשים", " תבלינים", "שוקולדים" });
            UpdateProductCategorycomboBox.Location = new Point(56, 101);
            UpdateProductCategorycomboBox.Name = "UpdateProductCategorycomboBox";
            UpdateProductCategorycomboBox.Size = new Size(151, 28);
            UpdateProductCategorycomboBox.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(263, 196);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 4;
            label8.Text = "כמות";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(272, 152);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 3;
            label9.Text = "מחיר";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(261, 100);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 2;
            label10.Text = "קטגוריה";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(261, 59);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 1;
            label11.Text = "שם מוצר";
            // 
            // returnBtn2
            // 
            returnBtn2.Location = new Point(93, 397);
            returnBtn2.Name = "returnBtn2";
            returnBtn2.Size = new Size(94, 29);
            returnBtn2.TabIndex = 37;
            returnBtn2.Text = "חזור";
            returnBtn2.UseVisualStyleBackColor = true;
            returnBtn2.Click += returnBtn2_Click;
            // 
            // ProductPanel
            // 
            ProductPanel.Controls.Add(AddProducrbutton);
            ProductPanel.Controls.Add(ProductPriceLabel);
            ProductPanel.Controls.Add(UpdateProductpanel);
            ProductPanel.Controls.Add(trackBar1);
            ProductPanel.Controls.Add(ProducrAmountnumericUpDown);
            ProductPanel.Controls.Add(ProductNaneTextBox);
            ProductPanel.Controls.Add(ProducrCategoryComboBox);
            ProductPanel.Controls.Add(label6);
            ProductPanel.Controls.Add(label5);
            ProductPanel.Controls.Add(label4);
            ProductPanel.Controls.Add(label3);
            ProductPanel.Location = new Point(51, 24);
            ProductPanel.Name = "ProductPanel";
            ProductPanel.Size = new Size(327, 275);
            ProductPanel.TabIndex = 36;
            ProductPanel.Visible = false;
            // 
            // AddProducrbutton
            // 
            AddProducrbutton.Location = new Point(85, 232);
            AddProducrbutton.Name = "AddProducrbutton";
            AddProducrbutton.Size = new Size(94, 29);
            AddProducrbutton.TabIndex = 41;
            AddProducrbutton.Text = "הוסף";
            AddProducrbutton.UseVisualStyleBackColor = true;
            AddProducrbutton.Click += AddProducrbutton_Click_1;
            // 
            // ProductPriceLabel
            // 
            ProductPriceLabel.AutoSize = true;
            ProductPriceLabel.Location = new Point(206, 152);
            ProductPriceLabel.Name = "ProductPriceLabel";
            ProductPriceLabel.Size = new Size(0, 20);
            ProductPriceLabel.TabIndex = 10;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(40, 135);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(130, 56);
            trackBar1.TabIndex = 9;
            trackBar1.Value = 20;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // ProducrAmountnumericUpDown
            // 
            ProducrAmountnumericUpDown.Location = new Point(57, 195);
            ProducrAmountnumericUpDown.Name = "ProducrAmountnumericUpDown";
            ProducrAmountnumericUpDown.Size = new Size(150, 27);
            ProducrAmountnumericUpDown.TabIndex = 8;
            // 
            // ProductNaneTextBox
            // 
            ProductNaneTextBox.Location = new Point(57, 59);
            ProductNaneTextBox.Name = "ProductNaneTextBox";
            ProductNaneTextBox.Size = new Size(149, 27);
            ProductNaneTextBox.TabIndex = 6;
            // 
            // ProducrCategoryComboBox
            // 
            ProducrCategoryComboBox.FormattingEnabled = true;
            ProducrCategoryComboBox.Items.AddRange(new object[] { " קלויים", " טבעיים", " יבשים", " תבלינים", "שוקולדים" });
            ProducrCategoryComboBox.Location = new Point(56, 101);
            ProducrCategoryComboBox.Name = "ProducrCategoryComboBox";
            ProducrCategoryComboBox.Size = new Size(151, 28);
            ProducrCategoryComboBox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(263, 196);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 4;
            label6.Text = "כמות";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 152);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 3;
            label5.Text = "מחיר";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 100);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 2;
            label4.Text = "קטגוריה";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 59);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 1;
            label3.Text = "שם מוצר";
            // 
            // ProdectDeletedBtn
            // 
            ProdectDeletedBtn.Location = new Point(659, 311);
            ProdectDeletedBtn.Name = "ProdectDeletedBtn";
            ProdectDeletedBtn.Size = new Size(94, 29);
            ProdectDeletedBtn.TabIndex = 35;
            ProdectDeletedBtn.Text = "מחק מוצר";
            ProdectDeletedBtn.UseVisualStyleBackColor = true;
            ProdectDeletedBtn.Click += ProdectDeletedBtn_Click;
            // 
            // ProdectUpdatedBtn
            // 
            ProdectUpdatedBtn.Location = new Point(659, 256);
            ProdectUpdatedBtn.Name = "ProdectUpdatedBtn";
            ProdectUpdatedBtn.Size = new Size(94, 29);
            ProdectUpdatedBtn.TabIndex = 34;
            ProdectUpdatedBtn.Text = "עדכן מוצר";
            ProdectUpdatedBtn.UseVisualStyleBackColor = true;
            ProdectUpdatedBtn.Click += ProdectUpdatedBtn_Click;
            // 
            // ProdectAddedBtn
            // 
            ProdectAddedBtn.Location = new Point(659, 203);
            ProdectAddedBtn.Name = "ProdectAddedBtn";
            ProdectAddedBtn.Size = new Size(94, 29);
            ProdectAddedBtn.TabIndex = 33;
            ProdectAddedBtn.Text = "הוסף מוצר";
            ProdectAddedBtn.UseVisualStyleBackColor = true;
            ProdectAddedBtn.Click += ProdectAddedBtn_Click;
            // 
            // ProdectShowAllBtn
            // 
            ProdectShowAllBtn.Location = new Point(581, 152);
            ProdectShowAllBtn.Name = "ProdectShowAllBtn";
            ProdectShowAllBtn.Size = new Size(173, 29);
            ProdectShowAllBtn.TabIndex = 32;
            ProdectShowAllBtn.Text = "הצג את כל המוצרים";
            ProdectShowAllBtn.UseVisualStyleBackColor = true;
            ProdectShowAllBtn.Click += ProdectShowAllBtn_Click;
            // 
            // ProductShowBtn
            // 
            ProductShowBtn.Location = new Point(659, 103);
            ProductShowBtn.Name = "ProductShowBtn";
            ProductShowBtn.Size = new Size(94, 29);
            ProductShowBtn.TabIndex = 31;
            ProductShowBtn.Text = "הצג מוצר";
            ProductShowBtn.UseVisualStyleBackColor = true;
            ProductShowBtn.Click += ProductShowBtn_Click;
            // 
            // ProdectDataGridView
            // 
            ProdectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdectDataGridView.Location = new Point(51, 51);
            ProdectDataGridView.Name = "ProdectDataGridView";
            ProdectDataGridView.ReadOnly = true;
            ProdectDataGridView.RowHeadersWidth = 51;
            ProdectDataGridView.Size = new Size(451, 247);
            ProdectDataGridView.TabIndex = 30;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(821, 509);
            Controls.Add(ProductFilterbutton1);
            Controls.Add(ProductFiltercomboBox1);
            Controls.Add(returnBtn2);
            Controls.Add(ProductPanel);
            Controls.Add(ProdectDeletedBtn);
            Controls.Add(ProdectUpdatedBtn);
            Controls.Add(ProdectAddedBtn);
            Controls.Add(ProdectShowAllBtn);
            Controls.Add(ProductShowBtn);
            Controls.Add(ProdectDataGridView);
            Name = "ProductPage";
            Text = "Product";
            UpdateProductpanel.ResumeLayout(false);
            UpdateProductpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateProductPricetrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateProductAmountnumericUpDown).EndInit();
            ProductPanel.ResumeLayout(false);
            ProductPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProducrAmountnumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProdectDataGridView).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Button ProductFilterbutton1;
        private ComboBox ProductFiltercomboBox1;
        private Panel UpdateProductpanel;
        private Button UpdateProductbutton;
        private Label ProductPricelabel7;
        private TrackBar UpdateProductPricetrackBar;
        private NumericUpDown UpdateProductAmountnumericUpDown;
        private TextBox UpdateProductNametextBox;
        private ComboBox UpdateProductCategorycomboBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button returnBtn2;
        private Panel ProductPanel;
        private Label ProductPriceLabel;
        private TrackBar trackBar1;
        private NumericUpDown ProducrAmountnumericUpDown;
        private TextBox ProductNaneTextBox;
        private ComboBox ProducrCategoryComboBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button ProdectDeletedBtn;
        private Button ProdectUpdatedBtn;
        private Button ProdectAddedBtn;
        private Button ProdectShowAllBtn;
        private Button ProductShowBtn;
        private DataGridView ProdectDataGridView;
        private Button AddProducrbutton;
        private Label label1;
        private Label ProducrIdlabel2;
    }
}