using System.Text.Json;

public class Library
{
    // Array 1: General Engineering and C#
    public string[] array1 = {
        "C# 9.0 in a Nutshell: A Desktop Quick Reference - Joseph Albahari, Ben Albahari",
        "Pro C# 8 with .NET Core 3 - Andrew Troelsen, Philip Japikse",
        "Head First C# - Andrew Stellman, Jennifer Greene",
        "C# Programming Yellow Book - Rob Miles",
        "C# for Beginners - Nathan Rozentals",
        "Mastering C# and .NET Framework - Marino Posada",
        "C# 6 for Programmers - Paul Deitel, Harvey Deitel",
        "C# Programming for Absolute Beginners - Radek Vystavil",
        "C# Essentials - Ben Albahari, Joseph Albahari",
        "C# in Depth - Jon Skeet"
    };

// Array 2: Electrical Engineering and C#
    public string[] array2 = {
        "C# Programming for Electrical Engineers - Michael J. Pont",
        "The Art of Electronics - Paul Horowitz, Winfield Hill",
        "Introduction to Electric Circuits - Richard C. Dorf, James A. Svoboda",
        "C# for Electrical Engineers: With Applications in Control Systems - John R. H. Marsden",
        "Electrical Engineering: Principles and Applications - Allan R. Hambley",
        "C# Programming and the Internet of Things - Raj, A. G. Dinesh",
        "Digital Signal Processing: A Computer-Based Approach - Sanjit K. Mitra",
        "Fundamentals of Electric Circuits - Alexander S. Sadiku",
        "Power Electronics: Circuits, Devices, and Applications - Muhammad H. Rashid",
        "Control Systems Engineering - Norman S. Nise"
    };

    // Array 3: Mechanical Engineering and C#
    public string[] array3 = {
        "Mechanical Engineering Design - J.E. Shigley",
        "C# for Mechanical Engineers - Donald C. Sweeney",
        "Engineering Mechanics: Dynamics - J.L. Meriam, L.G. Kraige",
        "Fundamentals of Thermodynamics - Richard E. Sonntag, Claus Borgnakke",
        "Applied Fluid Mechanics - Robert L. Mott",
        "Mechanical Vibrations - Singiresu S. Rao",
        "Introduction to Heat Transfer - Frank P. Incropera, David P. DeWitt",
        "Materials Science and Engineering: An Introduction - William D. Callister",
        "Finite Element Analysis: Theory and Application with ANSYS - Saeed Moaveni",
        "Strength of Materials - Ferdinand L. Singer, Andrew Pytel"
    };

    // Array 4: C# in Engineering Simulations
    public string[] array4 = {
        "C# for Simulations in Engineering - Thomas W. Finnegan",
        "Finite Element Method in Engineering with C# - J. N. Reddy",
        "Introduction to MATLAB for Engineers and Scientists - R. C. Dorf, J. A. Svoboda",
        "C# for Numerical Methods and Computation - John C. Hull",
        "Engineering Applications of C# - Charles D. Denny",
        "Design and Simulation of Control Systems - C# Approach - John L. Williams",
        "C# for Signal Processing in Engineering - Jason D. Zhang",
        "Modeling and Simulation with C# - David H. Jackson",
        "C# in Structural Mechanics - Richard D. Kelkar",
        "Computational Fluid Dynamics with C# - S. R. Chakravarthy"
    };

    // Array 5: Electrical Circuit Design with C#
    public string[] array5 = {
        "Electric Circuits - James W. Nilsson, Susan A. Riedel",
        "Circuits, Signals, and Systems for Engineers - William McC. Siebert",
        "Basic Electric Circuit Analysis - J. David Irwin",
        "Applied Circuit Analysis - J. David Irwin",
        "Digital Electronics: Principles and Applications - John M. Yarbrough",
        "Power System Analysis - John J. Grainger, William D. Stevenson",
        "Fundamentals of Electric Circuits - Alexander S. Sadiku",
        "C# for Digital Circuits and Signal Processing - Mohamad Ali Hamade",
        "C# in Power Electronics: Circuits and Applications - Robert L. Steigerwald",
        "Introduction to Electric Circuits - Richard C. Dorf"
    };

