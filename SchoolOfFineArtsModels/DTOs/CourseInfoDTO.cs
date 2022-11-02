﻿namespace SchoolOfFineArtsModels.DTOs
{
    public class CourseInfoDTO
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public string CourseAbbreviation { get; set; }
        public string CourseDepartment { get; set; }
    }
}
