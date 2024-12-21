namespace MiniUnISystem
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            adminRB = new RadioButton();
            studentRB = new RadioButton();
            teacherRB = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            idTB = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(teacherRB);
            groupBox1.Controls.Add(studentRB);
            groupBox1.Controls.Add(adminRB);
            groupBox1.Location = new Point(36, 134);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 165);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login as";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(idTB);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(327, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 165);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login";
            // 
            // adminRB
            // 
            adminRB.AutoSize = true;
            adminRB.Location = new Point(19, 42);
            adminRB.Name = "adminRB";
            adminRB.Size = new Size(90, 29);
            adminRB.TabIndex = 0;
            adminRB.TabStop = true;
            adminRB.Text = "Admin";
            adminRB.UseVisualStyleBackColor = true;
            // 
            // studentRB
            // 
            studentRB.AutoSize = true;
            studentRB.Location = new Point(20, 112);
            studentRB.Name = "studentRB";
            studentRB.Size = new Size(98, 29);
            studentRB.TabIndex = 2;
            studentRB.TabStop = true;
            studentRB.Text = "Student";
            studentRB.UseVisualStyleBackColor = true;
            // 
            // teacherRB
            // 
            teacherRB.AutoSize = true;
            teacherRB.Location = new Point(19, 77);
            teacherRB.Name = "teacherRB";
            teacherRB.Size = new Size(95, 29);
            teacherRB.TabIndex = 3;
            teacherRB.TabStop = true;
            teacherRB.Text = "Teacher";
            teacherRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 57);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 115);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // idTB
            // 
            idTB.Location = new Point(107, 54);
            idTB.Name = "idTB";
            idTB.Size = new Size(255, 31);
            idTB.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(107, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 55);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(327, 368);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton teacherRB;
        private RadioButton studentRB;
        private RadioButton adminRB;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox idTB;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button1;
    }
}
