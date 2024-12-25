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
            AccountsGroupBox = new GroupBox();
            specTB = new TextBox();
            collegeTB = new TextBox();
            passTB = new TextBox();
            emailTB = new TextBox();
            nameTB = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            studentRB = new RadioButton();
            teacherRB = new RadioButton();
            courseGroupBox = new GroupBox();
            updateRB = new RadioButton();
            createRB = new RadioButton();
            createAccRB = new Button();
            groupBox2 = new GroupBox();
            accountsRB = new RadioButton();
            AssignRB = new RadioButton();
            coursesRB = new RadioButton();
            resultRB = new RadioButton();
            examRB = new RadioButton();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            deleteRB = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            AssignGroupBox = new GroupBox();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            AccountsGroupBox.SuspendLayout();
            courseGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            AssignGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AccountsGroupBox
            // 
            AccountsGroupBox.Controls.Add(createAccRB);
            AccountsGroupBox.Controls.Add(specTB);
            AccountsGroupBox.Controls.Add(collegeTB);
            AccountsGroupBox.Controls.Add(passTB);
            AccountsGroupBox.Controls.Add(emailTB);
            AccountsGroupBox.Controls.Add(nameTB);
            AccountsGroupBox.Controls.Add(label5);
            AccountsGroupBox.Controls.Add(label4);
            AccountsGroupBox.Controls.Add(label3);
            AccountsGroupBox.Controls.Add(label2);
            AccountsGroupBox.Controls.Add(label1);
            AccountsGroupBox.Controls.Add(studentRB);
            AccountsGroupBox.Controls.Add(teacherRB);
            AccountsGroupBox.Font = new Font("Sylfaen", 9F);
            AccountsGroupBox.Location = new Point(33, 141);
            AccountsGroupBox.Name = "AccountsGroupBox";
            AccountsGroupBox.Size = new Size(510, 351);
            AccountsGroupBox.TabIndex = 0;
            AccountsGroupBox.TabStop = false;
            AccountsGroupBox.Text = "Create Accounts";
            // 
            // specTB
            // 
            specTB.Location = new Point(289, 246);
            specTB.Name = "specTB";
            specTB.Size = new Size(200, 31);
            specTB.TabIndex = 11;
            // 
            // collegeTB
            // 
            collegeTB.Location = new Point(289, 192);
            collegeTB.Name = "collegeTB";
            collegeTB.Size = new Size(200, 31);
            collegeTB.TabIndex = 10;
            // 
            // passTB
            // 
            passTB.Location = new Point(289, 148);
            passTB.Name = "passTB";
            passTB.Size = new Size(200, 31);
            passTB.TabIndex = 9;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(289, 102);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(200, 31);
            emailTB.TabIndex = 8;
            // 
            // nameTB
            // 
            nameTB.Location = new Point(289, 54);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(200, 31);
            nameTB.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 9F);
            label5.Location = new Point(176, 246);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 6;
            label5.Text = "Speciality";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 9F);
            label4.Location = new Point(176, 198);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 5;
            label4.Text = "College";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 9F);
            label3.Location = new Point(176, 148);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 9F);
            label2.Location = new Point(176, 102);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 9F);
            label1.Location = new Point(176, 54);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 2;
            label1.Text = "Name";
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
            teacherRB.CheckedChanged += teacherRB_CheckedChanged;
            // 
            // courseGroupBox
            // 
            courseGroupBox.Controls.Add(textBox1);
            courseGroupBox.Controls.Add(deleteRB);
            courseGroupBox.Controls.Add(textBox2);
            courseGroupBox.Controls.Add(updateRB);
            courseGroupBox.Controls.Add(textBox3);
            courseGroupBox.Controls.Add(createRB);
            courseGroupBox.Controls.Add(label7);
            courseGroupBox.Controls.Add(label9);
            courseGroupBox.Controls.Add(label8);
            courseGroupBox.Font = new Font("Sylfaen", 9F);
            courseGroupBox.Location = new Point(33, 543);
            courseGroupBox.Name = "courseGroupBox";
            courseGroupBox.Size = new Size(510, 339);
            courseGroupBox.TabIndex = 1;
            courseGroupBox.TabStop = false;
            courseGroupBox.Text = "Courses";
            // 
            // updateRB
            // 
            updateRB.AutoSize = true;
            updateRB.Location = new Point(21, 89);
            updateRB.Name = "updateRB";
            updateRB.Size = new Size(88, 27);
            updateRB.TabIndex = 1;
            updateRB.TabStop = true;
            updateRB.Text = "Update";
            updateRB.UseVisualStyleBackColor = true;
            // 
            // createRB
            // 
            createRB.AutoSize = true;
            createRB.Location = new Point(21, 54);
            createRB.Name = "createRB";
            createRB.Size = new Size(84, 27);
            createRB.TabIndex = 0;
            createRB.TabStop = true;
            createRB.Text = "Create";
            createRB.UseVisualStyleBackColor = true;
            // 
            // createAccRB
            // 
            createAccRB.Location = new Point(377, 302);
            createAccRB.Name = "createAccRB";
            createAccRB.Size = new Size(112, 34);
            createAccRB.TabIndex = 12;
            createAccRB.Text = "Create";
            createAccRB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(resultRB);
            groupBox2.Controls.Add(examRB);
            groupBox2.Controls.Add(coursesRB);
            groupBox2.Controls.Add(AssignRB);
            groupBox2.Controls.Add(accountsRB);
            groupBox2.Location = new Point(33, 32);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(510, 90);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "What do you want to do:";
            // 
            // accountsRB
            // 
            accountsRB.AutoSize = true;
            accountsRB.Location = new Point(6, 30);
            accountsRB.Name = "accountsRB";
            accountsRB.Size = new Size(110, 29);
            accountsRB.TabIndex = 0;
            accountsRB.TabStop = true;
            accountsRB.Text = "Accounts";
            accountsRB.UseVisualStyleBackColor = true;
            accountsRB.CheckedChanged += accountsRB_CheckedChanged;
            // 
            // AssignRB
            // 
            AssignRB.AutoSize = true;
            AssignRB.Location = new Point(222, 30);
            AssignRB.Name = "AssignRB";
            AssignRB.Size = new Size(90, 29);
            AssignRB.TabIndex = 1;
            AssignRB.TabStop = true;
            AssignRB.Text = "Assign";
            AssignRB.UseVisualStyleBackColor = true;
            // 
            // coursesRB
            // 
            coursesRB.AutoSize = true;
            coursesRB.Location = new Point(122, 30);
            coursesRB.Name = "coursesRB";
            coursesRB.Size = new Size(100, 29);
            coursesRB.TabIndex = 2;
            coursesRB.TabStop = true;
            coursesRB.Text = "Courses";
            coursesRB.UseVisualStyleBackColor = true;
            // 
            // resultRB
            // 
            resultRB.AutoSize = true;
            resultRB.Location = new Point(412, 30);
            resultRB.Name = "resultRB";
            resultRB.Size = new Size(92, 29);
            resultRB.TabIndex = 4;
            resultRB.TabStop = true;
            resultRB.Text = "Results";
            resultRB.UseVisualStyleBackColor = true;
            // 
            // examRB
            // 
            examRB.AutoSize = true;
            examRB.Location = new Point(318, 30);
            examRB.Name = "examRB";
            examRB.Size = new Size(87, 29);
            examRB.TabIndex = 3;
            examRB.TabStop = true;
            examRB.Text = "Exams";
            examRB.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(578, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(433, 435);
            dataGridView1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(582, 26);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // deleteRB
            // 
            deleteRB.AutoSize = true;
            deleteRB.Location = new Point(21, 124);
            deleteRB.Name = "deleteRB";
            deleteRB.Size = new Size(82, 27);
            deleteRB.TabIndex = 2;
            deleteRB.TabStop = true;
            deleteRB.Text = "Delete";
            deleteRB.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 152);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 126);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 31);
            textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(282, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 31);
            textBox3.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sylfaen", 9F);
            label7.Location = new Point(169, 152);
            label7.Name = "label7";
            label7.Size = new Size(94, 23);
            label7.TabIndex = 15;
            label7.Text = "Description";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sylfaen", 9F);
            label8.Location = new Point(169, 106);
            label8.Name = "label8";
            label8.Size = new Size(49, 23);
            label8.TabIndex = 14;
            label8.Text = "Level";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sylfaen", 9F);
            label9.Location = new Point(169, 58);
            label9.Name = "label9";
            label9.Size = new Size(53, 23);
            label9.TabIndex = 13;
            label9.Text = "Name";
            // 
            // AssignGroupBox
            // 
            AssignGroupBox.Controls.Add(button1);
            AssignGroupBox.Controls.Add(textBox4);
            AssignGroupBox.Controls.Add(textBox5);
            AssignGroupBox.Controls.Add(textBox6);
            AssignGroupBox.Controls.Add(textBox7);
            AssignGroupBox.Controls.Add(textBox8);
            AssignGroupBox.Controls.Add(label10);
            AssignGroupBox.Controls.Add(label11);
            AssignGroupBox.Controls.Add(label12);
            AssignGroupBox.Controls.Add(label13);
            AssignGroupBox.Controls.Add(label14);
            AssignGroupBox.Controls.Add(radioButton1);
            AssignGroupBox.Controls.Add(radioButton2);
            AssignGroupBox.Font = new Font("Sylfaen", 9F);
            AssignGroupBox.Location = new Point(549, 554);
            AssignGroupBox.Name = "AssignGroupBox";
            AssignGroupBox.Size = new Size(510, 351);
            AssignGroupBox.TabIndex = 13;
            AssignGroupBox.TabStop = false;
            AssignGroupBox.Text = "Create Accounts";
            // 
            // button1
            // 
            button1.Location = new Point(377, 302);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(289, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 31);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(289, 192);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 31);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(289, 148);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 31);
            textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(289, 102);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(200, 31);
            textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(289, 54);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(200, 31);
            textBox8.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sylfaen", 9F);
            label10.Location = new Point(176, 246);
            label10.Name = "label10";
            label10.Size = new Size(79, 23);
            label10.TabIndex = 6;
            label10.Text = "Speciality";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sylfaen", 9F);
            label11.Location = new Point(176, 198);
            label11.Name = "label11";
            label11.Size = new Size(64, 23);
            label11.TabIndex = 5;
            label11.Text = "College";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sylfaen", 9F);
            label12.Location = new Point(176, 148);
            label12.Name = "label12";
            label12.Size = new Size(82, 23);
            label12.TabIndex = 4;
            label12.Text = "Password";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sylfaen", 9F);
            label13.Location = new Point(176, 102);
            label13.Name = "label13";
            label13.Size = new Size(51, 23);
            label13.TabIndex = 3;
            label13.Text = "Email";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Sylfaen", 9F);
            label14.Location = new Point(176, 54);
            label14.Name = "label14";
            label14.Size = new Size(53, 23);
            label14.TabIndex = 2;
            label14.Text = "Name";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 94);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 27);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Student";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(21, 44);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 27);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Teacher";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 1050);
            Controls.Add(AssignGroupBox);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(courseGroupBox);
            Controls.Add(AccountsGroupBox);
            Name = "AdminForm";
            Text = "Admin";
            AccountsGroupBox.ResumeLayout(false);
            AccountsGroupBox.PerformLayout();
            courseGroupBox.ResumeLayout(false);
            courseGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            AssignGroupBox.ResumeLayout(false);
            AssignGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox AccountsGroupBox;
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
        private RadioButton updateRB;
        private RadioButton createRB;
        private Button createAccRB;
        private GroupBox groupBox2;
        private RadioButton radioButton6;
        private RadioButton resultRB;
        private RadioButton examRB;
        private RadioButton coursesRB;
        private RadioButton AssignRB;
        private RadioButton accountsRB;
        private DataGridView dataGridView1;
        private Label label6;
        private RadioButton deleteRB;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
        private Label label9;
        private Label label8;
        private GroupBox AssignGroupBox;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}