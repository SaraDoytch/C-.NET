namespace UI
{
    partial class EmployeeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMenu));
            dataGridView1 = new DataGridView();
            returnBtn5 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(90, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // returnBtn5
            // 
            returnBtn5.Location = new Point(69, 377);
            returnBtn5.Name = "returnBtn5";
            returnBtn5.Size = new Size(94, 29);
            returnBtn5.TabIndex = 18;
            returnBtn5.Text = "חזור";
            returnBtn5.UseVisualStyleBackColor = true;
            returnBtn5.Click += returnBtn5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(486, 114);
            button2.Name = "button2";
            button2.Size = new Size(178, 29);
            button2.TabIndex = 19;
            button2.Text = "ביצוע הזמנה חדשה";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // EmployeeMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(786, 509);
            Controls.Add(button2);
            Controls.Add(returnBtn5);
            Controls.Add(dataGridView1);
            Name = "EmployeeMenu";
            Text = "EmployeeMenu";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button returnBtn5;
        private Button button2;
    }
}