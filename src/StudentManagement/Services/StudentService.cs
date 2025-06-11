using StudentManagement.Models;

namespace StudentManagement.Services;

public class StudentService
{
    //Lists for storing data
    public List<Student> studentList = new();
    public List<Course> courseList = new();
    public List<Enrollment> enrollmentList = new();

    public void CreateStudent(string firstName, string lastName, string id)
    {
        var newStudent = new Student(firstName, lastName, id);
        studentList.Add(newStudent);
    }

    public void CreateCourse(string courseId, string courseName, int credits)
    {
        var newCourse = new Course(courseId, courseName, credits);
        courseList.Add(newCourse);
    }
}