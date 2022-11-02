using Microsoft.EntityFrameworkCore;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Text;

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
			var modified = false;
			var teacher = new Teacher
			{
				Id = Convert.ToInt32(Math.Round(numTeacherId.Value)),
				FirstName = txtTeacherFirstName.Text,
				LastName = txtTeacherLastName.Text,
				Age = Convert.ToInt32(Math.Round(numAge.Value))
			};

			//Ensure teacher not in database

			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
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
						SendMessageBox("Teacher not found. Could not update.", "Error");
					}
				}
				else
				{
					var existingTeacher = context.Teachers.SingleOrDefault(t =>
						t.FirstName.ToLower() == teacher.FirstName.ToLower()
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
						SendMessageBox("Teacher already exists, did you mean to update?", "Error");
					}
				}

			if (!modified) return;
			ResetForm();
			LoadTeachers();
		}

		private void btnAddStudent_Click(object sender, EventArgs e)
		{
			var modified = false;

			var student = new Student
			{
				Id = Convert.ToInt32(Math.Round(numStudentId.Value)),
				FirstName = txtStudentFirstName.Text,
				LastName = txtStudentLastName.Text,
				DateOfBirth = dtStudentDateOfBirth.Value.Date
			};

			//Ensure teacher not in database

			using var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options);
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
				var existingStudent = context.Students.SingleOrDefault(t =>
					t.FirstName.ToLower() == student.FirstName.ToLower()
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

			if (isSearch) return;
			cboInstructor.SelectedIndex = -1;
			cboInstructor.Items.Clear();
			var data = dgvResults.DataSource as BindingList<Teacher>;
			cboInstructor.Items.AddRange(data!.ToArray());
			cboInstructor.DisplayMember = "FullName";
			cboInstructor.ValueMember = "Id";
		}

		private void btnLoadStudents_Click(object sender, EventArgs e)
		{
			LoadStudents();
		}

		private void LoadStudents()
		{
			using var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options);
			var dbStudents = new BindingList<Student>(context.Students.ToList());
			dgvResultsStudents.DataSource = dbStudents;
			dgvResultsStudents.Refresh();

			lstStudents.Items.Clear();
			lstStudents.Items.AddRange(dbStudents.ToArray());
		}


		private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0)
				{
					ResetForm();
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			var theRow = dgvResults.Rows[e.RowIndex];
			var dataId = 0;

			foreach (DataGridViewTextBoxCell cell in theRow.Cells)
				if (cell.OwningColumn.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
				{
					dataId = (int)cell.Value;
					if (dataId != 0) continue;
					SendMessageBox("Bad row clicked", "Error");
					ResetForm();
					return;
				}

			using var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options);
			var d = context.Teachers.SingleOrDefault(x => x.Id == dataId);
			if (d is null) return;
			numTeacherId.Value = d.Id;
			txtTeacherFirstName.Text = d.FirstName;
			txtTeacherLastName.Text = d.LastName;
			numAge.Value = d.Age;
		}

		private void dgvResultsStudents_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0)
				{
					ResetForm();
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			var theRow = dgvResultsStudents.Rows[e.RowIndex];
			var dataId = 0;

			foreach (DataGridViewTextBoxCell cell in theRow.Cells)
				if (cell.OwningColumn.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
				{
					dataId = (int)cell.Value;
					if (dataId != 0) continue;
					SendMessageBox("Bad row clicked", "Error");
					ResetForm();
					return;
				}

			using var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options);
			var d = context.Students.SingleOrDefault(x => x.Id == dataId);
			if (d is null) return;
			numStudentId.Value = d.Id;
			txtStudentFirstName.Text = d.FirstName;
			txtStudentLastName.Text = d.LastName;
			dtStudentDateOfBirth.Value = d.DateOfBirth;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var Id = (int)numTeacherId.Value;
			var confirmDelete = SendYesNoMessageBox("Are you sure you want to delete this item?", "Confirm");
			if (confirmDelete == DialogResult.No) return;
			using var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options);
			var d = context.Teachers.SingleOrDefault(t => t.Id == Id);
			if (d != null)
			{
				context.Teachers.Remove(d);
				context.SaveChanges();
				LoadTeachers();
			}
			else
			{
				SendMessageBox("Student not found, couldn't delete.", "Error");
			}
		}
		private void btnStudentDelete_Click(object sender, EventArgs e)
		{
			var Id = (int)numStudentId.Value;
			var confirmDelete = SendYesNoMessageBox("Are you sure you want to delete this item?", "Confirm");
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
					SendMessageBox("Student not found, couldn't delete.", "Error");
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
			txtStudentFirstName.Text = string.Empty;
			txtStudentLastName.Text = string.Empty;
			txtSelectedCourseId.Text = string.Empty;
			txtSelectedCourseName.Text = string.Empty;
			numAge.Value = 0;
			numTeacherId.Value = 0;

			dgvCourses.ClearSelection();
			dgvCourseAssignments.ClearSelection();
			dgvResultsStudents.ClearSelection();
			dgvResults.ClearSelection();
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
			var newCourse = new Course
			{
				Id = Convert.ToInt32(lblCourseId.Text),
				Abbreviation = txtAbbreviation.Text,
				Department = txtDepartment.Text,
				Name = txtCourseName.Text,
				NumCredits = Convert.ToInt32(cboCredits.SelectedItem),
				TeacherId = ((Teacher)cboInstructor.SelectedItem).Id
			};

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
						SendMessageBox("Course not found. Could not update.", "Error");
					}
				}
			}
			else
			{
				using var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options);
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
					SendMessageBox("Course already exists, did you mean to update?", "Error");
				}
			}
			if (modified)
			{
				ResetForm();
				LoadCourses();
			}
		}
		public void LoadCourses(bool isSearch = false)
		{
			using var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options);
			var dbCourses = new BindingList<Course>(context.Courses.Include(x => x.Teacher).ToList());
			var otherCourses = context.Courses.Include(x => x.Teacher)
				.Select(y => new
				{
					CourseName = y.Name,
					Credits = y.NumCredits,
					TeacherID = y.TeacherId,
					TeacherName = y.Teacher.FullName
				});

			//dgvCourses.DataSource = otherCourses;
			dgvCourses.DataSource = dbCourses.ToList();
			dgvCourses.Refresh();
			dgvCourseAssignments.DataSource = otherCourses.ToList();
			dgvCourseAssignments.Refresh();
			dgvCourseAssignments.Columns["TeacherId"]!.Visible = false;
			dgvCourseAssignments.Columns["Abbreviation"]!.Visible = false;
			dgvCourseAssignments.Columns["Credits"]!.Width = 50;
			dgvCourseAssignments.Columns["Id"]!.Width = 20;
			dgvCourseAssignments.Columns["TeacherName"]!.Width = 129;
		}

		private void btnShowCourses_Click(object sender, EventArgs e)
		{
			LoadCourses();
		}



		private void btnResetCourseForm_Click(object sender, EventArgs e)
		{
			ResetForm();
		}


		private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0)
				{
					ResetForm();
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			var theRow = dgvCourses.Rows[e.RowIndex];
			int dataId = 0;

			foreach (DataGridViewTextBoxCell cell in theRow.Cells)
			{

				if (cell.OwningColumn.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
				{
					dataId = (int)cell.Value;
					if (dataId == 0)
					{
						SendMessageBox("Bad row clicked", "Error");
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
			var confirmDelete = SendYesNoMessageBox($"Are you sure you want to delete [{name}]?", "Are you sure?");
			if (confirmDelete == DialogResult.No) return;
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
				//Remove selected course from database
				var d = context.Courses.SingleOrDefault(t => Convert.ToInt32(t.Id.ToString()) == Convert.ToInt32(Id));
				if (d != null)
				{
					context.Courses.Remove(d);
					context.SaveChanges();
					LoadCourses();
				}
				else
				{
					SendMessageBox("Student not found, couldn't delete.", "Error");
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
						dbCourses = new BindingList<Course>(dbCourses.OrderBy(x => x.NumCredits).ToList());
						break;
					case 3:
						dbCourses = new BindingList<Course>(dbCourses.OrderByDescending(x => x.NumCredits).ToList());
						break;
					case 4:
						dbCourses = new BindingList<Course>(dbCourses.OrderBy(x => x.Teacher.LastName).ToList());
						break;
					case 5:
						dbCourses = new BindingList<Course>(dbCourses.OrderByDescending(x => x.Teacher.LastName)
							.ToList());
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
			}
		}

		private void dgvCourseAssignments_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex < 0)
				{
					ResetForm();
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			var theRow = dgvCourseAssignments.Rows[e.RowIndex];
			var dataId = 0;

			foreach (DataGridViewTextBoxCell cell in theRow.Cells)
				if (cell.OwningColumn.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
				{
					dataId = (int)cell.Value;
					if (dataId == 0)
					{
						SendMessageBox("Bad row clicked", "Error");
						return;
					}

					btnAssociate.Enabled = true;
					btnAssociate.BackColor = Color.Transparent;
					btnAssociate.Cursor = DefaultCursor;
					txtSelectedCourseId.Text = dataId.ToString();
					txtSelectedCourseName.Text = theRow.Cells["CourseName"].Value.ToString();
				}
		}

		private void btnClearStudentList_Click(object sender, EventArgs e)
		{
			ResetStudentListForm();
		}

		private void ResetStudentListForm()
		{
			lstStudents.ClearSelected();
			//uncheck all boxes in the list
			foreach (int i in lstStudents.CheckedIndices) lstStudents.SetItemChecked(i, false);
		}

		private void btnAssociate_Click(object sender, EventArgs e)
		{
			btnAssociate.Enabled = false;
			var courseId = 0;
			try
			{
				courseId = Convert.ToInt32(txtSelectedCourseId.Text);
			}
			catch (Exception ex)
			{
				SendMessageBox("Please ensure all fields are filled out properly",
					"Error");
				Debug.WriteLine(ex.Message);
				return;
			}

			var courseName = txtSelectedCourseName.Text;
			if (lstStudents.CheckedItems.Count == 0)
			{
				SendMessageBox("Please select a student to associate with a course.",
					"Select a student");
				return;
			}

			if (string.IsNullOrEmpty(txtSelectedCourseId.Text) || courseId < 1)
			{
				SendMessageBox("Please select a course to associate with a student.",
					"Select a course");
				return;
			}

			var students = lstStudents.CheckedItems.Cast<Student>().ToList();
			var sb = StringOfNames(students);
			var confirmAssociate = SendYesNoMessageBox($"Are you sure you want to associate {sb} to {courseName}?", "Confirm");
			if (confirmAssociate == DialogResult.No)
			{
				var confirmReset = SendYesNoMessageBox("Do you want to reset your form ?", "Confirm Reset");
				if (confirmReset == DialogResult.Yes)
				{
					ResetForm();
					ResetStudentListForm();
				}

				btnAssociate.Enabled = false;
				return;
			}

			var success = AddStudentsToCourseAssociation(students, courseId, courseName);

			if (!success) return;
			ResetForm();
			ResetStudentListForm();
		}

		private static DialogResult SendYesNoMessageBox(string message, string caption)
		{
			return MessageBox.Show(message, caption,
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);
		}

		private static void SendMessageBox(string message, string caption)
		{
			const MessageBoxButtons buttonType = MessageBoxButtons.OK;
			var iconType = MessageBoxIcon.Information;
			MessageBox.Show($"{message}", $"{caption}", buttonType, iconType);
		}

		private bool AddStudentsToCourseAssociation(List<Student> students, int courseId, string courseName)
		{
			using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
			{
				var modified = false;
				var existingCourse = context.Courses.Include(x => x.CourseEnrollments)
					.SingleOrDefault(t => t.Id == courseId);
				if (existingCourse is null)
				{
					SendMessageBox($"{existingCourse.Name} does not exist.", "Error");
					return false;
				}

				foreach (var student in students)
				{
					var existingStudent = context.Students.Include(x => x.CourseEnrollments)
						.SingleOrDefault(s => s.Id == student.Id);
					if (existingStudent is null)
					{
						SendMessageBox($"{existingStudent} not found. Could not update.", "Error");
						continue;
					}

					var courseExists = false;
					foreach (var enrollment in existingStudent.CourseEnrollments)
					{
						if (enrollment.Course is null) break;
						if (enrollment.Course.Id == existingCourse.Id)
						{
							SendMessageBox($"{student.FullName} is already enrolled in {courseName}", "Error");
							courseExists = true;
							break;
						}
					}

					if (courseExists) continue;
					var courseEnrollment = new CourseEnrollment();
					courseEnrollment.CourseId = courseId;
					courseEnrollment.StudentId = student.Id;
					existingStudent.CourseEnrollments.Add(courseEnrollment);
					modified = true;
				}

				if (modified)
				{
					SendMessageBox("Students have been enrolled.", "Success");
					context.SaveChanges();
				}
			}

			return true;
		}

		private static StringBuilder StringOfNames(List<Student> students)
		{
			StringBuilder sb = new StringBuilder();
			foreach (var s in students)
			{
				if (sb.Length > 0)
				{
					sb.Append(", ");
				}
				sb.Append($"{s.FullName}");
			}

			return sb;
		}
	}
}

