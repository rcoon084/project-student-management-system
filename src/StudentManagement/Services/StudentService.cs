using System.Diagnostics.CodeAnalysis;
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

    public void CreateStudent(string firstName, string lastName, string gender, string id, string email, int semester, string mayor)
    {
        var newStudent = new Student(firstName, lastName, gender, id, email, semester, mayor);
        studentList.Add(newStudent);
    }

    public void CreateCourse(string courseId, string courseName, int credits)
    {
        var newCourse = new Course(courseId, courseName, credits);
        courseList.Add(newCourse);
    }
    public void GetAllStudents()
    {
        for (int i = 0; i < studentList.Count; i++)
        {
            Console.WriteLine(studentList[i].ToString() + "\n---------------------------");
        }
    }

    public void GetAllCourses()
    {
        for (int i = 0; i < courseList.Count; i++)
        {
            Console.WriteLine(courseList[i].ToString() + "\n---------------------------");
        }
    }

    public void EnrollStudent(string studentID, string courseID)
    {
        Student? studentFound = studentList.FirstOrDefault(student => student.Id == studentID);
        if (studentFound == null)
        {
            throw new ArgumentException("The student was not found.");
        }
        Course? courseFound = courseList.FirstOrDefault(course => course.CourseId == courseID);
        if (courseFound == null)
        {
            throw new ArgumentException("The course was not found.");
        }
        var newEnroll = new Enrollment(studentID, courseID);
        enrollmentList.Add(newEnroll);
    }

}