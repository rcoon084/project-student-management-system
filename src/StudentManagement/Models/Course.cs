namespace StudentManagement.Models;

public class Course
{
    //Course properties
    private string courseId;
    private string courseName;
    private string description;
    private int credits;
    private bool isAvailable;

    //Course accessors
    public string CourseId
    {
        get { return courseId; }
        set { courseId = value; }
    }

    public string CourseName
    {
        get { return courseName; }
        set { courseName = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public int Credits
    {
        get { return credits; }
        set { credits = value; }
    }

    public bool IsAvailable
    {
        get { return isAvailable; }
        set { isAvailable = value; }
    }

    //Course Constructor
    public Course(string courseId, string courseName, int credits)
    {
        if (string.IsNullOrWhiteSpace(courseId))
        {
            throw new ArgumentException("Course ID cannot be empty.");
        }
        if (string.IsNullOrWhiteSpace(courseName))
        {
            throw new ArgumentException("Course Name cannot be empty.");
        }
        if (credits <= 0)
        {
            throw new ArgumentException("Invalid credit number.");
        }
        CourseId = courseId;
        CourseName = courseName;
        Credits = credits;
        IsAvailable = true;
    }

    public Course(string courseId, string courseName, string description, int credits)
    {
        if (string.IsNullOrWhiteSpace(courseId))
        {
            throw new ArgumentException("Course ID cannot be empty.");
        }
        if (string.IsNullOrWhiteSpace(courseName))
        {
            throw new ArgumentException("Course Name cannot be empty.");
        }
        if (credits <= 0)
        {
            throw new ArgumentException("Invalid credit number.");
        }
        CourseId = courseId;
        CourseName = courseName;
        Description = description;
        Credits = credits;
        IsAvailable = true;
    }

    //Course Methods
    public override string ToString()
    {
        return $"[COURSE DETAILS]\n" +
               $"ID:          {CourseId}\n" +
               $"Name:        {CourseName}\n" +
               $"Description: {Description}\n" +
               $"Credits:     {Credits}\n" +
               $"Available:   {IsAvailable}";
    }
}