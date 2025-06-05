//4 th class
using System;
using System.Globalization;
using System.IO.Compression;

class Test
{
    public static void Main(string[] args)
    {
        // Console.WriteLine(123456);


        // /*
        // \n : for new line
        // \t : for tab 
        // \" : to print "
        // \' : to print '
        // \\ : to print \

        // */
        // // type casting

        // string input = "10";
        // bool isSucess = int.TryParse(input, out int result);
        // Console.WriteLine($"is it Sucessfull:{isSucess}");
        // Console.WriteLine($"number2 = {result}");
        // Console.ReadKey();

        // string? studentName = Console.ReadLine();
        // Console.WriteLine("student Name: " + studentName);



        string? studentName;
        int studentAge;
        Double gpa;


        Console.Write($"enter your Name: ");
        studentName = Console.ReadLine();

        Console.Write($"Enter your age: ");
        studentAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter Your Gpa");
        gpa = Double.Parse(Console.ReadLine());

        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Age: " + studentAge);
      
        
     }
}