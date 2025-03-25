using System.Text.Json;
using System.Collections.Generic;
public class CourseData
{
    //public string[][] CoursesAvailable;
    
    public Dictionary<string, List<string>> CoursesAvailable { get; set; }
    public int CourseID {get; set;}
    public string CourseName {get; set;}
    public string Department {get; set;}
    public string InstructorName {get; set;}
    public int Credits {get; set;}
    public string CourseSchedule {get; set;}
    
    //public string[] Selected_Courses = new string[20] ;
    //public int[] Selected_Course_IDs = new int[20] ;
    
    public Dictionary<int, string> Selected_Courses {get; set;}
    
}