using System.ComponentModel;
using System.Drawing;
using static Assignment_opp_1.Program;

namespace Assignment_opp_1
{
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,

    }

    public enum seasons : int
    {
        Spring = 1,
        Summer = 2,
        Autumn = 3,
        Winter = 4

    }

    [Flags]
    public enum Permissions
    {
        Read =4,
        write =8,
        Delete =1 ,
        Execute =2
           
    }

    internal class Program
    {

     
      

        static void Main(string[] args)
        {
            #region Q1 : Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}


            #endregion

            #region Q2:Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            bool flag =true;

            //seasons result;
            //do
            //{
            //    Console.WriteLine("Enter your favourite Season : > ");
            //    flag = Enum.TryParse<seasons>(Console.ReadLine(), true,out  result);
            //} while (!flag);

            //switch (result)
            //{
            //    case (seasons) 1:
            //        Console.WriteLine("spring march to may");
            //        break;
            //    case (seasons) 2:
            //        Console.WriteLine("summer june to august");
            //        break;
            //    case (seasons)3:
            //        Console.WriteLine("autumn September to November");
            //        break;
            //    case (seasons)4:
            //        Console.WriteLine("winter December to February");
            //        break;
            //}


            #endregion

            #region Q3- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable


            //Person person = new Person();
            //person.per = Permissions.Read; // i want to add wrire permission

            //if ((person.per & Permissions.write) == Permissions.write) {
            //    Console.WriteLine($"You have the Permissions : {Permissions.write}");
            //}
            //else
            //{
            //    person.per = person.per ^ Permissions.write;
            //    Console.WriteLine($"Your permissions are :- {person.per}");
            //}


            #endregion

            #region Q4 Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.


            Colors color;
            do
            {
                Console.WriteLine("Enter A COLOR : > ");
                flag = Enum.TryParse<Colors>(Console.ReadLine(), true, out color);
            } while (!flag);

            if (color == Colors.Red || color == Colors.Green || color == Colors.Blue) {

                Console.WriteLine($"you enter a {color} : it is a primary color.");
            }
            else
            {

                Console.WriteLine($"you enter a {color} : it is not a primary color.");

            }



            #endregion



            #region Q5  Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.



            #endregion
        }
    }
}
