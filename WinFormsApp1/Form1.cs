using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
            var data = Program._configuration["ConnectionStrings:SchoolOfFineArtsDB"];
            MessageBox.Show(data);

            var teacher1 = new Teacher();
            teacher1.Id = Convert.ToInt32(Math.Round(numTeacherId.Value));
            teacher1.FirstName = txtTeacherFirstName.Text;
            teacher1.LastName = txtTeacherLastName.Text;
            teacher1.Age = Convert.ToInt32(Math.Round(numAge.Value));


            bool validId = true;
            //Does list contain id?
            foreach (var item in listTeachers)
            {
                if (item.Id == teacher1.Id)
                {
                    //If so, msgbox "MUST BE UNIQUE ID"
                    MessageBox.Show("This ID already exists.");
                    validId = false;
                }
                if (item.FirstName.Equals(teacher1.FirstName,StringComparison.OrdinalIgnoreCase) 
                            && item.LastName.Equals(teacher1.LastName,StringComparison.OrdinalIgnoreCase)
                            && item.Age == teacher1.Age)
                {
                    MessageBox.Show("This user already exists.");
                    validId = false;
                }
            }
            //If not, continue
            if (validId)
            {
                listTeachers.Add(teacher1);
                dgvResults.Refresh();
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