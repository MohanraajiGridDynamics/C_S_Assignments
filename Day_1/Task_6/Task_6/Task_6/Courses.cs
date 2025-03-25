using System;
using System.Text.Json;
using System.Collections.Generic;

public class Courses : Department
{
    
    public string jsonFilePath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/CourseData.json";

    
    public int[] CourseIDs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

    public string[] CoursesAvailable;
    public int CourseID;
    public string CourseName;
    public string Department;
    public string InstructorName;
    public int Credits;
    public string CourseSchedule;
    
   // public string[] Selected_Courses = new string[20] ;
   // public int[] Selected_Course_IDs = new int[20] ;
   
   //List<string> Selected_Courses = new List<string>();
    Dictionary<int, string> Selected_Courses = new Dictionary<int,string>();
    public void viewCourses()
    {
        
        
      /*  var coursesNames = JsonSerializer.Deserialize<CourseData>(CourseNames);

        string jsonString = File.ReadAllText(jsonFilePath);
        CourseData cd = JsonSerializer.Deserialize<CourseData>(jsonString);*/
      
        
        
        /*for (int i = 0; i < CourseIDs.Length; i++)
        {
            Console.WriteLine($"Course ID : {CourseIDs[i]} - Course Name : {CoursesAvailable[i]}");
        }*/

        foreach (var course in Dept_Courses)
        {
            Console.WriteLine($"Course ID: {course.Key} - Course Name : {course.Value}");
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
            
            Console.WriteLine($"The course you selected is {Dept_Courses[response]} and Course ID : {CourseIDs[response-1]}");

            for (int i = 1; i <= Selected_Courses.Count; i++)
            {
                if (Selected_Courses[i] == Dept_Courses[response]) 
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
            
            //Selected_Courses[index] = CoursesAvailable[response-1];
            //Selected_Course_IDs[index] = CourseIDs[response-1];
            
            Selected_Courses.Add(CourseIDs[response-1] ,Dept_Courses[response] );
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
            /*for (int i = 0; i < Selected_Courses.Count; i++)
            {
                if (Selected_Courses[i] == "" )
                {
                    break;
                }
                Console.WriteLine($"Course ID :{Selected_Courses.Key()} - Course Name : {Selected_Courses[i]}");
            }*/

            foreach (var course in Selected_Courses)
            {
                Console.WriteLine($"Course ID :{course.Key} - Course Name : {course.Value}");

            }

            Console.WriteLine("Thank you for adding the courses");
        }
        else
        {
            Console.WriteLine("Thank you for adding your course");
        }

    }
    
}