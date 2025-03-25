// See https://aka.ms/new-console-template for more information

using System;

namespace College
{
    class Program
    {
        
        public static void Main()
        {
            /*Student student = new Student();
            student.setStudentDetails();
            student.getStudentDetails();*/
            
            //Course course = new Course();
            //course.viewCourses();
            //course.addCourse();
            
           /* ITCourse it = new ITCourse();
            EEECourse eee = new EEECourse();
            MechCourse mech = new MechCourse();

           */
           
           /* Department department = new Department();
           department.DeptSelect();*/

           Courses courses = new Courses();
           courses.DeptSelect();
           //courses.viewCourses();
           courses.addCourse();



        }
    }
}
