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
            bool newObject = true;
            if (rdoTeacher.Checked)
            {
                var teacher = new Teacher();
                teacher.Id = 0;
                teacher.FirstName = txtTeacherFirstName.Text;
                teacher.LastName = txtTeacherLastName.Text;
                teacher.Age = Convert.ToInt32(Math.Round(numAge.Value));


                //Ensure teacher not in database

                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    var exists = context.Teachers.SingleOrDefault(t => t.FirstName.ToLower() == teacher.FirstName.ToLower()
                                                                  && t.LastName.ToLower() == teacher.LastName.ToLower()
                                                                  && t.Age == teacher.Age);

                    //If exists, post error
                    if (exists is not null)
                    {
                        newObject = false;
                        MessageBox.Show("Teacher already exists, did you mean to update?");
                    }
                    else
                    {
                        context.Teachers.Add(teacher);
                        context.SaveChanges();
                        //Reload teachers
                        var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                        dgvResults.DataSource = dbTeachers;
                        dgvResults.Refresh();
                    }

                }


                //If not, add teacher


            }
            else if (rdoStudent.Checked)
            {

            }
        }
            private void btnLoadTeachers_Click_1(object sender, EventArgs e)
            {
                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                    dgvResults.DataSource = dbTeachers;
                    dgvResults.Refresh();
                }
            }

            private void radioButton1_CheckedChanged(object sender, EventArgs e)
            {
                toggleControlVisibility();
            }

            private void toggleControlVisibility()
            {
                lblAge.Visible = rdoTeacher.Checked;
                lblDateOfBirth.Visible = rdoStudent.Checked;
                numAge.Visible = rdoTeacher.Checked;
                dtStudentDateOfBirth.Visible = rdoStudent.Checked;
            }

            private void rdoStudent_CheckedChanged(object sender, EventArgs e)
            {
                toggleControlVisibility();
            }

            private void btnAddStudent_Click(object sender, EventArgs e)
            {

            }

            private void btnLoadStudents_Click(object sender, EventArgs e)
            {
                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    var dbStudents = new BindingList<Student>(context.Students.ToList());
                    dgvResults.DataSource = dbStudents;
                    dgvResults.Refresh();
                }
            }
        }
    }
