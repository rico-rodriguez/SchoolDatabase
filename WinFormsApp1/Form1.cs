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
						//var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
						//dgvResults.DataSource = dbTeachers;
						//dgvResults.Refresh();
						LoadTeachers();
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
						//var dbStudents = new BindingList<Student>(context.Students.ToList());
						//dgvResults.DataSource = dbStudents;
						//dgvResults.Refresh();
						LoadStudents();
					}
				}
			}
		}

		private void btnLoadTeachers_Click_1(object sender, EventArgs e)
		{
			LoadTeachers();
		}

		private void LoadTeachers(bool isSearch = false)
		{
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
				var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
				dgvResults.DataSource = dbTeachers;
				dgvResults.Refresh();
				rdoTeacher.Checked = true;
				rdoStudent.Checked = false;
			}
			if (!isSearch)
			{
				cboInstructor.SelectedIndex = -1;
				cboInstructor.Items.Clear();
				var data = dgvResults.DataSource as BindingList<Teacher>;
				cboInstructor.Items.AddRange(data.ToArray());
				cboInstructor.DisplayMember = "FullName";
				cboInstructor.ValueMember = "Id";
			}
		}

		private void btnLoadStudents_Click(object sender, EventArgs e)
		{
			LoadStudents();
		}

		private void LoadStudents()
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
			if (rdoTeacher.Checked)
			{
				LoadTeachers();
				ResetForm();

			}
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
			if (rdoStudent.Checked)
			{
				LoadStudents();
				ResetForm();

			}
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
						//var databaseTeachers = new BindingList<Teacher>(context.Teachers.ToList());
						//dgvResults.DataSource = databaseTeachers;
						LoadTeachers();
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
						//var databaseStudents = new BindingList<Student>(context.Students.ToList());
						//dgvResults.DataSource = databaseStudents;
						LoadStudents();
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
            lblCourseId.Text = "0";
            txtAbbreviation.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            txtCourseName.Text = string.Empty;
            cboInstructor.SelectedIndex = -1;
            cboCredits.SelectedIndex = 2;
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadTeachers();
			LoadCourses();
			ResetForm();
			ResetCourseForm();

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{

			if (rdoTeacher.Checked)
			{
				LoadTeachers(true);
				var tList = dgvResults.DataSource as BindingList<Teacher>;
				var fList = tList.Where(x => x.LastName.ToLower().Contains(txtTeacherLastName.Text.ToLower()) &&
										x.FirstName.ToLower().Contains(txtTeacherFirstName.Text.ToLower())).ToList();
				dgvResults.DataSource = new BindingList<Teacher>(fList);
				dgvResults.ClearSelection();
			}
			if (rdoStudent.Checked)
			{
				LoadStudents();
				var sList = dgvResults.DataSource as BindingList<Student>;
				var fList = sList.Where(x => x.LastName.ToLower().Contains(txtTeacherLastName.Text.ToLower()) &&
										x.FirstName.ToLower().Contains(txtTeacherFirstName.Text.ToLower())).ToList();
				dgvResults.DataSource = new BindingList<Student>(fList);
				dgvResults.ClearSelection();
			}
		}

		private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (rdoTeacher.Checked)
			{
				//Sort data grid by last name asc
				if (cbSort.SelectedIndex == 0)
				{
					var tList = dgvResults.DataSource as BindingList<Teacher>;
					var fList = tList.OrderBy(x => x.LastName).ToList();
					dgvResults.DataSource = new BindingList<Teacher>(fList);
					dgvResults.ClearSelection();
				}
				//Sort data grid by last name desc
				if (cbSort.SelectedIndex == 1)
				{
					var tList = dgvResults.DataSource as BindingList<Teacher>;
					var fList = tList.OrderBy(x => x.LastName).Reverse().ToList();
					dgvResults.DataSource = new BindingList<Teacher>(fList);
					dgvResults.ClearSelection();
				}
				//Sort data grid by first name asc
				if (cbSort.SelectedIndex == 2)
				{
					var tList = dgvResults.DataSource as BindingList<Teacher>;
					var fList = tList.OrderBy(x => x.FirstName).ToList();
					dgvResults.DataSource = new BindingList<Teacher>(fList);
					dgvResults.ClearSelection();
				}
				//Sort data grid by first name desc
				if (cbSort.SelectedIndex == 3)
				{
					var tList = dgvResults.DataSource as BindingList<Teacher>;
					var fList = tList.OrderBy(x => x.FirstName).Reverse().ToList();
					dgvResults.DataSource = new BindingList<Teacher>(fList);
					dgvResults.ClearSelection();
				}
			}
			if (rdoStudent.Checked)
			{
				//Sort data grid by last name asc
				if (cbSort.SelectedIndex == 0)
				{
					var sList = dgvResults.DataSource as BindingList<Student>;
					var fList = sList.OrderBy(x => x.LastName).ToList();
					dgvResults.DataSource = new BindingList<Student>(fList);
					dgvResults.ClearSelection();
				}
				//Sort data grid by last name desc
				if (cbSort.SelectedIndex == 1)
				{
					var sList = dgvResults.DataSource as BindingList<Student>;
					var fList = sList.OrderBy(x => x.LastName).Reverse().ToList();
					dgvResults.DataSource = new BindingList<Student>(fList);
					dgvResults.ClearSelection();
				}
				//Sort data grid by first name asc
				if (cbSort.SelectedIndex == 2)
				{
					var sList = dgvResults.DataSource as BindingList<Student>;
					var fList = sList.OrderBy(x => x.FirstName).ToList();
					dgvResults.DataSource = new BindingList<Student>(fList);
					dgvResults.ClearSelection();
				}
				//Sort data grid by first name desc
				if (cbSort.SelectedIndex == 3)
				{
					var sList = dgvResults.DataSource as BindingList<Student>;
					var fList = sList.OrderBy(x => x.FirstName).Reverse().ToList();
					dgvResults.DataSource = new BindingList<Student>(fList);
					dgvResults.ClearSelection();
				}

			}
		}

		/*
		 * 
		 * 
		 * BEGIN COURSE LOGIC
		 *
		 * 
		 */

		private void btnAddUpdateCourse_Click(object sender, EventArgs e)
		{
 			bool modified = false;

			//Get course info and store in temp variable
			var newCourse = new Course();
            newCourse.Id = Convert.ToInt32(lblCourseId.Text);
            newCourse.Abbreviation = txtAbbreviation.Text;
            newCourse.Department = txtDepartment.Text;
            newCourse.Name = txtCourseName.Text;
            newCourse.NumCredits = Convert.ToInt32(cboCredits.SelectedItem);
            newCourse.TeacherId = ((Teacher)cboInstructor.SelectedItem).Id;


            //Ensure teacher not in database

            //using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            //{
            if (newCourse.Id > 0)
			{
				using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
				{
					var existingCourse = context.Courses.SingleOrDefault(t => t.Id == newCourse.Id);

					if (existingCourse is not null)
					{
						existingCourse.NumCredits = newCourse.NumCredits;
						existingCourse.Abbreviation = newCourse.Abbreviation;
						existingCourse.Department = newCourse.Department;
						existingCourse.Name = newCourse.Name;
						existingCourse.TeacherId = newCourse.TeacherId;
						context.SaveChanges();
						modified = true;
					}
					else
					{
						MessageBox.Show("Course not found. Could not update.");
					}
				}
			}
			else
			{
				using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
				{
					var existingCourse = context.Courses.SingleOrDefault(c => c.Name.ToLower() == newCourse.Name.ToLower()
														  && c.Abbreviation.ToLower() == newCourse.Abbreviation.ToLower()
														  && c.TeacherId == newCourse.TeacherId);

					if (existingCourse == null)
					{
						context.Courses.Add(newCourse);
						context.SaveChanges();
						modified = true;
					}
					else
					{
						MessageBox.Show("Course already exists, did you mean to update?");
					}
				}

			}
            if (modified)
            {
                //Reload teachers
                ResetCourseForm();
                //var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                //dgvResults.DataSource = dbTeachers;
                //dgvResults.Refresh();
                LoadCourses();
            }
        }

		private void cboInstructor_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Get selected teacher
			var selectedTeacher = (Teacher)cboInstructor.SelectedItem;

			//Get teacher's courses
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
			}
		}

		public void LoadCourses()
		{
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
				var dbCourses = new BindingList<Course>(context.Courses.ToList());
				dgvCourses.DataSource = dbCourses;
				dgvCourses.Refresh();
			}

		}

		private void btnShowCourses_Click(object sender, EventArgs e)
		{
			LoadCourses();

		}



		private void btnResetCourseForm_Click(object sender, EventArgs e)
		{
			ResetCourseForm();
		}

		private void ResetCourseForm()
		{
			lblCourseId.Text = "0";
			txtCourseName.Text = string.Empty;
			txtAbbreviation.Text = string.Empty;
			txtDepartment.Text = string.Empty;
			cboInstructor.SelectedIndex = -1;
			cboCredits.SelectedIndex = 2;
			dgvCourses.ClearSelection();
		}

		private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var theRow = dgvResults.Rows[e.RowIndex];
			int dataId = 0;

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
			}
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
				var d = context.Courses.SingleOrDefault(x => x.Id == dataId);

                lblCourseId.Text = d.Id.ToString();
                txtCourseName.Text = d.Name;
				txtAbbreviation.Text = d.Abbreviation;
				txtDepartment.Text = d.Department;

				foreach (var item in cboCredits.Items)
				{
                    if (Convert.ToInt32(item) == d.NumCredits)
                    {
                        cboCredits.SelectedItem = item;
                    }
				}
                foreach (var item in cboInstructor.Items)
                {
                    var t = (Teacher)item;
                    if (t.Id == d.TeacherId)
                    {
                        cboInstructor.SelectedItem = item;
                    }
                }

            }

		}
	}
}
