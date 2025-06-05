//4 th class
using System;
using System.Globalization;
using System.IO.Compression;

class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine(123456);


        // /*
        // \n : for new line
        // \t : for tab 
        // \" : to print "
        // \' : to print '
        // \\ : to print \

        // */
        // // variable amd data type 8th video

        string input = "10";
        bool isSucess = int.TryParse(input, out int result);
        Console.WriteLine($"is it Sucessfull:{isSucess}");
        Console.WriteLine($"number2 = {result}");
        Console.ReadKey();
     }
}