    // Array 6: C# for Data Structures in Engineering
    public string[] array6 = {
        "Data Structures and Algorithms in C# - Michael McMillan",
        "C# Data Structures and Algorithms - Marcin Jamro",
        "Introduction to Algorithms - Thomas H. Cormen",
        "Algorithms in C# - Robert Sedgewick, Kevin Wayne",
        "C# Programming: Data Structures and Algorithms - S. K. Somani",
        "Design and Analysis of Algorithms - Anany Levitin",
        "C# for Object-Oriented Programming and Data Structures - Chris Sells",
        "Data Structures Using C# - Dr. A. R. T. Singh",
        "Data Structures with C# - David G. McDonald",
        "C# Programming and Data Structures - Frank M. Carrano"
    };

    // Array 7: C# in Control Systems Engineering
    public string[] array7 = {
        "Modern Control Engineering - Ogata Katsuhiko",
        "Digital Control Engineering - M. Gopal",
        "Feedback Control of Dynamic Systems - Gene F. Franklin",
        "Control Systems Engineering - Norman S. Nise",
        "C# for Control Systems Design - Niels Peter Reimann",
        "Applied Control Theory for Engineers - K. Ogata",
        "Introduction to Control Systems - Raymond T. Stefani",
        "Linear Control Systems - B. Kuo",
        "Discrete-Time Control Systems - Katsuhiko Ogata",
        "Advanced Control Engineering - Roland S. Wilson"
    };

    // Array 8: C# for Machine Learning in Engineering
    public string[] array8 = {
        "Machine Learning with C# - Dustin G. Jones",
        "Artificial Intelligence with C# - Raj",
        "Hands-On Machine Learning with C# - Dennis G. G. Liu",
        "C# for Data Science and Machine Learning - Jack H. Davis",
        "Machine Learning in C# - Alok S. Purohit",
        "Data Science with C# - Jonathan Hall",
        "Hands-On Deep Learning with C# - Jason Brownlee",
        "C# Machine Learning Projects - S. Shinde",
        "Introduction to Machine Learning with C# - Kevin A. Clark",
        "C# for Predictive Analytics in Engineering - Nicholas A. Branson"
    };

    // Array 9: C# for Robotics Engineering
    public string[] array9 = {
        "C# for Robotics Engineering - Matthew N. O'Keefe",
        "Introduction to Robotics: Mechanics and Control - John J. Craig",
        "Robotics: Control, Sensing, Vision, and Intelligence - Saeed B. Niku",
        "Robotics: Modelling, Planning, and Control - Bruno Siciliano",
        "Robotics: Fundamentals and Applications - John W. S. Liu",
        "Robot Programming: A Practical Guide to Behavior-Based Robotics - Joe Jones",
        "C# Programming for Robotics - Tim N. Hanrahan",
        "Mobile Robotics: Mathematics, Models, and Methods - Alonzo Kelly",
        "Robotics and Control - R.K. Gupta, S.K. Arora",
        "Control Systems for Robotics - Andrew H. Glinski"
    };

    // Array 10: C# for Mechanical Engineering Applications
    public string[] array10 = {
        "Mechanical Engineering Design - J.E. Shigley",
        "Applied Thermodynamics - Eastop and McConkey",
        "Fluid Mechanics - Frank M. White",
        "Strength of Materials - Ferdinand P. Beer, E. Russell Johnston",
        "Engineering Mechanics: Statics and Dynamics - J.L. Meriam, L.G. Kraige",
        "Introduction to Heat Transfer - Frank P. Incropera",
        "Machine Design: An Integrated Approach - Robert L. Norton",
        "Dynamics of Machinery - Ansel C. Ugural",
        "Mechanical Vibrations - Singiresu S. Rao",
        "Finite Element Analysis in Engineering Design - J.N. Reddy"
    };
    
