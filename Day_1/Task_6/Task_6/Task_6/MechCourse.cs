namespace College;

public class MechCourse
{

    public string[] CoursesAvailable =
    {
        "Thermodynamics and Heat Transfer", "Fluid Mechanics and Dynamics", "Mechanical Design and CAD",
        "Manufacturing Processes and Automation", "Materials Science and Engineering"
    };
    
    public int[] CourseIDs = { 1, 2, 3, 4, 5};
    
    public int CourseID;
    public string CourseName;
    public string Department;
    public string InstructorName;
    public int Credits;
    public string CourseSchedule;
    
    public string[] Selected_Courses = new string[5] ;
    public int[] Selected_Course_IDs = new int[5] ;

    public void viewCourses()
    {
        for (int i = 0; i < CourseIDs.Length; i++)
        {
            Console.WriteLine($"Course ID : {CourseIDs[i]} - Course Name : {CoursesAvailable[i]}");
        }
    }

    public void addCourse()
    {

        int response = 0;
        int index = 0;
        int flag = 0;
        do
        {
            flag = 0;
            Console.WriteLine("Select the course you want to add (Press 1 - 20): ");
            viewCourses();
            
            
            response = Convert.ToInt32(Console.ReadLine());
            if (response > 20)
            {
                Console.WriteLine("Please enter a valid number");
                response = 1;
                continue;
            }
            
            Console.WriteLine($"The course you selected is {CoursesAvailable[response-1]} and Course ID : {CourseIDs[response-1]}");

            for (int i = 0; i < Selected_Courses.Length; i++)
            {
                if (Selected_Courses[i] == CoursesAvailable[response-1]) 
                {
                    Console.WriteLine("Course is already added");
                    Console.WriteLine("Select any other Course ");
                    Console.WriteLine("Redirecting");
                    response = 1;
                    flag = 1;
                    break;
                }
                
            }
            
            if (flag == 1)
                continue;
            
            Selected_Courses[index] = CoursesAvailable[response-1];
            Selected_Course_IDs[index] = CourseIDs[response-1];
            index++;
            
            
            Console.WriteLine("Do you want to add another course? ");
            Console.WriteLine("Press 1 to add another course: ");
            Console.WriteLine("If selected Enough Press 0");
            response = Convert.ToInt32(Console.ReadLine());
           

        } while (response != 0);
        
        Console.WriteLine("Successfully added your courses");
        Console.WriteLine("Press 1 to view all courses or Any number to exit: ");
        response = Convert.ToInt32(Console.ReadLine());
        if (response == 1)
        {
            for (int i = 0; i < Selected_Courses.Length; i++)
            {
                if (Selected_Courses[i] == "" || Selected_Course_IDs[i] == 0)
                {
                    break;
                }
                Console.WriteLine($"Course ID :{Selected_Course_IDs[i]} - Course Name : {Selected_Courses[i]}");
            }
        }
        else
        {
            Console.WriteLine("Thank you for adding your course");
        }

    }
}

