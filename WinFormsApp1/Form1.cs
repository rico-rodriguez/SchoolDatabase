using Microsoft.EntityFrameworkCore;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;
using System.ComponentModel;
using System.Data;

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
			_cnstr = Program._configuration["ConnectionStrings:SchoolOfFineArtsDB"];
			_optionsBuilder = new DbContextOptionsBuilder<SchoolOfFineArtsDBContext>().UseSqlServer(_cnstr);
		}

		private void btnAddTeacher_Click(object sender, EventArgs e)
		{
			bool modified = false;
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
					ResetForm();
					LoadTeachers();
				}
			}
		}
		private void btnAddStudent_Click(object sender, EventArgs e)
		{
			bool modified = false;

			var student = new Student();
			//student.Id = 0;
			student.Id = Convert.ToInt32(Math.Round(numStudentId.Value));
			student.FirstName = txtStudentFirstName.Text;
			student.LastName = txtStudentLastName.Text;
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
					ResetForm();
					LoadStudents();
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
				dgvResultsStudents.DataSource = dbStudents;
				dgvResultsStudents.Refresh();

				lstStudents.Items.Clear();
				lstStudents.Items.AddRange(dbStudents.ToArray());
			}
		}


		private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
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
				var d = context.Teachers.SingleOrDefault(x => x.Id == dataId);
				if (d is not null)
				{
					numTeacherId.Value = d.Id;
					txtTeacherFirstName.Text = d.FirstName;
					txtTeacherLastName.Text = d.LastName;
					numAge.Value = d.Age;
				}
			}

		}
		private void dgvResultsStudents_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var theRow = dgvResultsStudents.Rows[e.RowIndex];
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
				var d = context.Students.SingleOrDefault(x => x.Id == dataId);
				if (d is not null)
				{
					numStudentId.Value = d.Id;
					txtStudentFirstName.Text = d.FirstName;
					txtStudentLastName.Text = d.LastName;
					dtStudentDateOfBirth.Value = d.DateOfBirth;
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
				var d = context.Teachers.SingleOrDefault(t => t.Id == Id);
				if (d != null)
				{
					context.Teachers.Remove(d);
					context.SaveChanges();
					LoadTeachers();
				}
				else
				{
					MessageBox.Show("Student not found, couldnt delete.");
				}
			}
		}
		private void btnStudentDelete_Click(object sender, EventArgs e)
		{
			var Id = (int)numStudentId.Value;
			var confirmDelete = MessageBox.Show("Are you sure you want to delete this item?"
				, "Are you sure?"
				, MessageBoxButtons.YesNo);
			if (confirmDelete == DialogResult.No)
			{
				return;
			}
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
				var d = context.Students.SingleOrDefault(s => s.Id == Id);
				if (d != null)
				{
					context.Students.Remove(d);
					context.SaveChanges();
					LoadStudents();
				}
				else
				{
					MessageBox.Show("Student not found, couldnt delete.");
				}

				dgvResultsStudents.Refresh();
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
			txtTeacherFirstName.Text = string.Empty;
			txtTeacherLastName.Text = string.Empty;
			numAge.Value = 0;
			numTeacherId.Value = 0;
		}
		private void btnResetStudentForm_Click(object sender, EventArgs e)
		{
			numStudentId.Text = "0";
			txtStudentFirstName.Text = string.Empty;
			txtStudentLastName.Text = string.Empty;
			dtStudentDateOfBirth.Value = DateTime.Now;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadTeachers();
			LoadStudents();
			LoadCourses();
			ResetForm();
			ResetCourseForm();

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{

			LoadTeachers(true);
			var tList = dgvResults.DataSource as BindingList<Teacher>;
			var fList = tList.Where(x => x.LastName.ToLower().Contains(txtTeacherLastName.Text.ToLower()) &&
									x.FirstName.ToLower().Contains(txtTeacherFirstName.Text.ToLower())).ToList();
			dgvResults.DataSource = new BindingList<Teacher>(fList);
			dgvResults.ClearSelection();
		}
		private void btnSearchStudents_Click(object sender, EventArgs e)
		{
			LoadStudents();
			var sList = dgvResultsStudents.DataSource as BindingList<Student>;
			var fList = sList.Where(x => x.LastName.ToLower().Contains(txtStudentLastName.Text.ToLower()) &&
									x.FirstName.ToLower().Contains(txtStudentFirstName.Text.ToLower())).ToList();
			dgvResultsStudents.DataSource = new BindingList<Student>(fList);
			dgvResultsStudents.ClearSelection();
		}

		private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
		{
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
				var tList = new BindingList<Teacher>(context.Teachers.ToList());
				switch (cbSort.SelectedIndex)
				{
					case 0:
						tList = new BindingList<Teacher>(tList.OrderBy(x => x.LastName).ToList());
						break;
					case 1:
						tList = new BindingList<Teacher>(tList.OrderByDescending(x => x.LastName).ToList());
						break;
					case 2:
						tList = new BindingList<Teacher>(tList.OrderBy(x => x.FirstName).ToList());
						break;
					case 3:
						tList = new BindingList<Teacher>(tList.OrderByDescending(x => x.FirstName).ToList());
						break;
					default:
						break;
				}
				dgvResults.DataSource = tList;
				dgvResults.Refresh();
			}
		}
		private void cbSortStudents_SelectedIndexChanged(object sender, EventArgs e)
		{
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
				var sList = new BindingList<Student>(context.Students.ToList());
				switch (cbSortStudents.SelectedIndex)
				{
					case 0:
						sList = new BindingList<Student>(sList.OrderBy(x => x.LastName).ToList());
						break;
					case 1:
						sList = new BindingList<Student>(sList.OrderByDescending(x => x.LastName).ToList());
						break;
					case 2:
						sList = new BindingList<Student>(sList.OrderBy(x => x.FirstName).ToList());
						break;
					case 3:
						sList = new BindingList<Student>(sList.OrderByDescending(x => x.FirstName).ToList());
						break;
					default:
						break;
				}
				dgvResultsStudents.DataSource = sList;
				dgvResultsStudents.Refresh();
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
				ResetCourseForm();
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

		public void LoadCourses(bool isSearch = false)
		{
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
				var dbCourses = new BindingList<Course>(context.Courses.Include(x => x.Teacher).ToList());

				//var courses = from c in context.Courses
				//			  join t in context.Teachers on c.TeacherId equals t.Id
				//			  select new { c.Id, c.Name, c.Abbreviation, c.Department, c.NumCredits, Instructor = t.FullName };


				//var otherCourses = context.Courses.Include(x => x.Teacher)
				//						.Select(y => new
				//						{
				//							Name = y.Name,
				//							Abbreviation = y.Abbreviation,
				//							//Department = y.Department,
				//							//NumCredits = y.NumCredits,
				//							TeacherID = y.TeacherId,
				//							TeacherName = y.Teacher.FullName
				//						});

				//dgvCourses.DataSource = otherCourses;
				dgvCourses.DataSource = dbCourses.ToList();
				dgvCourses.Refresh();
				dgvCourseAssignments.DataSource = dbCourses.ToList();
				dgvCourseAssignments.Refresh();

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
			var theRow = dgvCourses.Rows[e.RowIndex];
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
				if (d is not null)
				{
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

		private void btnDeleteCourse_Click(object sender, EventArgs e)
		{
			var Id = lblCourseId.Text;
			var name = txtCourseName.Text;
			var confirmDelete = MessageBox.Show($"Are you sure you want to delete [{name}]?"
				, "Are you sure?"
				, MessageBoxButtons.YesNo);
			if (confirmDelete == DialogResult.No)
			{
				return;
			}
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
				//Remove selected course from database
				var d = context.Courses.SingleOrDefault(t => Convert.ToInt32(t.Id.ToString()) == Convert.ToInt32(Id.ToString()));
				if (d != null)
				{
					context.Courses.Remove(d);
					context.SaveChanges();
					LoadCourses();
				}
				else
				{
					MessageBox.Show("Student not found, couldnt delete.");
				}
				dgvCourses.Refresh();
				ResetForm();
			}
		}

		private void cbSortCourses_SelectedIndexChanged(object sender, EventArgs e)
		{

			//Sort courses by selected criteria
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
                var dbCourses = new BindingList<Course>(context.Courses.Include(x => x.Teacher).ToList());

				switch (cbSortCourses.SelectedIndex)
				{
					case 0:
						dbCourses = new BindingList<Course>(dbCourses.OrderBy(x => x.Name).ToList());
						break;
					case 1:
						dbCourses = new BindingList<Course>(dbCourses.OrderByDescending(x => x.Name).ToList());
						break;
					case 2:
						//sort by teacher name
						dbCourses = new BindingList<Course>(dbCourses.OrderBy(x => x.NumCredits).ToList());
						break;
					case 3:
						dbCourses = new BindingList<Course>(dbCourses.OrderByDescending(x => x.NumCredits).ToList());
						break;
					case 4:
                        dbCourses = new BindingList<Course>(dbCourses.OrderBy(x => x.Teacher.LastName).ToList());
                        break;
					case 5:
                        dbCourses = new BindingList<Course>(dbCourses.OrderByDescending(x => x.Teacher.LastName).ToList());
                        break;
					default:
						break;
				}
				dgvCourses.DataSource = dbCourses;
				dgvCourses.Refresh();
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selIndex = ((TabControl)sender).SelectedIndex;

			switch (selIndex)
			{
				case 0:
					LoadTeachers();
					ResetForm();
					break;
				case 1:
					LoadStudents();
					ResetForm();
					break;
				case 2:
					LoadCourses();
					ResetForm();
					break;
				default:
					break;
			}
		}


	}
}

