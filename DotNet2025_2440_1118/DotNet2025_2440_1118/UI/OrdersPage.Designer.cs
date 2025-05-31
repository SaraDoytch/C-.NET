namespace UI
{
    partial class OrdersPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersPage));
            OrderAddProductbutton1 = new Button();
            button2 = new Button();
            button3 = new Button();
            CartlistBox = new ListBox();
            countForOrder = new Label();
            countForOrderUpDown = new NumericUpDown();
            productOrder = new Label();
            button5 = new Button();
            OrderProductIdcomboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)countForOrderUpDown).BeginInit();
            SuspendLayout();
            // 
            // OrderAddProductbutton1
            // 
            OrderAddProductbutton1.Location = new Point(513, 167);
            OrderAddProductbutton1.Name = "OrderAddProductbutton1";
            OrderAddProductbutton1.Size = new Size(94, 29);
            OrderAddProductbutton1.TabIndex = 1;
            OrderAddProductbutton1.Text = "הוסף מוצר";
            OrderAddProductbutton1.UseVisualStyleBackColor = true;
            OrderAddProductbutton1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(261, 364);
            button2.Name = "button2";
            button2.Size = new Size(142, 29);
            button2.TabIndex = 2;
            button2.Text = "צפיה בהזמנה";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(547, 364);
            button3.Name = "button3";
            button3.Size = new Size(143, 29);
            button3.TabIndex = 3;
            button3.Text = "ביצוע בזמנה";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CartlistBox
            // 
            CartlistBox.FormattingEnabled = true;
            CartlistBox.Location = new Point(23, 52);
            CartlistBox.Name = "CartlistBox";
            CartlistBox.Size = new Size(172, 264);
            CartlistBox.TabIndex = 21;
            // 
            // countForOrder
            // 
            countForOrder.AutoSize = true;
            countForOrder.Location = new Point(686, 103);
            countForOrder.Name = "countForOrder";
            countForOrder.Size = new Size(95, 20);
            countForOrder.TabIndex = 26;
            countForOrder.Text = "כמות להזמנה";
            // 
            // countForOrderUpDown
            // 
            countForOrderUpDown.Location = new Point(513, 99);
            countForOrderUpDown.Name = "countForOrderUpDown";
            countForOrderUpDown.Size = new Size(157, 27);
            countForOrderUpDown.TabIndex = 25;
            countForOrderUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            countForOrderUpDown.ValueChanged += countForOrderUpDown_ValueChanged;
            // 
            // productOrder
            // 
            productOrder.AutoSize = true;
            productOrder.Location = new Point(706, 52);
            productOrder.Name = "productOrder";
            productOrder.Size = new Size(65, 20);
            productOrder.TabIndex = 23;
            productOrder.Text = "קוד מוצר";
            // 
            // button5
            // 
            button5.Location = new Point(86, 375);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 27;
            button5.Text = "חזור";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // OrderProductIdcomboBox1
            // 
            OrderProductIdcomboBox1.FormattingEnabled = true;
            OrderProductIdcomboBox1.Location = new Point(513, 44);
            OrderProductIdcomboBox1.Name = "OrderProductIdcomboBox1";
            OrderProductIdcomboBox1.Size = new Size(151, 28);
            OrderProductIdcomboBox1.TabIndex = 28;
            // 
            // OrdersPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 487);
            Controls.Add(OrderProductIdcomboBox1);
            Controls.Add(button5);
            Controls.Add(countForOrder);
            Controls.Add(countForOrderUpDown);
            Controls.Add(productOrder);
            Controls.Add(CartlistBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(OrderAddProductbutton1);
            Name = "OrdersPage";
            Text = "Orders";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)countForOrderUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button OrderAddProductbutton1;
        private Button button2;
        private Button button3;
        private ListBox CartlistBox;
        private Label countForOrder;
        private NumericUpDown countForOrderUpDown;
        private Label productOrder;
        private Button button5;
        private ComboBox OrderProductIdcomboBox1;
    }
}