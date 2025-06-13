namespace StudentManagement.Models;

public class Student
{
    // Student Properties
    private string firstName;
    private string lastName;
    private string gender;
    private int age;
    private string id;
    private string email;
    private int semester;
    private string major;
    private bool isActive;

    // Student accessors (Implementing encapsulation)
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }


    public int Semester
    {
        get { return semester; }
        set { semester = value; }
    }

    public string Major
    {
        get { return major; }
        set { major = value; }
    }

    public bool IsActive
    {
        get { return isActive; }
        set { isActive = value; }
    }

    //Constructor
    //By default, the student is active in the institution
    public Student(string firstName, string lastName, string id)
    {
        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException("First and last name cannot be empty.");
        }
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("ID cannot be empty.");
        }
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        IsActive = true;
    }
    public Student(string firstName, string lastName, string gender, string id, string email, int semester, string major)
    {
        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
        {
            throw new ArgumentException("First and last name cannot be empty.");
        }
        if (string.IsNullOrWhiteSpace(id))
        {
            throw new ArgumentException("ID cannot be empty.");
        }

        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Id = id;
        Email = email;
        Semester = semester;
        Major = major;
        IsActive = true;
    }

    public override string ToString()
    {
        return $"[STUDENT DETAILS]\n" +
       $"ID:       {Id}\n" +
       $"Name:     {FirstName} {LastName}\n" +
       $"Email:    {Email}\n" +
       $"Active:   {IsActive}\n" +
       $"Gender:   {Gender}\n" +
       $"Age:      {Age}\n" +
       $"Major:    {Major}\n" +   
       $"Semester: {Semester}";
    }
}