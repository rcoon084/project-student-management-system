public class Enrollment
{
    private string studentID;
    private string courseID;
    
    public string StudentID
    {
        get { return studentID; }
        set { studentID = value; }
    }

    public string CourseID
    {
        get { return courseID; }
        set { courseID = value; }
    }

    public Enrollment(string studentID, string courseID)
    {
        StudentID = studentID;
        CourseID = courseID;
    }
}