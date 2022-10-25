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
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(17, 138);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(76, 15);
            this.lblDateOfBirth.TabIndex = 6;
            this.lblDateOfBirth.Text = "Date of Birth:";
            this.lblDateOfBirth.Visible = false;
            // 
            // txtTeacherFirstName
            // 
            this.txtTeacherFirstName.Location = new System.Drawing.Point(99, 60);
            this.txtTeacherFirstName.Name = "txtTeacherFirstName";
            this.txtTeacherFirstName.Size = new System.Drawing.Size(200, 23);
            this.txtTeacherFirstName.TabIndex = 8;
            // 
            // txtTeacherLastName
            // 
            this.txtTeacherLastName.Location = new System.Drawing.Point(99, 99);
            this.txtTeacherLastName.Name = "txtTeacherLastName";
            this.txtTeacherLastName.Size = new System.Drawing.Size(200, 23);
            this.txtTeacherLastName.TabIndex = 9;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(324, 60);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(127, 23);
            this.btnAddTeacher.TabIndex = 14;
            this.btnAddTeacher.Text = "Add/Update";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // dtStudentDateOfBirth
            // 
            this.dtStudentDateOfBirth.Location = new System.Drawing.Point(101, 134);
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
            this.numTeacherId.Location = new System.Drawing.Point(99, 26);
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
            this.dgvResults.Location = new System.Drawing.Point(4, 181);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.Size = new System.Drawing.Size(465, 176);
            this.dgvResults.TabIndex = 18;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellClick);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(62, 138);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 15);
            this.lblAge.TabIndex = 19;
            this.lblAge.Text = "Age:";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(101, 138);
            this.numAge.Maximum = new decimal(new int[] {
            -4836480,
            4,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(202, 23);
            this.numAge.TabIndex = 20;
            this.numAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLoadTeachers
            // 
            this.btnLoadTeachers.Location = new System.Drawing.Point(324, 118);
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
            this.rdoTeacher.Location = new System.Drawing.Point(32, 0);
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
            this.rdoStudent.Location = new System.Drawing.Point(32, 26);
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
            this.panel1.Location = new System.Drawing.Point(324, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 43);
            this.panel1.TabIndex = 24;
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.Location = new System.Drawing.Point(324, 147);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(127, 23);
            this.btnLoadStudents.TabIndex = 25;
            this.btnLoadStudents.Text = "Load Students";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(324, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 391);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoadStudents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoadTeachers);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.numTeacherId);
            this.Controls.Add(this.dtStudentDateOfBirth);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.txtTeacherLastName);
            this.Controls.Add(this.txtTeacherFirstName);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}