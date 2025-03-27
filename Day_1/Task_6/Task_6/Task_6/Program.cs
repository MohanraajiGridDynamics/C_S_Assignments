// See https://aka.ms/new-console-template for more information

using System;

namespace College
{
    class Program
    {
        
        public static void Main()
        {
            Student student = new Student();
            student.setStudentDetails();
            student.getStudentDetails();
            
            
           
           Department department = new Department();
           department.DeptSelect();

           Courses courses = new Courses();
           courses.DeptSelect();
           //courses.viewCourses();
           courses.addCourse();

            Instructor instructor = new Instructor();
            instructor.getInstructorDetails(); 
           
           Hostel hostel = new Hostel();
           hostel.SetHostelDetails();
           hostel.GetHostelDetails();
           int hostelID = hostel.RoomID;
           int hostelFee = hostel.TotalPrice;
           
           Library library = new Library();
           library.getBooks();
           
            Examination examination = new Examination();
           examination.setExamDetails();


           FeePayment payment = new FeePayment();
           payment.getFeeDetails();

        }
    }
}
