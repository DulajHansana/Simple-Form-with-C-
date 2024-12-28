namespace Student_Management_System
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 21);
            label1.TabIndex = 0;
            label1.Text = "Student Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "Student Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 211);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Course";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(121, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(121, 104);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(309, 23);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(370, 257);
            button1.Name = "button1";
            button1.Size = new Size(60, 23);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(144, 257);
            button2.Name = "button2";
            button2.Size = new Size(60, 23);
            button2.TabIndex = 10;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(295, 257);
            button3.Name = "button3";
            button3.Size = new Size(60, 23);
            button3.TabIndex = 11;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ForeColor = Color.Green;
            button4.Location = new Point(219, 257);
            button4.Name = "button4";
            button4.Size = new Size(60, 23);
            button4.TabIndex = 12;
            button4.Text = "Show";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(121, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(309, 150);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}
