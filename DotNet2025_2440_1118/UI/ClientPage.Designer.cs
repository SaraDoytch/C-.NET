namespace UI
{
    partial class ClientPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientPage));
            ClientTextBox = new TextBox();
            ClientDeleteBtn = new Button();
            ClientUpdateBtn = new Button();
            ClientAddedBtn = new Button();
            ClientShowAllBtn = new Button();
            ClientShowBtn = new Button();
            ClientDataGridView = new DataGridView();
            returnBtn3 = new Button();
            toolTip1 = new ToolTip(components);
            button3 = new Button();
            UpdateClientpanel1 = new Panel();
            ClientIdlabel1 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            textBox4 = new TextBox();
            AddClientpanel1 = new Panel();
            label5 = new Label();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            button4 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ClientDataGridView).BeginInit();
            UpdateClientpanel1.SuspendLayout();
            AddClientpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // ClientTextBox
            // 
            ClientTextBox.Location = new Point(471, 361);
            ClientTextBox.Name = "ClientTextBox";
            ClientTextBox.Size = new Size(125, 27);
            ClientTextBox.TabIndex = 15;
            // 
            // ClientDeleteBtn
            // 
            ClientDeleteBtn.Location = new Point(649, 293);
            ClientDeleteBtn.Name = "ClientDeleteBtn";
            ClientDeleteBtn.Size = new Size(94, 29);
            ClientDeleteBtn.TabIndex = 13;
            ClientDeleteBtn.Text = "מחק לקוח";
            ClientDeleteBtn.UseVisualStyleBackColor = true;
            ClientDeleteBtn.Click += ClientDeleteBtn_Click;
            // 
            // ClientUpdateBtn
            // 
            ClientUpdateBtn.Location = new Point(649, 237);
            ClientUpdateBtn.Name = "ClientUpdateBtn";
            ClientUpdateBtn.Size = new Size(94, 29);
            ClientUpdateBtn.TabIndex = 12;
            ClientUpdateBtn.Text = "עדכן לקוח";
            ClientUpdateBtn.UseVisualStyleBackColor = true;
            ClientUpdateBtn.Click += ClientUpdateBtn_Click;
            // 
            // ClientAddedBtn
            // 
            ClientAddedBtn.Location = new Point(649, 184);
            ClientAddedBtn.Name = "ClientAddedBtn";
            ClientAddedBtn.Size = new Size(94, 29);
            ClientAddedBtn.TabIndex = 11;
            ClientAddedBtn.Text = "הוסף לקוח";
            ClientAddedBtn.UseVisualStyleBackColor = true;
            ClientAddedBtn.Click += ClientAddedBtn_Click;
            // 
            // ClientShowAllBtn
            // 
            ClientShowAllBtn.Location = new Point(570, 133);
            ClientShowAllBtn.Name = "ClientShowAllBtn";
            ClientShowAllBtn.Size = new Size(173, 29);
            ClientShowAllBtn.TabIndex = 10;
            ClientShowAllBtn.Text = "הצג את כל הלקוחות";
            ClientShowAllBtn.UseVisualStyleBackColor = true;
            ClientShowAllBtn.Click += ClientShowAllBtn_Click;
            // 
            // ClientShowBtn
            // 
            ClientShowBtn.Location = new Point(649, 85);
            ClientShowBtn.Name = "ClientShowBtn";
            ClientShowBtn.Size = new Size(94, 29);
            ClientShowBtn.TabIndex = 9;
            ClientShowBtn.Text = "הצג לקוח";
            ClientShowBtn.UseVisualStyleBackColor = true;
            ClientShowBtn.Click += button1_Click;
            // 
            // ClientDataGridView
            // 
            ClientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientDataGridView.Location = new Point(11, 85);
            ClientDataGridView.Name = "ClientDataGridView";
            ClientDataGridView.ReadOnly = true;
            ClientDataGridView.RowHeadersWidth = 51;
            ClientDataGridView.Size = new Size(523, 188);
            ClientDataGridView.TabIndex = 8;
            // 
            // returnBtn3
            // 
            returnBtn3.Location = new Point(57, 384);
            returnBtn3.Name = "returnBtn3";
            returnBtn3.Size = new Size(94, 29);
            returnBtn3.TabIndex = 17;
            returnBtn3.Text = "חזור";
            returnBtn3.UseVisualStyleBackColor = true;
            returnBtn3.Click += returnBtn3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(619, 359);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 19;
            button3.Text = "סנן לפי שם";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UpdateClientpanel1
            // 
            UpdateClientpanel1.Controls.Add(ClientIdlabel1);
            UpdateClientpanel1.Controls.Add(label6);
            UpdateClientpanel1.Controls.Add(textBox3);
            UpdateClientpanel1.Controls.Add(maskedTextBox2);
            UpdateClientpanel1.Controls.Add(label7);
            UpdateClientpanel1.Controls.Add(label8);
            UpdateClientpanel1.Controls.Add(button1);
            UpdateClientpanel1.Controls.Add(label9);
            UpdateClientpanel1.Controls.Add(textBox4);
            UpdateClientpanel1.Location = new Point(87, 60);
            UpdateClientpanel1.Name = "UpdateClientpanel1";
            UpdateClientpanel1.Size = new Size(363, 235);
            UpdateClientpanel1.TabIndex = 22;
            UpdateClientpanel1.Visible = false;
            // 
            // ClientIdlabel1
            // 
            ClientIdlabel1.AutoSize = true;
            ClientIdlabel1.Location = new Point(185, 42);
            ClientIdlabel1.Name = "ClientIdlabel1";
            ClientIdlabel1.Size = new Size(0, 20);
            ClientIdlabel1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 155);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 8;
            label6.Text = "טלפון";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(98, 152);
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 123);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 5;
            label7.Text = "כתובת";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(259, 79);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 4;
            label8.Text = "שם לקוח";
            // 
            // button1
            // 
            button1.Location = new Point(55, 189);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "עדכן";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(259, 41);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 1;
            label9.Text = "קוד לקוח";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 0;
            // 
            // AddClientpanel1
            // 
            AddClientpanel1.Controls.Add(label5);
            AddClientpanel1.Controls.Add(textBox2);
            AddClientpanel1.Controls.Add(maskedTextBox1);
            AddClientpanel1.Controls.Add(label4);
            AddClientpanel1.Controls.Add(label3);
            AddClientpanel1.Controls.Add(numericUpDown1);
            AddClientpanel1.Controls.Add(button4);
            AddClientpanel1.Controls.Add(label2);
            AddClientpanel1.Controls.Add(textBox1);
            AddClientpanel1.Location = new Point(90, 63);
            AddClientpanel1.Name = "AddClientpanel1";
            AddClientpanel1.Size = new Size(363, 235);
            AddClientpanel1.TabIndex = 21;
            AddClientpanel1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(282, 155);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 8;
            label5.Text = "טלפון";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(98, 152);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 123);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 5;
            label4.Text = "כתובת";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 79);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "שם לקוח";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(85, 31);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // button4
            // 
            button4.Location = new Point(55, 189);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "הוסף";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 33);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "ת''ז לקוח";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // ClientPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(811, 483);
            Controls.Add(UpdateClientpanel1);
            Controls.Add(AddClientpanel1);
            Controls.Add(button3);
            Controls.Add(returnBtn3);
            Controls.Add(ClientTextBox);
            Controls.Add(ClientDeleteBtn);
            Controls.Add(ClientUpdateBtn);
            Controls.Add(ClientAddedBtn);
            Controls.Add(ClientShowAllBtn);
            Controls.Add(ClientDataGridView);
            Controls.Add(ClientShowBtn);
            Name = "ClientPage";
            Text = "Client";
            ((System.ComponentModel.ISupportInitialize)ClientDataGridView).EndInit();
            UpdateClientpanel1.ResumeLayout(false);
            UpdateClientpanel1.PerformLayout();
            AddClientpanel1.ResumeLayout(false);
            AddClientpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ClientTextBox;
        private Button ClientDeleteBtn;
        private Button ClientUpdateBtn;
        private Button ClientAddedBtn;
        private Button ClientShowAllBtn;
        private Button ClientShowBtn;
        private DataGridView ClientDataGridView;
        private Button returnBtn3;
        private ToolTip toolTip1;
        private Button button3;
        private Panel UpdateClientpanel1;
        private Label label6;
        private TextBox textBox3;
        private MaskedTextBox maskedTextBox2;
        private Label label7;
        private Label label8;
        private Button button1;
        private Label label9;
        private TextBox textBox4;
        private Panel AddClientpanel1;
        private Label label5;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button4;
        private Label label2;
        private TextBox textBox1;
        private Label ClientIdlabel1;
    }
}