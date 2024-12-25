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
            teacherRB = new RadioButton();
            studentRB = new RadioButton();
            adminRB = new RadioButton();
            groupBox2 = new GroupBox();
            passwordTB = new TextBox();
            emailTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            teacherRB.CheckedChanged += teacherRB_CheckedChanged;
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
            studentRB.CheckedChanged += studentRB_CheckedChanged;
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
            adminRB.CheckedChanged += adminRB_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(passwordTB);
            groupBox2.Controls.Add(emailTB);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(327, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 165);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Login";
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(107, 112);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(255, 31);
            passwordTB.TabIndex = 3;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(107, 54);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(255, 31);
            emailTB.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 57);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 0;
            label1.Text = "email";
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
        private TextBox passwordTB;
        private TextBox emailTB;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button1;
    }
}
