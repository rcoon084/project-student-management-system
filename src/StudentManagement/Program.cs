using System.Diagnostics;
using StudentManagement.Models;
using StudentManagement.Services;

var studentService = new StudentService();

while (true)
{
    Console.WriteLine("Welcome to the Student Management System. Please choose an option: \n");
    Console.WriteLine("1. Create a student.\n2. Create a course\n3. Enroll a student in a course.\n4. See all students\n5. See all courses.\n0. Exit.");
    Console.WriteLine();

    var choice = Console.ReadLine();

    switch (choice)
    {
        default:
            Console.WriteLine($"{choice} is not a valid option. Please try again.");
            break;
        case "0":
            Console.WriteLine($"You entered {choice}: Exit. Goodbye.");
            return;
        case "1":
            Console.WriteLine($"You entered {choice}: Create a student.");
            Console.WriteLine("Please choose:\n 1. Simple (3 arguments)\n2. Complete (8 arguments)");
            var inputChoice = Console.ReadLine();
            switch (inputChoice)
            {
                default:
                    Console.WriteLine($"{choice} is not a valid option. Please try again.");
                    break;
                case "1":
                    Console.WriteLine("Please enter the following student data:");
                    Console.WriteLine("First Name: ");
                    var firstName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Last Name: ");
                    var lastName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("ID: ");
                    var studentID = Console.ReadLine();

                    studentService.CreateStudent(firstName, lastName, studentID);

                    Console.WriteLine("The student was created successfully: \n");
                    studentService.GetAllStudents();
                    break;
                case "2":
                    Console.WriteLine("Please enter the following student data:");
                    Console.WriteLine("First Name: ");
                    firstName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Last Name: ");
                    lastName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Gender: ");
                    var gender = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("ID: ");
                    studentID = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Email: ");
                    var email = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Semester: ");
                    var semester = Console.ReadLine();
                    int realSemester = int.Parse(semester);
                    Console.WriteLine();
                    Console.WriteLine("Major: ");
                    var major = Console.ReadLine();
                    Console.WriteLine();

                    studentService.CreateStudent(firstName, lastName, gender, studentID, email, realSemester, major);

                    Console.WriteLine("The student was created successfully: \n");
                    studentService.GetAllStudents();
                    break;
            }
            break;
        case "2":
            Console.WriteLine($"You entered {choice}: Create a course.");
            Console.WriteLine("Please enter the following course data:");
            Console.WriteLine("Course ID: ");
            var courseID = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Course Name: ");
            var courseName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Credits: ");
            var stringCredits = Console.ReadLine();
            var credits = int.Parse(stringCredits);

            studentService.CreateCourse(courseID, courseName, credits);

            Console.WriteLine("The course was created successfully: \n");
            studentService.GetAllCourses();

            break;
        case "3":
            Console.WriteLine($"You entered {choice}: Enroll a student in a course");
            Console.WriteLine("Please enter the following course data:");
            Console.WriteLine("Course ID: ");
            courseID = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Student ID: ");
            var studentIDs = Console.ReadLine();
            Console.WriteLine();

            studentService.EnrollStudent(studentIDs, courseID);

            Console.WriteLine($"The student {studentIDs} was enrolled in course {courseID} successfully \n");
            
            break;
        case "4":
            Console.WriteLine($"You entered {choice}: See all students.");
            studentService.GetAllStudents();
            break;
        case "5":
            Console.WriteLine($"You entered {choice}: See all courses.");
            studentService.GetAllCourses();
            break;

    }

}