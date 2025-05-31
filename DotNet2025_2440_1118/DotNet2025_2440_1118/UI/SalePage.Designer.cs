namespace UI
{
    partial class SalePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalePage));
            SaleDeleteBtn = new Button();
            SaleUpdateBtn = new Button();
            SaleAddedBtn = new Button();
            SaleShowAllBtn = new Button();
            SaleShowBtn = new Button();
            SaledataGridView = new DataGridView();
            returnBtn4 = new Button();
            UpdateSalepanel = new Panel();
            SaleIdlabel1 = new Label();
            labelProductId = new Label();
            numericUpDownProductId = new NumericUpDown();
            UpdateSalePricelabel = new Label();
            UpdateSaleEnddatedateTimePicker2 = new DateTimePicker();
            UpdateSaleStartdatedateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            UpdateSaleIsClubMembercheckBox1 = new CheckBox();
            UpdateProductbutton = new Button();
            UpdateSalePricetrackBar = new TrackBar();
            UpdateSaleMinAmountnumericUpDown = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            AddSalepanel1 = new Panel();
            AddSalePricelabel1 = new Label();
            AddSaleEnddateTimePicker3 = new DateTimePicker();
            AddSaleStartdateTimePicker4 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            AddSaleIsClubMembercheckBox2 = new CheckBox();
            AddSalebutton1 = new Button();
            label6 = new Label();
            AddSalePricetrackBar1 = new TrackBar();
            AddSaleMinAmountnumericUpDown1 = new NumericUpDown();
            AddSaleIdnumericUpDown2 = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SaleFilterbutton1 = new Button();
            SaleFiltercheckBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)SaledataGridView).BeginInit();
            UpdateSalepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateSalePricetrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpdateSaleMinAmountnumericUpDown).BeginInit();
            AddSalepanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddSalePricetrackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddSaleMinAmountnumericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddSaleIdnumericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // SaleDeleteBtn
            // 
            SaleDeleteBtn.Location = new Point(717, 301);
            SaleDeleteBtn.Name = "SaleDeleteBtn";
            SaleDeleteBtn.Size = new Size(94, 29);
            SaleDeleteBtn.TabIndex = 22;
            SaleDeleteBtn.Text = "מחק מבצע";
            SaleDeleteBtn.UseVisualStyleBackColor = true;
            SaleDeleteBtn.Click += SaleDeleteBtn_Click;
            // 
            // SaleUpdateBtn
            // 
            SaleUpdateBtn.Location = new Point(717, 246);
            SaleUpdateBtn.Name = "SaleUpdateBtn";
            SaleUpdateBtn.Size = new Size(94, 29);
            SaleUpdateBtn.TabIndex = 21;
            SaleUpdateBtn.Text = "עדכן מבצע";
            SaleUpdateBtn.UseVisualStyleBackColor = true;
            SaleUpdateBtn.Click += SaleUpdateBtn_Click;
            // 
            // SaleAddedBtn
            // 
            SaleAddedBtn.Location = new Point(717, 192);
            SaleAddedBtn.Name = "SaleAddedBtn";
            SaleAddedBtn.Size = new Size(94, 29);
            SaleAddedBtn.TabIndex = 20;
            SaleAddedBtn.Text = "הוסף מבצע";
            SaleAddedBtn.UseVisualStyleBackColor = true;
            SaleAddedBtn.Click += SaleAddedBtn_Click;
            // 
            // SaleShowAllBtn
            // 
            SaleShowAllBtn.Location = new Point(638, 142);
            SaleShowAllBtn.Name = "SaleShowAllBtn";
            SaleShowAllBtn.Size = new Size(173, 29);
            SaleShowAllBtn.TabIndex = 19;
            SaleShowAllBtn.Text = "הצג את כל המבצעים";
            SaleShowAllBtn.UseVisualStyleBackColor = true;
            SaleShowAllBtn.Click += SaleShowAllBtn_Click;
            // 
            // SaleShowBtn
            // 
            SaleShowBtn.Location = new Point(717, 93);
            SaleShowBtn.Name = "SaleShowBtn";
            SaleShowBtn.Size = new Size(94, 29);
            SaleShowBtn.TabIndex = 18;
            SaleShowBtn.Text = "הצג מבצע";
            SaleShowBtn.UseVisualStyleBackColor = true;
            SaleShowBtn.Click += SaleShowBtn_Click;
            // 
            // SaledataGridView
            // 
            SaledataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SaledataGridView.Location = new Point(21, 97);
            SaledataGridView.Name = "SaledataGridView";
            SaledataGridView.ReadOnly = true;
            SaledataGridView.RowHeadersWidth = 51;
            SaledataGridView.Size = new Size(533, 188);
            SaledataGridView.TabIndex = 17;
            // 
            // returnBtn4
            // 
            returnBtn4.Location = new Point(58, 380);
            returnBtn4.Name = "returnBtn4";
            returnBtn4.Size = new Size(94, 29);
            returnBtn4.TabIndex = 26;
            returnBtn4.Text = "חזור";
            returnBtn4.UseVisualStyleBackColor = true;
            returnBtn4.Click += returnBtn4_Click;
            // 
            // UpdateSalepanel
            // 
            UpdateSalepanel.Controls.Add(SaleIdlabel1);
            UpdateSalepanel.Controls.Add(labelProductId);
            UpdateSalepanel.Controls.Add(numericUpDownProductId);
            UpdateSalepanel.Controls.Add(UpdateSalePricelabel);
            UpdateSalepanel.Controls.Add(UpdateSaleEnddatedateTimePicker2);
            UpdateSalepanel.Controls.Add(UpdateSaleStartdatedateTimePicker1);
            UpdateSalepanel.Controls.Add(label3);
            UpdateSalepanel.Controls.Add(label2);
            UpdateSalepanel.Controls.Add(UpdateSaleIsClubMembercheckBox1);
            UpdateSalepanel.Controls.Add(UpdateProductbutton);
            UpdateSalepanel.Controls.Add(UpdateSalePricetrackBar);
            UpdateSalepanel.Controls.Add(UpdateSaleMinAmountnumericUpDown);
            UpdateSalepanel.Controls.Add(label10);
            UpdateSalepanel.Controls.Add(label11);
            UpdateSalepanel.Controls.Add(label12);
            UpdateSalepanel.Location = new Point(30, 30);
            UpdateSalepanel.Name = "UpdateSalepanel";
            UpdateSalepanel.Size = new Size(403, 379);
            UpdateSalepanel.TabIndex = 28;
            UpdateSalepanel.Visible = false;
            // 
            // SaleIdlabel1
            // 
            SaleIdlabel1.AutoSize = true;
            SaleIdlabel1.Location = new Point(208, 27);
            SaleIdlabel1.Name = "SaleIdlabel1";
            SaleIdlabel1.Size = new Size(0, 20);
            SaleIdlabel1.TabIndex = 31;
            // 
            // labelProductId
            // 
            labelProductId.AutoSize = true;
            labelProductId.Location = new Point(285, 72);
            labelProductId.Name = "labelProductId";
            labelProductId.Size = new Size(65, 20);
            labelProductId.TabIndex = 30;
            labelProductId.Text = "קוד מוצר";
            // 
            // numericUpDownProductId
            // 
            numericUpDownProductId.Location = new Point(27, 70);
            numericUpDownProductId.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownProductId.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownProductId.Name = "numericUpDownProductId";
            numericUpDownProductId.Size = new Size(150, 27);
            numericUpDownProductId.TabIndex = 29;
            numericUpDownProductId.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // UpdateSalePricelabel
            // 
            UpdateSalePricelabel.AutoSize = true;
            UpdateSalePricelabel.Location = new Point(197, 159);
            UpdateSalePricelabel.Name = "UpdateSalePricelabel";
            UpdateSalePricelabel.Size = new Size(0, 20);
            UpdateSalePricelabel.TabIndex = 17;
            // 
            // UpdateSaleEnddatedateTimePicker2
            // 
            UpdateSaleEnddatedateTimePicker2.Location = new Point(20, 270);
            UpdateSaleEnddatedateTimePicker2.MinDate = new DateTime(2025, 5, 22, 0, 0, 0, 0);
            UpdateSaleEnddatedateTimePicker2.Name = "UpdateSaleEnddatedateTimePicker2";
            UpdateSaleEnddatedateTimePicker2.Size = new Size(250, 27);
            UpdateSaleEnddatedateTimePicker2.TabIndex = 16;
            // 
            // UpdateSaleStartdatedateTimePicker1
            // 
            UpdateSaleStartdatedateTimePicker1.Location = new Point(20, 235);
            UpdateSaleStartdatedateTimePicker1.MinDate = new DateTime(2025, 5, 22, 0, 0, 0, 0);
            UpdateSaleStartdatedateTimePicker1.Name = "UpdateSaleStartdatedateTimePicker1";
            UpdateSaleStartdatedateTimePicker1.Size = new Size(243, 27);
            UpdateSaleStartdatedateTimePicker1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 272);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 14;
            label3.Text = "סיום המבצע";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 235);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 13;
            label2.Text = "תחילת המבצע";
            // 
            // UpdateSaleIsClubMembercheckBox1
            // 
            UpdateSaleIsClubMembercheckBox1.AutoSize = true;
            UpdateSaleIsClubMembercheckBox1.Checked = true;
            UpdateSaleIsClubMembercheckBox1.CheckState = CheckState.Checked;
            UpdateSaleIsClubMembercheckBox1.Location = new Point(261, 196);
            UpdateSaleIsClubMembercheckBox1.Name = "UpdateSaleIsClubMembercheckBox1";
            UpdateSaleIsClubMembercheckBox1.Size = new Size(112, 24);
            UpdateSaleIsClubMembercheckBox1.TabIndex = 12;
            UpdateSaleIsClubMembercheckBox1.Text = "לחברי מועדון";
            UpdateSaleIsClubMembercheckBox1.UseVisualStyleBackColor = true;
            // 
            // UpdateProductbutton
            // 
            UpdateProductbutton.Location = new Point(140, 326);
            UpdateProductbutton.Name = "UpdateProductbutton";
            UpdateProductbutton.Size = new Size(94, 29);
            UpdateProductbutton.TabIndex = 11;
            UpdateProductbutton.Text = "עדכן";
            UpdateProductbutton.UseVisualStyleBackColor = true;
            UpdateProductbutton.Click += UpdateProductbutton_Click;
            // 
            // UpdateSalePricetrackBar
            // 
            UpdateSalePricetrackBar.LargeChange = 1;
            UpdateSalePricetrackBar.Location = new Point(27, 151);
            UpdateSalePricetrackBar.Maximum = 100;
            UpdateSalePricetrackBar.Minimum = 1;
            UpdateSalePricetrackBar.Name = "UpdateSalePricetrackBar";
            UpdateSalePricetrackBar.Size = new Size(130, 56);
            UpdateSalePricetrackBar.TabIndex = 9;
            UpdateSalePricetrackBar.Value = 20;
            UpdateSalePricetrackBar.Scroll += UpdateSalePricetrackBar_Scroll;
            // 
            // UpdateSaleMinAmountnumericUpDown
            // 
            UpdateSaleMinAmountnumericUpDown.Location = new Point(7, 118);
            UpdateSaleMinAmountnumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            UpdateSaleMinAmountnumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            UpdateSaleMinAmountnumericUpDown.Name = "UpdateSaleMinAmountnumericUpDown";
            UpdateSaleMinAmountnumericUpDown.Size = new Size(150, 27);
            UpdateSaleMinAmountnumericUpDown.TabIndex = 8;
            UpdateSaleMinAmountnumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(287, 159);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 2;
            label10.Text = "מחיר מבצע";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(163, 118);
            label11.Name = "label11";
            label11.Size = new Size(233, 20);
            label11.TabIndex = 1;
            label11.Text = "כמות מינימלית להשתתפות במבצע";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(296, 26);
            label12.Name = "label12";
            label12.Size = new Size(71, 20);
            label12.TabIndex = 0;
            label12.Text = "קוד מבצע";
            // 
            // AddSalepanel1
            // 
            AddSalepanel1.Controls.Add(AddSalePricelabel1);
            AddSalepanel1.Controls.Add(AddSaleEnddateTimePicker3);
            AddSalepanel1.Controls.Add(AddSaleStartdateTimePicker4);
            AddSalepanel1.Controls.Add(label4);
            AddSalepanel1.Controls.Add(label5);
            AddSalepanel1.Controls.Add(AddSaleIsClubMembercheckBox2);
            AddSalepanel1.Controls.Add(AddSalebutton1);
            AddSalepanel1.Controls.Add(label6);
            AddSalepanel1.Controls.Add(AddSalePricetrackBar1);
            AddSalepanel1.Controls.Add(AddSaleMinAmountnumericUpDown1);
            AddSalepanel1.Controls.Add(AddSaleIdnumericUpDown2);
            AddSalepanel1.Controls.Add(label7);
            AddSalepanel1.Controls.Add(label8);
            AddSalepanel1.Controls.Add(label9);
            AddSalepanel1.Location = new Point(30, 33);
            AddSalepanel1.Name = "AddSalepanel1";
            AddSalepanel1.Size = new Size(403, 313);
            AddSalepanel1.TabIndex = 29;
            AddSalepanel1.Visible = false;
            // 
            // AddSalePricelabel1
            // 
            AddSalePricelabel1.AutoSize = true;
            AddSalePricelabel1.Location = new Point(200, 106);
            AddSalePricelabel1.Name = "AddSalePricelabel1";
            AddSalePricelabel1.Size = new Size(0, 20);
            AddSalePricelabel1.TabIndex = 17;
            // 
            // AddSaleEnddateTimePicker3
            // 
            AddSaleEnddateTimePicker3.Location = new Point(29, 220);
            AddSaleEnddateTimePicker3.MinDate = new DateTime(2025, 5, 22, 0, 0, 0, 0);
            AddSaleEnddateTimePicker3.Name = "AddSaleEnddateTimePicker3";
            AddSaleEnddateTimePicker3.Size = new Size(250, 27);
            AddSaleEnddateTimePicker3.TabIndex = 16;
            // 
            // AddSaleStartdateTimePicker4
            // 
            AddSaleStartdateTimePicker4.Location = new Point(29, 179);
            AddSaleStartdateTimePicker4.MinDate = new DateTime(2025, 5, 22, 0, 0, 0, 0);
            AddSaleStartdateTimePicker4.Name = "AddSaleStartdateTimePicker4";
            AddSaleStartdateTimePicker4.Size = new Size(243, 27);
            AddSaleStartdateTimePicker4.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 216);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 14;
            label4.Text = "סיום המבצע";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 179);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 13;
            label5.Text = "תחילת המבצע";
            // 
            // AddSaleIsClubMembercheckBox2
            // 
            AddSaleIsClubMembercheckBox2.AutoSize = true;
            AddSaleIsClubMembercheckBox2.Checked = true;
            AddSaleIsClubMembercheckBox2.CheckState = CheckState.Checked;
            AddSaleIsClubMembercheckBox2.Location = new Point(278, 140);
            AddSaleIsClubMembercheckBox2.Name = "AddSaleIsClubMembercheckBox2";
            AddSaleIsClubMembercheckBox2.Size = new Size(100, 24);
            AddSaleIsClubMembercheckBox2.TabIndex = 12;
            AddSaleIsClubMembercheckBox2.Text = "חבר מועדון";
            AddSaleIsClubMembercheckBox2.UseVisualStyleBackColor = true;
            // 
            // AddSalebutton1
            // 
            AddSalebutton1.Location = new Point(149, 270);
            AddSalebutton1.Name = "AddSalebutton1";
            AddSalebutton1.Size = new Size(94, 29);
            AddSalebutton1.TabIndex = 11;
            AddSalebutton1.Text = "הוסף";
            AddSalebutton1.UseVisualStyleBackColor = true;
            AddSalebutton1.Click += AddSalebutton1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 152);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 10;
            // 
            // AddSalePricetrackBar1
            // 
            AddSalePricetrackBar1.LargeChange = 1;
            AddSalePricetrackBar1.Location = new Point(36, 95);
            AddSalePricetrackBar1.Maximum = 100;
            AddSalePricetrackBar1.Minimum = 1;
            AddSalePricetrackBar1.Name = "AddSalePricetrackBar1";
            AddSalePricetrackBar1.Size = new Size(130, 56);
            AddSalePricetrackBar1.TabIndex = 9;
            AddSalePricetrackBar1.Value = 30;
            AddSalePricetrackBar1.Scroll += AddSalePricetrackBar1_Scroll;
            // 
            // AddSaleMinAmountnumericUpDown1
            // 
            AddSaleMinAmountnumericUpDown1.Location = new Point(16, 62);
            AddSaleMinAmountnumericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            AddSaleMinAmountnumericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AddSaleMinAmountnumericUpDown1.Name = "AddSaleMinAmountnumericUpDown1";
            AddSaleMinAmountnumericUpDown1.Size = new Size(150, 27);
            AddSaleMinAmountnumericUpDown1.TabIndex = 8;
            AddSaleMinAmountnumericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // AddSaleIdnumericUpDown2
            // 
            AddSaleIdnumericUpDown2.Location = new Point(16, 24);
            AddSaleIdnumericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            AddSaleIdnumericUpDown2.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            AddSaleIdnumericUpDown2.Name = "AddSaleIdnumericUpDown2";
            AddSaleIdnumericUpDown2.Size = new Size(150, 27);
            AddSaleIdnumericUpDown2.TabIndex = 7;
            AddSaleIdnumericUpDown2.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 103);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 2;
            label7.Text = "מחיר מבצע";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(172, 62);
            label8.Name = "label8";
            label8.Size = new Size(233, 20);
            label8.TabIndex = 1;
            label8.Text = "כמות מינימלית להשתתפות במבצע";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(296, 26);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 0;
            label9.Text = "קוד מבצע";
            // 
            // SaleFilterbutton1
            // 
            SaleFilterbutton1.Location = new Point(653, 361);
            SaleFilterbutton1.Name = "SaleFilterbutton1";
            SaleFilterbutton1.Size = new Size(158, 29);
            SaleFilterbutton1.TabIndex = 30;
            SaleFilterbutton1.Text = "סנן לפי חברי מועדון";
            SaleFilterbutton1.UseVisualStyleBackColor = true;
            SaleFilterbutton1.Click += button1_Click;
            // 
            // SaleFiltercheckBox1
            // 
            SaleFiltercheckBox1.AutoSize = true;
            SaleFiltercheckBox1.Location = new Point(612, 368);
            SaleFiltercheckBox1.Name = "SaleFiltercheckBox1";
            SaleFiltercheckBox1.Size = new Size(18, 17);
            SaleFiltercheckBox1.TabIndex = 31;
            SaleFiltercheckBox1.UseVisualStyleBackColor = true;
            // 
            // SalePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(841, 555);
            Controls.Add(UpdateSalepanel);
            Controls.Add(SaleFiltercheckBox1);
            Controls.Add(SaleFilterbutton1);
            Controls.Add(AddSalepanel1);
            Controls.Add(returnBtn4);
            Controls.Add(SaleDeleteBtn);
            Controls.Add(SaleUpdateBtn);
            Controls.Add(SaleAddedBtn);
            Controls.Add(SaleShowAllBtn);
            Controls.Add(SaleShowBtn);
            Controls.Add(SaledataGridView);
            Name = "SalePage";
            Text = "Sale";
            ((System.ComponentModel.ISupportInitialize)SaledataGridView).EndInit();
            UpdateSalepanel.ResumeLayout(false);
            UpdateSalepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateSalePricetrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpdateSaleMinAmountnumericUpDown).EndInit();
            AddSalepanel1.ResumeLayout(false);
            AddSalepanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddSalePricetrackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddSaleMinAmountnumericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddSaleIdnumericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SaleDeleteBtn;
        private Button SaleUpdateBtn;
        private Button SaleAddedBtn;
        private Button SaleShowAllBtn;
        private Button SaleShowBtn;
        private DataGridView SaledataGridView;
        private Button returnBtn4;
        private Panel UpdateSalepanel;
        private Button UpdateProductbutton;
        private TrackBar UpdateSalePricetrackBar;
        private NumericUpDown UpdateSaleMinAmountnumericUpDown;
        private Label label10;
        private Label label11;
        private Label label12;
        private CheckBox UpdateSaleIsClubMembercheckBox1;
        private Label label3;
        private Label label2;
        private DateTimePicker UpdateSaleStartdatedateTimePicker1;
        private DateTimePicker UpdateSaleEnddatedateTimePicker2;
        private Panel AddSalepanel1;
        private DateTimePicker AddSaleEnddateTimePicker3;
        private DateTimePicker AddSaleStartdateTimePicker4;
        private Label label4;
        private Label label5;
        private CheckBox AddSaleIsClubMembercheckBox2;
        private Button AddSalebutton1;
        private Label label6;
        private TrackBar AddSalePricetrackBar1;
        private NumericUpDown AddSaleMinAmountnumericUpDown1;
        private NumericUpDown AddSaleIdnumericUpDown2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label UpdateSalePricelabel;
        private Button SaleFilterbutton1;
        private CheckBox SaleFiltercheckBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn MinAmount;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn IsClubMember;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private Label AddSalePricelabel1;
        private Label labelProductId;
        private NumericUpDown numericUpDownProductId;
        private Label SaleIdlabel1;
    }
}