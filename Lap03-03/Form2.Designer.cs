﻿namespace Lap03_03
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 42);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 0;
            label1.Text = "MSSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 133);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 1;
            label2.Text = "Họ và Tên Sinh Vien";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(77, 210);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 2;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(77, 301);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 3;
            label4.Text = "Điểm TB";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(318, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(318, 137);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(462, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(318, 305);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Công Nghệ Thông Tin", "Ngôn Ngữ Anh", "Quản Trị Kinh Doanh" });
            comboBox1.Location = new Point(318, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(462, 28);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Location = new Point(461, 363);
            button1.Name = "button1";
            button1.Size = new Size(169, 40);
            button1.TabIndex = 8;
            button1.Text = "Thêm Mới";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.Location = new Point(653, 363);
            button2.Name = "button2";
            button2.Size = new Size(113, 40);
            button2.TabIndex = 9;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}