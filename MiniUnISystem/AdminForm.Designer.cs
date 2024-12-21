namespace MiniUnISystem
{
    partial class AdminForm
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
            groupBox1 = new GroupBox();
            teacherRB = new RadioButton();
            studentRB = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nameTB = new TextBox();
            emailTB = new TextBox();
            passTB = new TextBox();
            collegeTB = new TextBox();
            specTB = new TextBox();
            courseGroupBox = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1.SuspendLayout();
            courseGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(specTB);
            groupBox1.Controls.Add(collegeTB);
            groupBox1.Controls.Add(passTB);
            groupBox1.Controls.Add(emailTB);
            groupBox1.Controls.Add(nameTB);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(studentRB);
            groupBox1.Controls.Add(teacherRB);
            groupBox1.Font = new Font("Sylfaen", 9F);
            groupBox1.Location = new Point(150, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 288);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Creat Accounts";
            // 
            // teacherRB
            // 
            teacherRB.AutoSize = true;
            teacherRB.Location = new Point(21, 44);
            teacherRB.Name = "teacherRB";
            teacherRB.Size = new Size(95, 27);
            teacherRB.TabIndex = 0;
            teacherRB.TabStop = true;
            teacherRB.Text = "Teacher";
            teacherRB.UseVisualStyleBackColor = true;
            // 
            // studentRB
            // 
            studentRB.AutoSize = true;
            studentRB.Location = new Point(21, 94);
            studentRB.Name = "studentRB";
            studentRB.Size = new Size(91, 27);
            studentRB.TabIndex = 1;
            studentRB.TabStop = true;
            studentRB.Text = "Student";
            studentRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 9F);
            label1.Location = new Point(209, 48);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 9F);
            label2.Location = new Point(209, 96);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 9F);
            label3.Location = new Point(209, 142);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 9F);
            label4.Location = new Point(209, 192);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 5;
            label4.Text = "College";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 9F);
            label5.Location = new Point(209, 240);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 6;
            label5.Text = "Speciality";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(322, 48);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(174, 31);
            nameTB.TabIndex = 7;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(322, 96);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(174, 31);
            emailTB.TabIndex = 8;
            // 
            // passTB
            // 
            passTB.Location = new Point(322, 142);
            passTB.Name = "passTB";
            passTB.Size = new Size(174, 31);
            passTB.TabIndex = 9;
            // 
            // collegeTB
            // 
            collegeTB.Location = new Point(322, 186);
            collegeTB.Name = "collegeTB";
            collegeTB.Size = new Size(174, 31);
            collegeTB.TabIndex = 10;
            // 
            // specTB
            // 
            specTB.Location = new Point(322, 240);
            specTB.Name = "specTB";
            specTB.Size = new Size(174, 31);
            specTB.TabIndex = 11;
            // 
            // courseGroupBox
            // 
            courseGroupBox.Controls.Add(radioButton2);
            courseGroupBox.Controls.Add(radioButton1);
            courseGroupBox.Location = new Point(150, 372);
            courseGroupBox.Name = "courseGroupBox";
            courseGroupBox.Size = new Size(510, 276);
            courseGroupBox.TabIndex = 1;
            courseGroupBox.TabStop = false;
            courseGroupBox.Text = "Courses";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 54);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(21, 98);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(141, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 911);
            Controls.Add(courseGroupBox);
            Controls.Add(groupBox1);
            Name = "AdminForm";
            Text = "Admin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            courseGroupBox.ResumeLayout(false);
            courseGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton studentRB;
        private RadioButton teacherRB;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox specTB;
        private TextBox collegeTB;
        private TextBox passTB;
        private TextBox emailTB;
        private TextBox nameTB;
        private GroupBox courseGroupBox;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}