
using System.Collections.Specialized;
using System.Text.Json;
using College.DataClasses;

public class Department
{
    
    public string jsonFilePath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/CourseData.json";
    
    public string CourseNames = @"{
          ""CoursesAvailable"": {
            ""IT"": [""Introduction to Python Programming"", ""Web Development with HTML, CSS, and JavaScript"",
              ""Machine Learning Fundamentals"", ""Data Structures and Algorithms"", ""Building Mobile Apps with React Native"",
              ""Cybersecurity Essentials"", ""Cloud Computing with AWS"", ""Introduction to Data Science"", ""AI and Deep Learning"",
              ""Game Development with Unity"", ""Database Management with SQL"", ""Blockchain Technology and Applications"",
              ""Internet of Things (IoT) for Beginners"", ""Introduction to Big Data"", ""DevOps Essentials"",
              ""Software Testing and Quality Assurance"", ""Data Visualization with Tableau"", ""Augmented Reality (AR) Development"",
              ""Introduction to Virtualization and Docker"", ""Ethical Hacking and Penetration Testing""],
            ""EEE"": [""Advanced Power Systems Analysis"", ""Renewable Energy Systems"", ""Microelectronics and Semiconductor Devices"",
              ""Control Systems Engineering"", ""Electromagnetic Field Theory"", ""Digital Signal Processing"",
              ""Electrical Machines and Transformers"", ""Power Electronics and Drives"", ""Circuit Theory and Analysis"",
              ""Embedded Systems and IoT""],
            ""Mech"": [""Thermodynamics and Heat Transfer"", ""Fluid Mechanics and Dynamics"", ""Mechanical Design and CAD"",
              ""Manufacturing Processes and Automation"", ""Materials Science and Engineering""]
          }
        }
        ";

   // public List<string> DeptCourses = new List<string>();
      public Dictionary<int, string> Dept_Courses = new Dictionary<int, string>(); 
    public void DeptEnroll()
    {
        Console.WriteLine("DECIDED?");
        Console.WriteLine("Choose your Department Wisely");
        Console.WriteLine("Press 1 to enroll for IT Department ");
        Console.WriteLine("Press 2 to enroll for EEE Department ");
        Console.WriteLine("Press 3 to enroll for Mech Department ");

        int res = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Congrats");

        var courseData = JsonSerializer.Deserialize<CourseData>(CourseNames);

        string deptJsonPath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/DepartmentData.json";
       // string jsonString = JsonSerializer.Serialize(DepartmentData);
        
        
        if (res == 1)
        {
            int count = 1;
            Console.WriteLine("You are now enrolled in IT");
            foreach (var course in courseData.CoursesAvailable["IT"])
            {
                Dept_Courses.Add(count, course);
                count++;
            }
            
            var _deptID = res;
            var _deptName = "IT";

            DepartmentData deptData = new DepartmentData()
            {
                DeptNumber = _deptID,
                DepartmentName = _deptName,
            };
            string jsonString = JsonSerializer.Serialize(deptData);
            File.WriteAllText(deptJsonPath, jsonString);
        }
        else if (res == 2)
        {
                    
            Console.WriteLine("You are enrolled in EEE");
            int count = 1;
            foreach (var course in courseData.CoursesAvailable["EEE"])
            {
                Dept_Courses.Add(count, course);
                count++;
            }
            
            var _deptID = res;
            var _deptName = "IT";

            DepartmentData deptData = new DepartmentData()
            {
                DeptNumber = _deptID,
                DepartmentName = _deptName,
            };
            string jsonString = JsonSerializer.Serialize(deptData);
            File.WriteAllText(deptJsonPath, jsonString);
        }
        else if (res == 3)
        {
            Console.WriteLine("You are enrolled in Mech");
            int count = 1;
            foreach (var course in courseData.CoursesAvailable["Mech"])
            {
                Dept_Courses.Add(count, course);
                count++;
            }
            
            var _deptID = res;
            var _deptName = "IT";

            DepartmentData deptData = new DepartmentData()
            {
                DeptNumber = _deptID,
                DepartmentName = _deptName,
            };
            string jsonString = JsonSerializer.Serialize(deptData);
            File.WriteAllText(deptJsonPath, jsonString);
            
        }
        else
        {
            Console.WriteLine("Please choose one of the following options");
        }
    }
    public void DeptSelect(){
        
        
        Console.WriteLine("Welcome to the College");
        Console.WriteLine("Choose the Department of your choise");
        Console.WriteLine("Press 1 to view the courses offered by each department ");

        Console.WriteLine("Choose 1 to view IT Courses , Choose 2 to view EEE Courses , Choose 3 to view Mech Courses ");
        int res = Convert.ToInt32(Console.ReadLine());
        if (res == 1)
        {
            ViewCourses(1);
        }
        else if (res == 2)
        {
            ViewCourses(2);
        }
        else if (res == 3)
        {
            ViewCourses(3);
        }
        else
        {
            Console.WriteLine("Please choose one of the following options");
        }
        
    }

    public void ViewCourses(int option)
    {
           
        
        //string jsonString = File.ReadAllText(jsonFilePath);
        //CourseData cd = JsonSerializer.Deserialize<CourseData>(jsonString);
        
        var courseData = JsonSerializer.Deserialize<CourseData>(CourseNames);

        int count = 1;
        if (option == 1)
        {
            Console.WriteLine("These are the IT Courses available");
            foreach (var course in courseData.CoursesAvailable["IT"])
            {
                Console.WriteLine($"{count} : {course} ,");
                count++;
            }
        }
        else if (option == 2)
        {
            Console.WriteLine("These are the EEE Courses available");
            foreach (var course in courseData.CoursesAvailable["EEE"])
            {
                Console.WriteLine($"{count} : {course} ,");
                count++;            
            }
        }
        else if (option == 3)
        {
            Console.WriteLine("These are the Mech Courses available");
            foreach (var course in courseData.CoursesAvailable["Mech"])
            {
                Console.WriteLine($"{count} : {course} ,");
                count++;            
            }
        }
        else
        {
            Console.WriteLine("Please choose a valid option");
        }
        
        Console.WriteLine("Press 1 to View the courses again or Press 0 to continue to enrollment ");
        int newOption = Convert.ToInt32(Console.ReadLine());

        if (newOption == 1)
        {
            DeptSelect();
        }
        else
        {
            Console.WriteLine("Redirecting to Enrollment");
            DeptEnroll();
        }
        
    }
}