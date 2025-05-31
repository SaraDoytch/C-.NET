namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            EmployeeBtn = new Button();
            ManagerBtn = new Button();
            SuspendLayout();
            // 
            // EmployeeBtn
            // 
            EmployeeBtn.Location = new Point(512, 249);
            EmployeeBtn.Name = "EmployeeBtn";
            EmployeeBtn.Size = new Size(136, 84);
            EmployeeBtn.TabIndex = 0;
            EmployeeBtn.Text = "קופאי";
            EmployeeBtn.UseVisualStyleBackColor = true;
            EmployeeBtn.Click += EmployeeBtn_Click;
            // 
            // ManagerBtn
            // 
            ManagerBtn.Location = new Point(512, 136);
            ManagerBtn.Name = "ManagerBtn";
            ManagerBtn.Size = new Size(136, 84);
            ManagerBtn.TabIndex = 1;
            ManagerBtn.Text = "מנהל";
            ManagerBtn.UseVisualStyleBackColor = true;
            ManagerBtn.Click += ManagerBtn_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(829, 571);
            Controls.Add(ManagerBtn);
            Controls.Add(EmployeeBtn);
            ForeColor = Color.Coral;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button EmployeeBtn;
        private Button ManagerBtn;
    }
}
