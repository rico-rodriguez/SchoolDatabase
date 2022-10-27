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
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtTeacherFirstName = new System.Windows.Forms.TextBox();
            this.txtTeacherLastName = new System.Windows.Forms.TextBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.dtStudentDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.numTeacherId = new System.Windows.Forms.NumericUpDown();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblAge = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.btnLoadTeachers = new System.Windows.Forms.Button();
            this.rdoTeacher = new System.Windows.Forms.RadioButton();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabTeachersStudents = new System.Windows.Forms.TabPage();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.cboCredits = new System.Windows.Forms.ComboBox();
            this.cboInstructor = new System.Windows.Forms.ComboBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtAbbreviation = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCourseId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnShowCourses = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnAddUpdateCourse = new System.Windows.Forms.Button();
            this.btnResetCourseForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabTeachersStudents.SuspendLayout();
            this.tabCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(26, 142);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(76, 15);
            this.lblDateOfBirth.TabIndex = 6;
            this.lblDateOfBirth.Text = "Date of Birth:";
            this.lblDateOfBirth.Visible = false;
            // 
            // txtTeacherFirstName
            // 
            this.txtTeacherFirstName.Location = new System.Drawing.Point(108, 64);
            this.txtTeacherFirstName.Name = "txtTeacherFirstName";
            this.txtTeacherFirstName.Size = new System.Drawing.Size(200, 23);
            this.txtTeacherFirstName.TabIndex = 8;
            this.txtTeacherFirstName.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTeacherLastName
            // 
            this.txtTeacherLastName.Location = new System.Drawing.Point(108, 101);
            this.txtTeacherLastName.Name = "txtTeacherLastName";
            this.txtTeacherLastName.Size = new System.Drawing.Size(200, 23);
            this.txtTeacherLastName.TabIndex = 9;
            this.txtTeacherLastName.TextChanged += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(327, 64);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(127, 23);
            this.btnAddTeacher.TabIndex = 14;
            this.btnAddTeacher.Text = "Add/Update";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // dtStudentDateOfBirth
            // 
            this.dtStudentDateOfBirth.Location = new System.Drawing.Point(110, 138);
            this.dtStudentDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtStudentDateOfBirth.Name = "dtStudentDateOfBirth";
            this.dtStudentDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dtStudentDateOfBirth.TabIndex = 16;
            this.dtStudentDateOfBirth.Visible = false;
            // 
            // numTeacherId
            // 
            this.numTeacherId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numTeacherId.Cursor = System.Windows.Forms.Cursors.No;
            this.numTeacherId.Enabled = false;
            this.numTeacherId.Location = new System.Drawing.Point(108, 29);
            this.numTeacherId.Maximum = new decimal(new int[] {
            -4836480,
            4,
            0,
            0});
            this.numTeacherId.Name = "numTeacherId";
            this.numTeacherId.ReadOnly = true;
            this.numTeacherId.Size = new System.Drawing.Size(45, 23);
            this.numTeacherId.TabIndex = 17;
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(6, 201);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.Size = new System.Drawing.Size(465, 176);
            this.dgvResults.TabIndex = 18;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellClick);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(71, 142);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 15);
            this.lblAge.TabIndex = 19;
            this.lblAge.Text = "Age:";
            // 
            // numAge
            // 
            this.numAge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numAge.Location = new System.Drawing.Point(110, 138);
            this.numAge.Maximum = new decimal(new int[] {
            -4836480,
            4,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(35, 23);
            this.numAge.TabIndex = 20;
            this.numAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLoadTeachers
            // 
            this.btnLoadTeachers.Location = new System.Drawing.Point(327, 3);
            this.btnLoadTeachers.Name = "btnLoadTeachers";
            this.btnLoadTeachers.Size = new System.Drawing.Size(127, 23);
            this.btnLoadTeachers.TabIndex = 21;
            this.btnLoadTeachers.Text = "Load Teachers";
            this.btnLoadTeachers.UseVisualStyleBackColor = true;
            this.btnLoadTeachers.Click += new System.EventHandler(this.btnLoadTeachers_Click_1);
            // 
            // rdoTeacher
            // 
            this.rdoTeacher.AutoSize = true;
            this.rdoTeacher.Checked = true;
            this.rdoTeacher.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoTeacher.Location = new System.Drawing.Point(3, 9);
            this.rdoTeacher.Name = "rdoTeacher";
            this.rdoTeacher.Size = new System.Drawing.Size(64, 17);
            this.rdoTeacher.TabIndex = 22;
            this.rdoTeacher.TabStop = true;
            this.rdoTeacher.Text = "Teacher";
            this.rdoTeacher.UseVisualStyleBackColor = true;
            this.rdoTeacher.CheckedChanged += new System.EventHandler(this.rdoTeacher_CheckedChanged);
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoStudent.Location = new System.Drawing.Point(72, 9);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(66, 17);
            this.rdoStudent.TabIndex = 23;
            this.rdoStudent.Text = "Student";
            this.rdoStudent.UseVisualStyleBackColor = true;
            this.rdoStudent.CheckedChanged += new System.EventHandler(this.rdoStudent_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoStudent);
            this.panel1.Controls.Add(this.rdoTeacher);
            this.panel1.Location = new System.Drawing.Point(159, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 32);
            this.panel1.TabIndex = 24;
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadStudents.Location = new System.Drawing.Point(327, 31);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(127, 23);
            this.btnLoadStudents.TabIndex = 25;
            this.btnLoadStudents.Text = "Load Students";
            this.btnLoadStudents.UseVisualStyleBackColor = false;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(327, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(327, 136);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(127, 23);
            this.btnResetForm.TabIndex = 27;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(327, 172);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Last Name (Ascending)",
            "Last Name (Descending)",
            "First Name (Ascending)",
            "First Name (Descending)"});
            this.cbSort.Location = new System.Drawing.Point(108, 173);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(202, 23);
            this.cbSort.TabIndex = 29;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sort:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabTeachersStudents);
            this.tabControl1.Controls.Add(this.tabCourses);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 416);
            this.tabControl1.TabIndex = 31;
            // 
            // TabTeachersStudents
            // 
            this.TabTeachersStudents.BackColor = System.Drawing.Color.AliceBlue;
            this.TabTeachersStudents.Controls.Add(this.dgvResults);
            this.TabTeachersStudents.Controls.Add(this.label4);
            this.TabTeachersStudents.Controls.Add(this.label1);
            this.TabTeachersStudents.Controls.Add(this.cbSort);
            this.TabTeachersStudents.Controls.Add(this.label2);
            this.TabTeachersStudents.Controls.Add(this.btnSearch);
            this.TabTeachersStudents.Controls.Add(this.label3);
            this.TabTeachersStudents.Controls.Add(this.btnResetForm);
            this.TabTeachersStudents.Controls.Add(this.lblDateOfBirth);
            this.TabTeachersStudents.Controls.Add(this.btnDelete);
            this.TabTeachersStudents.Controls.Add(this.txtTeacherFirstName);
            this.TabTeachersStudents.Controls.Add(this.btnLoadStudents);
            this.TabTeachersStudents.Controls.Add(this.txtTeacherLastName);
            this.TabTeachersStudents.Controls.Add(this.panel1);
            this.TabTeachersStudents.Controls.Add(this.btnAddTeacher);
            this.TabTeachersStudents.Controls.Add(this.btnLoadTeachers);
            this.TabTeachersStudents.Controls.Add(this.dtStudentDateOfBirth);
            this.TabTeachersStudents.Controls.Add(this.numAge);
            this.TabTeachersStudents.Controls.Add(this.numTeacherId);
            this.TabTeachersStudents.Controls.Add(this.lblAge);
            this.TabTeachersStudents.Location = new System.Drawing.Point(4, 24);
            this.TabTeachersStudents.Name = "TabTeachersStudents";
            this.TabTeachersStudents.Padding = new System.Windows.Forms.Padding(3);
            this.TabTeachersStudents.Size = new System.Drawing.Size(480, 388);
            this.TabTeachersStudents.TabIndex = 0;
            this.TabTeachersStudents.Text = "TeachersStudents";
            // 
            // tabCourses
            // 
            this.tabCourses.BackColor = System.Drawing.Color.AliceBlue;
            this.tabCourses.Controls.Add(this.btnResetCourseForm);
            this.tabCourses.Controls.Add(this.dgvCourses);
            this.tabCourses.Controls.Add(this.cboCredits);
            this.tabCourses.Controls.Add(this.cboInstructor);
            this.tabCourses.Controls.Add(this.txtDepartment);
            this.tabCourses.Controls.Add(this.txtAbbreviation);
            this.tabCourses.Controls.Add(this.txtCourseName);
            this.tabCourses.Controls.Add(this.label9);
            this.tabCourses.Controls.Add(this.label8);
            this.tabCourses.Controls.Add(this.label7);
            this.tabCourses.Controls.Add(this.label6);
            this.tabCourses.Controls.Add(this.label5);
            this.tabCourses.Controls.Add(this.lblCourseId);
            this.tabCourses.Controls.Add(this.lblId);
            this.tabCourses.Controls.Add(this.btnShowCourses);
            this.tabCourses.Controls.Add(this.btnDeleteCourse);
            this.tabCourses.Controls.Add(this.btnAddUpdateCourse);
            this.tabCourses.Location = new System.Drawing.Point(4, 24);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourses.Size = new System.Drawing.Size(480, 388);
            this.tabCourses.TabIndex = 1;
            this.tabCourses.Text = "Courses";
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(9, 172);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowTemplate.Height = 25;
            this.dgvCourses.Size = new System.Drawing.Size(465, 195);
            this.dgvCourses.TabIndex = 16;
            // 
            // cboCredits
            // 
            this.cboCredits.FormattingEnabled = true;
            this.cboCredits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboCredits.Location = new System.Drawing.Point(104, 132);
            this.cboCredits.Name = "cboCredits";
            this.cboCredits.Size = new System.Drawing.Size(245, 23);
            this.cboCredits.TabIndex = 15;
            // 
            // cboInstructor
            // 
            this.cboInstructor.FormattingEnabled = true;
            this.cboInstructor.Location = new System.Drawing.Point(104, 98);
            this.cboInstructor.Name = "cboInstructor";
            this.cboInstructor.Size = new System.Drawing.Size(245, 23);
            this.cboInstructor.TabIndex = 14;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(103, 65);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(246, 23);
            this.txtDepartment.TabIndex = 12;
            // 
            // txtAbbreviation
            // 
            this.txtAbbreviation.Location = new System.Drawing.Point(103, 36);
            this.txtAbbreviation.Name = "txtAbbreviation";
            this.txtAbbreviation.Size = new System.Drawing.Size(246, 23);
            this.txtAbbreviation.TabIndex = 11;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(103, 6);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(246, 23);
            this.txtCourseName.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Instructor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Credits:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Abbreviation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Course Name:";
            // 
            // lblCourseId
            // 
            this.lblCourseId.AutoSize = true;
            this.lblCourseId.Location = new System.Drawing.Point(439, 140);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(35, 15);
            this.lblCourseId.TabIndex = 4;
            this.lblCourseId.Text = "value";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(420, 140);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 15);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID:";
            // 
            // btnShowCourses
            // 
            this.btnShowCourses.Location = new System.Drawing.Point(361, 64);
            this.btnShowCourses.Name = "btnShowCourses";
            this.btnShowCourses.Size = new System.Drawing.Size(113, 23);
            this.btnShowCourses.TabIndex = 2;
            this.btnShowCourses.Text = "Show Courses";
            this.btnShowCourses.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(361, 35);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteCourse.TabIndex = 1;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdateCourse
            // 
            this.btnAddUpdateCourse.Location = new System.Drawing.Point(361, 6);
            this.btnAddUpdateCourse.Name = "btnAddUpdateCourse";
            this.btnAddUpdateCourse.Size = new System.Drawing.Size(113, 23);
            this.btnAddUpdateCourse.TabIndex = 0;
            this.btnAddUpdateCourse.Text = "Add/Update Course";
            this.btnAddUpdateCourse.UseVisualStyleBackColor = true;
            // 
            // btnResetCourseForm
            // 
            this.btnResetCourseForm.Location = new System.Drawing.Point(361, 98);
            this.btnResetCourseForm.Name = "btnResetCourseForm";
            this.btnResetCourseForm.Size = new System.Drawing.Size(113, 23);
            this.btnResetCourseForm.TabIndex = 17;
            this.btnResetCourseForm.Text = "Reset Form";
            this.btnResetCourseForm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(515, 433);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "School Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabTeachersStudents.ResumeLayout(false);
            this.TabTeachersStudents.PerformLayout();
            this.tabCourses.ResumeLayout(false);
            this.tabCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDateOfBirth;
        private TextBox txtTeacherFirstName;
        private TextBox txtTeacherLastName;
        private Button btnAddTeacher;
        private DateTimePicker dtStudentDateOfBirth;
        private NumericUpDown numTeacherId;
        private DataGridView dgvResults;
        private Label lblAge;
        private NumericUpDown numAge;
        private Button btnLoadTeachers;
        private RadioButton rdoTeacher;
        private RadioButton rdoStudent;
        private Panel panel1;
        private Button btnLoadStudents;
        private Button btnDelete;
        private Button btnResetForm;
        private Button btnSearch;
        private ComboBox cbSort;
        private Label label4;
        private TabControl tabControl1;
        private TabPage TabTeachersStudents;
        private TabPage tabCourses;
        private ComboBox cboCredits;
        private ComboBox cboInstructor;
        private TextBox txtDepartment;
        private TextBox txtAbbreviation;
        private TextBox txtCourseName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblCourseId;
        private Label lblId;
        private Button btnShowCourses;
        private Button btnDeleteCourse;
        private Button btnAddUpdateCourse;
        private DataGridView dgvCourses;
        private Button btnResetCourseForm;
    }
}