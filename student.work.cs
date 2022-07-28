//This is student class
using System;
namespace Program.CS
{
     public class student
    {
              public string  Id {get; set; } 
          public string Name{get ; set ;}
          public string FatherName {get ; set ;}
          public int RollNumber {get ; set ;}
          private  int samester {get ; set ;}

        public void TakeExam(student abc)
    {
        Console.WriteLine(abc.Name+"The student can take exam");

    }
    public void TakeClass()
    {
        Console.WriteLine("The student can take class");
    }
   
    }
}
//============================================
//Program.cs file
using System;

namespace Program.CS
{
     public class Program
    {
        static void Main()
        {
            //This is Object of Seemab
            student Seemab = new student();
            Seemab.Id = "54d56";
            Seemab.Name = "Seemab Altaf";
            Seemab.FatherName = "Muhammad Altaf";
            Seemab.RollNumber = 35;
            //This is Object of Asher
            student Ashar = new student();
            Ashar.Id = "54d56";
            Ashar.Name = " Ashar Altaf";
            Ashar.FatherName = "Muhammad Husnain ";
            Ashar.RollNumber = 5;

            Console.WriteLine("The roll no of "+Seemab.Name+" is "+Seemab.RollNumber );
            Console.WriteLine("The roll no of " + Ashar.Name + " is " + Ashar.RollNumber);
            
            Seemab.TakeExam(Seemab);

            Console.ReadLine();
        }
    }
}
