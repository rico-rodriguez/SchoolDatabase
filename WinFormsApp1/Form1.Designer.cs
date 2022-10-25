namespace WinFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTeacherFirstName = new System.Windows.Forms.TextBox();
            this.txtTeacherLastName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.dtStudentDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.numTeacherId = new System.Windows.Forms.NumericUpDown();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.numTeacherAge = new System.Windows.Forms.NumericUpDown();
            this.btnLoadTeachers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Student Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date of Birth:";
            // 
            // txtTeacherFirstName
            // 
            this.txtTeacherFirstName.Location = new System.Drawing.Point(107, 64);
            this.txtTeacherFirstName.Name = "txtTeacherFirstName";
            this.txtTeacherFirstName.Size = new System.Drawing.Size(200, 23);
            this.txtTeacherFirstName.TabIndex = 8;
            // 
            // txtTeacherLastName
            // 
            this.txtTeacherLastName.Location = new System.Drawing.Point(107, 103);
            this.txtTeacherLastName.Name = "txtTeacherLastName";
            this.txtTeacherLastName.Size = new System.Drawing.Size(200, 23);
            this.txtTeacherLastName.TabIndex = 9;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(416, 23);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(200, 23);
            this.txtStudentId.TabIndex = 10;
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(416, 52);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(200, 23);
            this.txtStudentFirstName.TabIndex = 11;
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Location = new System.Drawing.Point(416, 84);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(200, 23);
            this.txtStudentLastName.TabIndex = 12;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(107, 177);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(200, 23);
            this.btnAddTeacher.TabIndex = 14;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(416, 177);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(200, 23);
            this.btnAddStudent.TabIndex = 15;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // dtStudentDateOfBirth
            // 
            this.dtStudentDateOfBirth.Location = new System.Drawing.Point(416, 117);
            this.dtStudentDateOfBirth.Name = "dtStudentDateOfBirth";
            this.dtStudentDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dtStudentDateOfBirth.TabIndex = 16;
            // 
            // numTeacherId
            // 
            this.numTeacherId.Location = new System.Drawing.Point(107, 30);
            this.numTeacherId.Maximum = new decimal(new int[] {
            -4836480,
            4,
            0,
            0});
            this.numTeacherId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTeacherId.Name = "numTeacherId";
            this.numTeacherId.Size = new System.Drawing.Size(200, 23);
            this.numTeacherId.TabIndex = 17;
            this.numTeacherId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(156, 238);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.Size = new System.Drawing.Size(344, 177);
            this.dgvResults.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Age:";
            // 
            // numTeacherAge
            // 
            this.numTeacherAge.Location = new System.Drawing.Point(107, 140);
            this.numTeacherAge.Maximum = new decimal(new int[] {
            -4836480,
            4,
            0,
            0});
            this.numTeacherAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTeacherAge.Name = "numTeacherAge";
            this.numTeacherAge.Size = new System.Drawing.Size(200, 23);
            this.numTeacherAge.TabIndex = 20;
            this.numTeacherAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLoadTeachers
            // 
            this.btnLoadTeachers.Location = new System.Drawing.Point(107, 206);
            this.btnLoadTeachers.Name = "btnLoadTeachers";
            this.btnLoadTeachers.Size = new System.Drawing.Size(200, 23);
            this.btnLoadTeachers.TabIndex = 21;
            this.btnLoadTeachers.Text = "Load Teachers";
            this.btnLoadTeachers.UseVisualStyleBackColor = true;
            this.btnLoadTeachers.Click += new System.EventHandler(this.btnLoadTeachers_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 445);
            this.Controls.Add(this.btnLoadTeachers);
            this.Controls.Add(this.numTeacherAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.numTeacherId);
            this.Controls.Add(this.dtStudentDateOfBirth);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.txtStudentLastName);
            this.Controls.Add(this.txtStudentFirstName);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtTeacherLastName);
            this.Controls.Add(this.txtTeacherFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTeacherFirstName;
        private TextBox txtTeacherLastName;
        private TextBox txtStudentId;
        private TextBox txtStudentFirstName;
        private TextBox txtStudentLastName;
        private Button btnAddTeacher;
        private Button btnAddStudent;
        private DateTimePicker dtStudentDateOfBirth;
        private NumericUpDown numTeacherId;
        private DataGridView dgvResults;
        private Label label8;
        private NumericUpDown numTeacherAge;
        private Button btnLoadTeachers;
    }
}