    List<string> SelectedBooks = new List<string>();
    
    int LibraryFees { get; set; }
        
    public void getBooks()
    {
        Console.WriteLine("Welcome to Library ...");
        Console.WriteLine("Please Choose the Genre of Books");

        int res = 0;
         
        do
        {
            Console.WriteLine("Choose a Genre: (Press 1 - 10)");
            Console.WriteLine("1. Genral Engineering and C#");
            Console.WriteLine("2. Electrical Engineering");
            Console.WriteLine("3. Mechanical Engineering");
            Console.WriteLine("4. C# Depth");
            Console.WriteLine("5. Electrical Circuit Design");
            Console.WriteLine("6. DSA");
            Console.WriteLine("7. Control Systems");
            Console.WriteLine("8. Machine Learning");
            Console.WriteLine("9. Robotics Engineering");
            Console.WriteLine("10. Mechanical Applications");
            
            res = Convert.ToInt32(Console.ReadLine());

            if (res == 1)
            {
                foreach (string i in array1)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Press 1-10 to choose books");
                res = Convert.ToInt32(Console.ReadLine());
                SelectedBooks.Add(array1[res]);
            }
            else if (res == 2)
            {
                foreach (string i in array2)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Press 1-10 to choose books");
                res = Convert.ToInt32(Console.ReadLine());
                SelectedBooks.Add(array2[res]);
            }
            else if (res == 3)
            {
                foreach (string i in array3)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Press 1-10 to choose books");
                res = Convert.ToInt32(Console.ReadLine());
                SelectedBooks.Add(array3[res]);
            }
            else if (res == 4)
            {
                foreach (string i in array4)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Press 1-10 to choose books");
                res = Convert.ToInt32(Console.ReadLine());
                SelectedBooks.Add(array4[res]);
            }
            else if (res == 5)
            {
                foreach (string i in array5)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Press 1-10 to choose books");
                res = Convert.ToInt32(Console.ReadLine());
                SelectedBooks.Add(array5[res]);
            }
            else if (res == 6)
            {
                foreach (string i in array6)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Press 1-10 to choose books");
                res = Convert.ToInt32(Console.ReadLine());
                SelectedBooks.Add(array6[res]);
            }
            else if (res == 7)
            {
                foreach (string i in array7)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Press 1-10 to choose books");
                res = Convert.ToInt32(Console.ReadLine());
                SelectedBooks.Add(array7[res]);
            }
            else if (res == 8)
            {
                foreach (string i in array8)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Press 1-10 to choose books");
                res = Convert.ToInt32(Console.ReadLine());
                SelectedBooks.Add(array8[res]);
            }
            else if (res == 9)
            {
                foreach (string i in array9)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Press 1-10 to choose books");
                res = Convert.ToInt32(Console.ReadLine());
                SelectedBooks.Add(array9[res]);
            }
            else
            {
                foreach (string i in array10)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Press 1-10 to choose books");
                res = Convert.ToInt32(Console.ReadLine());
                SelectedBooks.Add(array10[res]);
            }
            
            Console.WriteLine("If selected Enough press 0");
        } while (res > 0);
        
        Console.WriteLine("The Books you selected were ");
        foreach (var item in SelectedBooks)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("A Common Library Fee will be issued that is 1000 ");
        LibraryFees = 1000;
        
        string FeeJsonPath = "/Users/mmohanraaji/Documents/E/C_S_ASSIGN/Day_1/Task_6/Task_6/Task_6/Data/FeeData.json";

        FeeData fee = new FeeData()
        {
            LibraryFee = LibraryFees,
        };
        string feeJsonString = JsonSerializer.Serialize(fee);
        File.WriteAllText(FeeJsonPath, feeJsonString);
        
    }
    
    

}