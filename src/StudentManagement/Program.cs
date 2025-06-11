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
            break;
        case "3":
            break;
        case "4":
            break;
        case "5":
            break;

    }

}