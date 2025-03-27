using System.Text.Json;
using System.Text.Json.Serialization;

namespace College;

public class Examination
{

        public Dictionary<string, string> ExamCourses = new Dictionary<string, string>();
       // public List<string> ExamDates = new List<string>();
        public string ExamTime { get; set; }
        public int ExamFee { get; set; }
     
          public string jsonPath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/CourseData.json";

            public void setExamDetails()
            {
                string jsonString = File.ReadAllText(jsonPath);
                List<CourseData> courses = JsonSerializer.Deserialize<List<CourseData>>(jsonString);
                
                
                Console.WriteLine("The Courses you are enrolled in were ..");
                int i = 0;
                //string todayDate = DateTime.Today.ToString("dd/mm/yyyy");
                
                DateTime today = DateTime.Now;
                
                ExamTime = "01.00PM";
                foreach (var course in courses)
                {
                    DateTime future = today.AddDays(i);
                    string formattedDate = future.ToString("dd/mm/yyyy");
                    
                    //Console.WriteLine($"Course Name : {course.CourseName}");
                    
                    ExamCourses.Add(course.CourseName, formattedDate);
                    Console.WriteLine("Course Name: " + course.CourseName);
                    Console.WriteLine("Exam scheduled at : " + formattedDate);
                    Console.WriteLine("Exam Time is : " + ExamTime);

                    i++;
                }

                
                int no_of_Courses = ExamCourses.Count;
                
                Console.WriteLine("Course fee will be 500 per course");
                Console.WriteLine("No of Courses: " + no_of_Courses);
                
                int courseFee = (no_of_Courses) * 500;
                Console.WriteLine("Course Fee will be " + courseFee);

                Console.WriteLine("Lab Fee : 800 ");
                Console.WriteLine("Miscellaneous Fees : 2000 ");
                
                int labFee = 800;
                int MiscellaneousFees = 2000;
                
                ExamFee = courseFee + labFee + MiscellaneousFees;
                Console.WriteLine("The Total Exam fee is : "+ExamFee);


                string FeeJsonPath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/FeeData.json";

                FeeData fee = new FeeData()
                {
                    ExamFee = ExamFee,
                };
                string feeJsonString = JsonSerializer.Serialize(fee);
                File.WriteAllText(FeeJsonPath, feeJsonString);
                
            }
            
}

