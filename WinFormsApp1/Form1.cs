using SchoolOfFineArtsModels;
using System.ComponentModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvResults.DataSource = listTeachers;
        }

         BindingList<Teacher> listTeachers = new BindingList<Teacher>();

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            var teacher1 = new Teacher();
            teacher1.Id = Convert.ToInt32(Math.Round(numTeacherId.Value));
            teacher1.FirstName = txtTeacherFirstName.Text;
            teacher1.LastName = txtTeacherLastName.Text;

            //Does list contain id?
            foreach (var item in listTeachers)
            {
                if (item.Id == teacher1.Id)
                {
                    //If so, msgbox "MUST BE UNIQUE ID"
                    MessageBox.Show("This ID already exists.");

                } else
                {

                }
            }
            //If not, continue

            listTeachers.Add(teacher1);
            dgvResults.Refresh();

            MessageBox.Show(teacher1.ToString());
            //MessageBox.Show($"First Name: { teacher1.FirstName }, Last Name: {txtTeacherLastName.Text}, ID: {teacher1.Id} ");
        }
    }
}