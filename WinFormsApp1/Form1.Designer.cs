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
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.cbSortCourses = new System.Windows.Forms.ComboBox();
            this.btnResetCourseForm = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.cboCredits = new System.Windows.Forms.ComboBox();
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
            this.cboInstructor = new System.Windows.Forms.ComboBox();
            this.Students = new System.Windows.Forms.TabPage();
            this.dtStudentDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvResultsStudents = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSortStudents = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearchStudents = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnResetStudentForm = new System.Windows.Forms.Button();
            this.btnStudentDelete = new System.Windows.Forms.Button();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.numStudentId = new System.Windows.Forms.NumericUpDown();
            this.TabTeachersStudents = new System.Windows.Forms.TabPage();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtTeacherFirstName = new System.Windows.Forms.TextBox();
            this.txtTeacherLastName = new System.Windows.Forms.TextBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnLoadTeachers = new System.Windows.Forms.Button();
            this.numTeacherId = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbStudentCourses = new System.Windows.Forms.TabPage();
            this.btnAssociate = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.CheckedListBox();
            this.dgvCourseAssignments = new System.Windows.Forms.DataGridView();
            this.txtSelectedCourseId = new System.Windows.Forms.Label();
            this.lbSelectedCourseId = new System.Windows.Forms.Label();
            this.tabCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStudentId)).BeginInit();
            this.TabTeachersStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherId)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbStudentCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseAssignments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCourses
            // 
            this.tabCourses.BackColor = System.Drawing.Color.AliceBlue;
            this.tabCourses.Controls.Add(this.cbSortCourses);
            this.tabCourses.Controls.Add(this.btnResetCourseForm);
            this.tabCourses.Controls.Add(this.dgvCourses);
            this.tabCourses.Controls.Add(this.cboCredits);
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
            this.tabCourses.Controls.Add(this.cboInstructor);
            this.tabCourses.Location = new System.Drawing.Point(4, 24);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourses.Size = new System.Drawing.Size(480, 388);
            this.tabCourses.TabIndex = 1;
            this.tabCourses.Text = "Courses";
            // 
            // cbSortCourses
            // 
            this.cbSortCourses.FormattingEnabled = true;
            this.cbSortCourses.Items.AddRange(new object[] {
            "Course Name (ASC)",
            "Course Name (DESC)",
            "Credits (ASC)",
            "Credits (DESC)",
            "Instructor Name (ASC)",
            "Instructor Name (DESC)"});
            this.cbSortCourses.Location = new System.Drawing.Point(236, 132);
            this.cbSortCourses.Name = "cbSortCourses";
            this.cbSortCourses.Size = new System.Drawing.Size(113, 23);
            this.cbSortCourses.TabIndex = 18;
            this.cbSortCourses.Text = "Sort Results";
            this.cbSortCourses.SelectedIndexChanged += new System.EventHandler(this.cbSortCourses_SelectedIndexChanged);
            // 
            // btnResetCourseForm
            // 
            this.btnResetCourseForm.Location = new System.Drawing.Point(361, 98);
            this.btnResetCourseForm.Name = "btnResetCourseForm";
            this.btnResetCourseForm.Size = new System.Drawing.Size(113, 23);
            this.btnResetCourseForm.TabIndex = 17;
            this.btnResetCourseForm.Text = "Reset Form";
            this.btnResetCourseForm.UseVisualStyleBackColor = true;
            this.btnResetCourseForm.Click += new System.EventHandler(this.btnResetCourseForm_Click);
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(9, 172);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowTemplate.Height = 25;
            this.dgvCourses.Size = new System.Drawing.Size(465, 195);
            this.dgvCourses.TabIndex = 16;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);
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
            this.cboCredits.Size = new System.Drawing.Size(123, 23);
            this.cboCredits.TabIndex = 15;
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
            this.lblCourseId.Location = new System.Drawing.Point(461, 373);
            this.lblCourseId.Name = "lblCourseId";
            this.lblCourseId.Size = new System.Drawing.Size(13, 15);
            this.lblCourseId.TabIndex = 4;
            this.lblCourseId.Text = "0";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(442, 373);
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
            this.btnShowCourses.Text = "Load Courses";
            this.btnShowCourses.UseVisualStyleBackColor = true;
            this.btnShowCourses.Click += new System.EventHandler(this.btnShowCourses_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(361, 35);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(113, 23);
            this.btnDeleteCourse.TabIndex = 1;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnAddUpdateCourse
            // 
            this.btnAddUpdateCourse.Location = new System.Drawing.Point(361, 6);
            this.btnAddUpdateCourse.Name = "btnAddUpdateCourse";
            this.btnAddUpdateCourse.Size = new System.Drawing.Size(113, 23);
            this.btnAddUpdateCourse.TabIndex = 0;
            this.btnAddUpdateCourse.Text = "Add/Update Course";
            this.btnAddUpdateCourse.UseVisualStyleBackColor = true;
            this.btnAddUpdateCourse.Click += new System.EventHandler(this.btnAddUpdateCourse_Click);
            // 
            // cboInstructor
            // 
            this.cboInstructor.FormattingEnabled = true;
            this.cboInstructor.Location = new System.Drawing.Point(104, 98);
            this.cboInstructor.Name = "cboInstructor";
            this.cboInstructor.Size = new System.Drawing.Size(245, 23);
            this.cboInstructor.TabIndex = 14;
            this.cboInstructor.SelectedIndexChanged += new System.EventHandler(this.cboInstructor_SelectedIndexChanged);
            // 
            // Students
            // 
            this.Students.BackColor = System.Drawing.Color.AliceBlue;
            this.Students.Controls.Add(this.dtStudentDateOfBirth);
            this.Students.Controls.Add(this.label14);
            this.Students.Controls.Add(this.dgvResultsStudents);
            this.Students.Controls.Add(this.label10);
            this.Students.Controls.Add(this.label11);
            this.Students.Controls.Add(this.cbSortStudents);
            this.Students.Controls.Add(this.label12);
            this.Students.Controls.Add(this.btnSearchStudents);
            this.Students.Controls.Add(this.label13);
            this.Students.Controls.Add(this.btnResetStudentForm);
            this.Students.Controls.Add(this.btnStudentDelete);
            this.Students.Controls.Add(this.txtStudentFirstName);
            this.Students.Controls.Add(this.txtStudentLastName);
            this.Students.Controls.Add(this.button4);
            this.Students.Controls.Add(this.btnAddStudent);
            this.Students.Controls.Add(this.numStudentId);
            this.Students.Location = new System.Drawing.Point(4, 24);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(3);
            this.Students.Size = new System.Drawing.Size(480, 388);
            this.Students.TabIndex = 2;
            this.Students.Text = "Students";
            // 
            // dtStudentDateOfBirth
            // 
            this.dtStudentDateOfBirth.Location = new System.Drawing.Point(108, 142);
            this.dtStudentDateOfBirth.Name = "dtStudentDateOfBirth";
            this.dtStudentDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dtStudentDateOfBirth.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 15);
            this.label14.TabIndex = 51;
            this.label14.Text = "Date of Birth:";
            // 
            // dgvResultsStudents
            // 
            this.dgvResultsStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultsStudents.Location = new System.Drawing.Point(6, 206);
            this.dgvResultsStudents.Name = "dgvResultsStudents";
            this.dgvResultsStudents.RowTemplate.Height = 25;
            this.dgvResultsStudents.Size = new System.Drawing.Size(465, 176);
            this.dgvResultsStudents.TabIndex = 40;
            this.dgvResultsStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultsStudents_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 50;
            this.label10.Text = "Sort:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Id:";
            // 
            // cbSortStudents
            // 
            this.cbSortStudents.FormattingEnabled = true;
            this.cbSortStudents.Items.AddRange(new object[] {
            "Last Name (Ascending)",
            "Last Name (Descending)",
            "First Name (Ascending)",
            "First Name (Descending)"});
            this.cbSortStudents.Location = new System.Drawing.Point(108, 178);
            this.cbSortStudents.Name = "cbSortStudents";
            this.cbSortStudents.Size = new System.Drawing.Size(202, 23);
            this.cbSortStudents.TabIndex = 49;
            this.cbSortStudents.SelectedIndexChanged += new System.EventHandler(this.cbSortStudents_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "First Name:";
            // 
            // btnSearchStudents
            // 
            this.btnSearchStudents.Location = new System.Drawing.Point(327, 178);
            this.btnSearchStudents.Name = "btnSearchStudents";
            this.btnSearchStudents.Size = new System.Drawing.Size(127, 23);
            this.btnSearchStudents.TabIndex = 48;
            this.btnSearchStudents.Text = "Search";
            this.btnSearchStudents.UseVisualStyleBackColor = true;
            this.btnSearchStudents.Click += new System.EventHandler(this.btnSearchStudents_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "Last Name:";
            // 
            // btnResetStudentForm
            // 
            this.btnResetStudentForm.Location = new System.Drawing.Point(327, 142);
            this.btnResetStudentForm.Name = "btnResetStudentForm";
            this.btnResetStudentForm.Size = new System.Drawing.Size(127, 23);
            this.btnResetStudentForm.TabIndex = 47;
            this.btnResetStudentForm.Text = "Reset Form";
            this.btnResetStudentForm.UseVisualStyleBackColor = true;
            this.btnResetStudentForm.Click += new System.EventHandler(this.btnResetStudentForm_Click);
            // 
            // btnStudentDelete
            // 
            this.btnStudentDelete.Location = new System.Drawing.Point(327, 107);
            this.btnStudentDelete.Name = "btnStudentDelete";
            this.btnStudentDelete.Size = new System.Drawing.Size(127, 23);
            this.btnStudentDelete.TabIndex = 46;
            this.btnStudentDelete.Text = "Delete";
            this.btnStudentDelete.UseVisualStyleBackColor = true;
            this.btnStudentDelete.Click += new System.EventHandler(this.btnStudentDelete_Click);
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(108, 69);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(200, 23);
            this.txtStudentFirstName.TabIndex = 35;
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Location = new System.Drawing.Point(108, 106);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(200, 23);
            this.txtStudentLastName.TabIndex = 36;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(327, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(327, 70);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(127, 23);
            this.btnAddStudent.TabIndex = 37;
            this.btnAddStudent.Text = "Add/Update";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // numStudentId
            // 
            this.numStudentId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numStudentId.Cursor = System.Windows.Forms.Cursors.No;
            this.numStudentId.Enabled = false;
            this.numStudentId.Location = new System.Drawing.Point(108, 34);
            this.numStudentId.Maximum = new decimal(new int[] {
            -4836480,
            4,
            0,
            0});
            this.numStudentId.Name = "numStudentId";
            this.numStudentId.ReadOnly = true;
            this.numStudentId.Size = new System.Drawing.Size(45, 23);
            this.numStudentId.TabIndex = 39;
            // 
            // TabTeachersStudents
            // 
            this.TabTeachersStudents.BackColor = System.Drawing.Color.AliceBlue;
            this.TabTeachersStudents.Controls.Add(this.numAge);
            this.TabTeachersStudents.Controls.Add(this.label15);
            this.TabTeachersStudents.Controls.Add(this.dgvResults);
            this.TabTeachersStudents.Controls.Add(this.label4);
            this.TabTeachersStudents.Controls.Add(this.label1);
            this.TabTeachersStudents.Controls.Add(this.cbSort);
            this.TabTeachersStudents.Controls.Add(this.label2);
            this.TabTeachersStudents.Controls.Add(this.btnSearch);
            this.TabTeachersStudents.Controls.Add(this.label3);
            this.TabTeachersStudents.Controls.Add(this.btnResetForm);
            this.TabTeachersStudents.Controls.Add(this.btnDelete);
            this.TabTeachersStudents.Controls.Add(this.txtTeacherFirstName);
            this.TabTeachersStudents.Controls.Add(this.txtTeacherLastName);
            this.TabTeachersStudents.Controls.Add(this.btnAddTeacher);
            this.TabTeachersStudents.Controls.Add(this.btnLoadTeachers);
            this.TabTeachersStudents.Controls.Add(this.numTeacherId);
            this.TabTeachersStudents.Location = new System.Drawing.Point(4, 24);
            this.TabTeachersStudents.Name = "TabTeachersStudents";
            this.TabTeachersStudents.Padding = new System.Windows.Forms.Padding(3);
            this.TabTeachersStudents.Size = new System.Drawing.Size(480, 388);
            this.TabTeachersStudents.TabIndex = 0;
            this.TabTeachersStudents.Text = "Teachers";
            // 
            // numAge
            // 
            this.numAge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numAge.Location = new System.Drawing.Point(110, 140);
            this.numAge.Maximum = new decimal(new int[] {
            -4836480,
            4,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(35, 23);
            this.numAge.TabIndex = 54;
            this.numAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(71, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 15);
            this.label15.TabIndex = 53;
            this.label15.Text = "Age:";
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(6, 206);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.Size = new System.Drawing.Size(465, 176);
            this.dgvResults.TabIndex = 18;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sort:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Last Name (Ascending)",
            "Last Name (Descending)",
            "First Name (Ascending)",
            "First Name (Descending)"});
            this.cbSort.Location = new System.Drawing.Point(108, 178);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(202, 23);
            this.cbSort.TabIndex = 29;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(327, 178);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(327, 142);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(127, 23);
            this.btnResetForm.TabIndex = 27;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(327, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtTeacherFirstName
            // 
            this.txtTeacherFirstName.Location = new System.Drawing.Point(108, 69);
            this.txtTeacherFirstName.Name = "txtTeacherFirstName";
            this.txtTeacherFirstName.Size = new System.Drawing.Size(200, 23);
            this.txtTeacherFirstName.TabIndex = 8;
            // 
            // txtTeacherLastName
            // 
            this.txtTeacherLastName.Location = new System.Drawing.Point(108, 106);
            this.txtTeacherLastName.Name = "txtTeacherLastName";
            this.txtTeacherLastName.Size = new System.Drawing.Size(200, 23);
            this.txtTeacherLastName.TabIndex = 9;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(327, 70);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(127, 23);
            this.btnAddTeacher.TabIndex = 14;
            this.btnAddTeacher.Text = "Add/Update";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnLoadTeachers
            // 
            this.btnLoadTeachers.Location = new System.Drawing.Point(327, 37);
            this.btnLoadTeachers.Name = "btnLoadTeachers";
            this.btnLoadTeachers.Size = new System.Drawing.Size(127, 23);
            this.btnLoadTeachers.TabIndex = 21;
            this.btnLoadTeachers.Text = "Refresh";
            this.btnLoadTeachers.UseVisualStyleBackColor = true;
            this.btnLoadTeachers.Click += new System.EventHandler(this.btnLoadTeachers_Click_1);
            // 
            // numTeacherId
            // 
            this.numTeacherId.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numTeacherId.Cursor = System.Windows.Forms.Cursors.No;
            this.numTeacherId.Enabled = false;
            this.numTeacherId.Location = new System.Drawing.Point(108, 34);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabTeachersStudents);
            this.tabControl1.Controls.Add(this.Students);
            this.tabControl1.Controls.Add(this.tabCourses);
            this.tabControl1.Controls.Add(this.tbStudentCourses);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 416);
            this.tabControl1.TabIndex = 31;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbStudentCourses
            // 
            this.tbStudentCourses.Controls.Add(this.btnAssociate);
            this.tbStudentCourses.Controls.Add(this.lstStudents);
            this.tbStudentCourses.Controls.Add(this.dgvCourseAssignments);
            this.tbStudentCourses.Controls.Add(this.txtSelectedCourseId);
            this.tbStudentCourses.Controls.Add(this.lbSelectedCourseId);
            this.tbStudentCourses.Location = new System.Drawing.Point(4, 24);
            this.tbStudentCourses.Name = "tbStudentCourses";
            this.tbStudentCourses.Size = new System.Drawing.Size(480, 388);
            this.tbStudentCourses.TabIndex = 3;
            this.tbStudentCourses.Text = "Student Courses";
            this.tbStudentCourses.UseVisualStyleBackColor = true;
            // 
            // btnAssociate
            // 
            this.btnAssociate.Location = new System.Drawing.Point(402, 344);
            this.btnAssociate.Name = "btnAssociate";
            this.btnAssociate.Size = new System.Drawing.Size(75, 23);
            this.btnAssociate.TabIndex = 4;
            this.btnAssociate.Text = "Associate";
            this.btnAssociate.UseVisualStyleBackColor = true;
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(3, 3);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(157, 382);
            this.lstStudents.TabIndex = 3;
            // 
            // dgvCourseAssignments
            // 
            this.dgvCourseAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourseAssignments.Location = new System.Drawing.Point(166, 3);
            this.dgvCourseAssignments.Name = "dgvCourseAssignments";
            this.dgvCourseAssignments.RowTemplate.Height = 25;
            this.dgvCourseAssignments.Size = new System.Drawing.Size(311, 335);
            this.dgvCourseAssignments.TabIndex = 2;
            // 
            // txtSelectedCourseId
            // 
            this.txtSelectedCourseId.AutoSize = true;
            this.txtSelectedCourseId.Location = new System.Drawing.Point(464, 370);
            this.txtSelectedCourseId.Name = "txtSelectedCourseId";
            this.txtSelectedCourseId.Size = new System.Drawing.Size(13, 15);
            this.txtSelectedCourseId.TabIndex = 1;
            this.txtSelectedCourseId.Text = "0";
            // 
            // lbSelectedCourseId
            // 
            this.lbSelectedCourseId.AutoSize = true;
            this.lbSelectedCourseId.Location = new System.Drawing.Point(402, 370);
            this.lbSelectedCourseId.Name = "lbSelectedCourseId";
            this.lbSelectedCourseId.Size = new System.Drawing.Size(61, 15);
            this.lbSelectedCourseId.TabIndex = 0;
            this.lbSelectedCourseId.Text = "Course ID:";
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
            this.tabCourses.ResumeLayout(false);
            this.tabCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.Students.ResumeLayout(false);
            this.Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStudentId)).EndInit();
            this.TabTeachersStudents.ResumeLayout(false);
            this.TabTeachersStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherId)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbStudentCourses.ResumeLayout(false);
            this.tbStudentCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourseAssignments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabCourses;
        private ComboBox cbSortCourses;
        private Button btnResetCourseForm;
        private DataGridView dgvCourses;
        private ComboBox cboCredits;
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
        private ComboBox cboInstructor;
        private TabPage Students;
        private DataGridView dgvResultsStudents;
        private Label label10;
        private Label label11;
        private ComboBox cbSortStudents;
        private Label label12;
        private Button btnSearchStudents;
        private Label label13;
        private Button btnResetStudentForm;
        private Button btnStudentDelete;
        private TextBox txtStudentFirstName;
        private TextBox txtStudentLastName;
        private Button button4;
        private Button btnAddStudent;
        private NumericUpDown numStudentId;
        private TabPage TabTeachersStudents;
        private DataGridView dgvResults;
        private Label label4;
        private Label label1;
        private ComboBox cbSort;
        private Label label2;
        private Button btnSearch;
        private Label label3;
        private Button btnResetForm;
        private Button btnDelete;
        private TextBox txtTeacherFirstName;
        private TextBox txtTeacherLastName;
        private Button btnAddTeacher;
        private Button btnLoadTeachers;
        private NumericUpDown numTeacherId;
        private TabControl tabControl1;
        private DateTimePicker dtStudentDateOfBirth;
        private Label label14;
        private NumericUpDown numAge;
        private Label label15;
        private TabPage tbStudentCourses;
        private DataGridView dgvCourseAssignments;
        private Label txtSelectedCourseId;
        private Label lbSelectedCourseId;
        private Button btnAssociate;
        private CheckedListBox lstStudents;
    }
}