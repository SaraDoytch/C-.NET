namespace UI
{
    partial class ManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            SalesBtn = new Button();
            ClientsBtn = new Button();
            ProductsBtn = new Button();
            returnBtn1 = new Button();
            SuspendLayout();
            // 
            // SalesBtn
            // 
            SalesBtn.Location = new Point(186, 101);
            SalesBtn.Name = "SalesBtn";
            SalesBtn.Size = new Size(133, 78);
            SalesBtn.TabIndex = 0;
            SalesBtn.Text = "מבצעים";
            SalesBtn.UseVisualStyleBackColor = true;
            SalesBtn.Click += SalesBtn_Click;
            // 
            // ClientsBtn
            // 
            ClientsBtn.Location = new Point(345, 101);
            ClientsBtn.Name = "ClientsBtn";
            ClientsBtn.Size = new Size(133, 78);
            ClientsBtn.TabIndex = 1;
            ClientsBtn.Text = "לקוחות";
            ClientsBtn.UseVisualStyleBackColor = true;
            ClientsBtn.Click += ClientsBtn_Click;
            // 
            // ProductsBtn
            // 
            ProductsBtn.Location = new Point(495, 101);
            ProductsBtn.Name = "ProductsBtn";
            ProductsBtn.Size = new Size(133, 78);
            ProductsBtn.TabIndex = 2;
            ProductsBtn.Text = "מוצרים";
            ProductsBtn.UseVisualStyleBackColor = true;
            ProductsBtn.Click += ProductsBtn_Click;
            // 
            // returnBtn1
            // 
            returnBtn1.Location = new Point(37, 387);
            returnBtn1.Name = "returnBtn1";
            returnBtn1.Size = new Size(94, 29);
            returnBtn1.TabIndex = 18;
            returnBtn1.Text = "חזור";
            returnBtn1.UseVisualStyleBackColor = true;
            returnBtn1.Click += returnBtn1_Click;
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(returnBtn1);
            Controls.Add(ProductsBtn);
            Controls.Add(ClientsBtn);
            Controls.Add(SalesBtn);
            ForeColor = Color.FromArgb(255, 128, 0);
            Name = "ManagerMenu";
            Text = "ManagerMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button SalesBtn;
        private Button ClientsBtn;
        private Button ProductsBtn;
        private Button returnBtn1;
    }
}