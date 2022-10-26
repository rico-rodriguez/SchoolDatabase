using Microsoft.EntityFrameworkCore;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //use readonly as they are only set at form creation
        private readonly string _cnstr;
        private readonly DbContextOptionsBuilder _optionsBuilder;
        public Form1()
        {
            InitializeComponent();
            dgvResults.DataSource = listTeachers;
            _cnstr = Program._configuration["ConnectionStrings:SchoolOfFineArtsDB"];
            _optionsBuilder = new DbContextOptionsBuilder<SchoolOfFineArtsDBContext>().UseSqlServer(_cnstr);
        }
        BindingList<Teacher> listTeachers = new BindingList<Teacher>();

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            bool modified = false;
            if (rdoTeacher.Checked)
            {
                var teacher = new Teacher();
                //teacher.Id = 0;
                teacher.Id = Convert.ToInt32(Math.Round(numTeacherId.Value));
                teacher.FirstName = txtTeacherFirstName.Text;
                teacher.LastName = txtTeacherLastName.Text;
                teacher.Age = Convert.ToInt32(Math.Round(numAge.Value));


                //Ensure teacher not in database

                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    if (teacher.Id > 0)
                    {
                        var existingTeacher = context.Teachers.SingleOrDefault(t => t.Id == teacher.Id);

                        if (existingTeacher is not null)
                        {
                            existingTeacher.FirstName = teacher.FirstName;
                            existingTeacher.LastName = teacher.LastName;
                            existingTeacher.Age = teacher.Age;
                            context.SaveChanges();
                            modified = true;
                        }
                        else
                        {
                            MessageBox.Show("Teacher not found. Could not update.");
                        }

                    }
                    else
                    {
                        var existingTeacher = context.Teachers.SingleOrDefault(t => t.FirstName.ToLower() == teacher.FirstName.ToLower()
                                                                  && t.LastName.ToLower() == teacher.LastName.ToLower()
                                                                  && t.Age == teacher.Age);
                        if (existingTeacher == null)
                        {
                            context.Teachers.Add(teacher);
                            context.SaveChanges();
                            modified = true;
                        }
                        else
                        {
                            MessageBox.Show("Teacher already exists, did you mean to update?");
                        }
                    }
                    if (modified)
                    {
                        //Reload teachers
                        ResetForm();
                        var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                        dgvResults.DataSource = dbTeachers;
                        dgvResults.Refresh();
                    }
                }
            }
            else if (rdoStudent.Checked)
            {
                var student = new Student();
                //student.Id = 0;
                student.Id = Convert.ToInt32(Math.Round(numTeacherId.Value));
                student.FirstName = txtTeacherFirstName.Text;
                student.LastName = txtTeacherLastName.Text;
                student.DateOfBirth = dtStudentDateOfBirth.Value.Date;

                //Ensure teacher not in database

                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    if (student.Id > 0)
                    {
                        var existingStudent = context.Students.SingleOrDefault(t => t.Id == student.Id);

                        if (existingStudent is not null)
                        {
                            existingStudent.FirstName = student.FirstName;
                            existingStudent.LastName = student.LastName;
                            existingStudent.DateOfBirth = student.DateOfBirth;
                            context.SaveChanges();
                            modified = true;
                        }
                        else
                        {
                            MessageBox.Show("Teacher not found. Could not update.");
                        }

                    }
                    else
                    {
                        var existingStudent = context.Students.SingleOrDefault(t => t.FirstName.ToLower() == student.FirstName.ToLower()
                                                                  && t.LastName.ToLower() == student.LastName.ToLower()
                                                                  && t.DateOfBirth == student.DateOfBirth);
                        if (existingStudent == null)
                        {
                            context.Students.Add(student);
                            context.SaveChanges();
                            modified = true;
                        }
                        else
                        {
                            MessageBox.Show("Teacher already exists, did you mean to update?");
                        }
                    }
                    if (modified)
                    {
                        //Reload teachers
                        ResetForm();
                        var dbStudents = new BindingList<Student>(context.Students.ToList());
                        dgvResults.DataSource = dbStudents;
                        dgvResults.Refresh();
                    }
                }
            }
        }
        private void btnLoadTeachers_Click_1(object sender, EventArgs e)
        {
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                dgvResults.DataSource = dbTeachers;
                dgvResults.Refresh();
                rdoTeacher.Checked = true;
                rdoStudent.Checked = false;
            }
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var dbStudents = new BindingList<Student>(context.Students.ToList());
                dgvResults.DataSource = dbStudents;
                dgvResults.Refresh();
                rdoTeacher.Checked = false;
                rdoStudent.Checked = true;
            }
        }

        private void rdoTeacher_CheckedChanged(object sender, EventArgs e)
        {
            ToggleControlVisibility();
        }

        private void ToggleControlVisibility()
        {
            lblAge.Visible = rdoTeacher.Checked;
            lblDateOfBirth.Visible = rdoStudent.Checked;
            numAge.Visible = rdoTeacher.Checked;
            dtStudentDateOfBirth.Visible = rdoStudent.Checked;
        }

        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            ToggleControlVisibility();
        }

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var theRow = dgvResults.Rows[e.RowIndex];
            int dataId = 0;
            bool isTeacher = false;
            bool isStudent = false;

            foreach (DataGridViewTextBoxCell cell in theRow.Cells)
            {

                if (cell.OwningColumn.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
                {
                    dataId = (int)cell.Value;
                    if (dataId == 0)
                    {
                        MessageBox.Show("Bad row clicked");
                        ResetForm();
                        return;
                    }
                }
                if (cell.OwningColumn.Name.Equals("Age", StringComparison.OrdinalIgnoreCase))
                {
                    isTeacher = true;
                }
                if (cell.OwningColumn.Name.Equals("DateOfBirth", StringComparison.OrdinalIgnoreCase))
                {
                    isStudent = true;
                }
            }
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                if (isTeacher)
                {
                    var d = context.Teachers.SingleOrDefault(x => x.Id == dataId);
                    if (d is not null)
                    {
                        numTeacherId.Value = d.Id;
                        txtTeacherFirstName.Text = d.FirstName;
                        txtTeacherLastName.Text = d.LastName;
                        numAge.Value = d.Age;

                        rdoTeacher.Checked = true;
                        rdoStudent.Checked = false;
                        ToggleControlVisibility();
                    }
                }
                else if (isStudent)
                {
                    var d = context.Students.SingleOrDefault(x => x.Id == dataId);
                    if (d is not null)
                    {
                        numTeacherId.Value = d.Id;
                        txtTeacherFirstName.Text = d.FirstName;
                        txtTeacherLastName.Text = d.LastName;
                        dtStudentDateOfBirth.Value = d.DateOfBirth;

                        rdoTeacher.Checked = false;
                        rdoStudent.Checked = true;
                        ToggleControlVisibility();
                    }
                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Id = (int)numTeacherId.Value;
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this item?"
                , "Are you sure?"
                , MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.No)
            {
                return;
            }
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {

                if (rdoTeacher.Checked)
                {
                    var d = context.Teachers.SingleOrDefault(t => t.Id == Id);
                    if (d != null)
                    {
                        context.Teachers.Remove(d);
                        context.SaveChanges();
                        var databaseTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                        dgvResults.DataSource = databaseTeachers;
                    }
                    else
                    {
                        MessageBox.Show("Student not found, couldnt delete.");
                    }
                }

                else if (rdoStudent.Checked)
                {
                    var d = context.Students.SingleOrDefault(s => s.Id == Id);
                    if (d != null)
                    {
                        context.Students.Remove(d);
                        context.SaveChanges();
                        var databaseStudents = new BindingList<Student>(context.Students.ToList());
                        dgvResults.DataSource = databaseStudents;
                    }
                    else
                    {
                        MessageBox.Show("Student not found, couldnt delete.");
                    }
                }
                dgvResults.Refresh();
                ResetForm();
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            numTeacherId.Value = 0;
            txtTeacherFirstName.Text = string.Empty;
            txtTeacherLastName.Text = string.Empty;
            numAge.Value = Convert.ToInt32(0);
            dtStudentDateOfBirth.Value = new DateTime(1900, 1, 1);
            dgvResults.ClearSelection();
        }
    }
}
