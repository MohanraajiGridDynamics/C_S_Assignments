using System.Text.Json;
using College.DataClasses;


public class Instructor
{
    public Dictionary<int, string> eeeDict = new Dictionary<int, string>() 
        {{1,"Olivia Green"}, {2,"Ethan Brooks"}, {3,"Sophia Carter"}, {4,"Liam Harris"}, {5,"Ava Mitchell"}, {6,"James Parker"}, {7,"Mia Collins"},
            {8,"Benjamin Lee"}, {9,"Charlotte Davis"}, {10,"Lucas Rivera"}};

    public Dictionary<int, string> itDict = new Dictionary<int, string>();
    public Dictionary<int, string> mechDict = new Dictionary<int, string>();

    
    public string[] ITFaculties =
    {
        "Isla Bennett", "Jackson Reed", "Amelia Foster", "Leo Palmer", "Grace Mitchell", "Zane Cooper", "Hazel Brooks",
        "Maximus Hayes", "Eliza Walker", "Owen Clark", "Aria Sullivan", "Theo Richardson", "Lily Dawson",
        "Asher Phillips", "Maya Scott", "Sebastian Carter", "Aiden Thomas", "Zara Morgan", "Evelyn Gray", "Isaac Lewis"
    };

    public string[] MechFaculties =
    {
        "Jasper Cole", "Nora Flynn", "Kai Hudson", "Ivy Wells", "Milo Grant"
    };

    public string jsonFilePath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/CourseData.json";
    public string deptJsonPath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/DepartmentData.json";
    public string instructorJsonPath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/instructorData.json";

    
    public Dictionary<int, string> SelectedInstructors = new Dictionary<int, string>();
    public Dictionary<int, string> selectedCourses = new Dictionary<int, string>();
    public void getInstructorDetails()
    {
        int key = 1;
        foreach (string name in ITFaculties)
        {
            itDict.Add(key, name);
            key++;
        }

        key = 1;
        foreach (string name in MechFaculties)
        {
            mechDict.Add(key, name);
            key++;
        }
        
        //just setting the Instructor details 
        
        string jsonString = File.ReadAllText(jsonFilePath);
        
        List<CourseData> courses = JsonSerializer.Deserialize<List<CourseData>>(jsonString);

        int instructorID = 1;
        string instructorName = "";
        
        string DeptjsonString = File.ReadAllText(deptJsonPath);
        DepartmentData dept = JsonSerializer.Deserialize<DepartmentData>(DeptjsonString);
        int deptID = dept.DeptNumber;
        string deptName = dept.DepartmentName;
        
        
        foreach (var course in courses)
        {
            instructorID = course.CourseID;
            //Console.WriteLine("Instructor ID: " + instructorID);
            
            if (deptID == 1)
            {
                instructorName = itDict[instructorID+1];
            }
            else if (deptID == 2)
            {
                instructorName = eeeDict[instructorID+1];
            }
            else if (deptID == 3)
            {
                instructorName = mechDict[instructorID+1];
            }
            
            SelectedInstructors.Add(instructorID, instructorName);
            selectedCourses.Add(course.CourseID, course.CourseName);
        }
        
        List<InstructorData> instructorData = new List<InstructorData>();

        foreach (var name in SelectedInstructors)
        {
            var _instructorID = name.Key;
            var _instructorName = name.Value;

            InstructorData _instructorData = new InstructorData()
            {
                InstructorID = _instructorID,
                InstructorName = _instructorName,
            };
            
            instructorData.Add(_instructorData);
        }
        
        string instructorJsonString = JsonSerializer.Serialize(dept);
        File.WriteAllText(instructorJsonPath, instructorJsonString);
        
        Console.WriteLine("Successfully feeded instructor details");
        Console.WriteLine("Verify Instructor Data");

        foreach (var name in SelectedInstructors)
        {
            Console.WriteLine($"Instructor ID : {name.Key} - Instructor Name : {name.Value}");
            Console.WriteLine($"Course ID : {name.Key} - Course Name : {selectedCourses[name.Key]}");
        }
        
    }
    
    
}
