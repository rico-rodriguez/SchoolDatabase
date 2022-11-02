using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolOfFineArtsDB.Migrations
{
    public partial class createcourseinfoview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR ALTER VIEW vwCourseInfo
                                AS
                                SELECT s.Id StudentId,CONCAT( s.Lastname, ' ', s.FirstName) StudentName,
                                                                s.DateOfBirth ,c.Id CourseId,c.Abbreviation,c.Department 
                                                                ,c.Name CourseName, t.Id TeacherId,CONCAT( t.LastName, ' ',t.FirstName) TeacherName
                                FROM CourseEnrollment ce
                                JOIN Courses c ON C.Id = ce.CourseId
                                JOIN Students s ON s.Id = ce.StudentId
                                JOIN Teachers t ON c.TeacherId = t.ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF EXISTS (SELECT 1 FROM sys.views WHERE OBJECT_ID=OBJECT_ID('dbo.vwCourseInfo'))
                                    BEGIN
                                        DROP VIEW dbo.vwCourseInfo
                                    END");
        }
    }
}
