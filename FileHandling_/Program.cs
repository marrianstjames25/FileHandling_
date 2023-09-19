using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections;



class Test
{
    public static void Main()
    {

        //Get access to a directory

        string path = @"C:\Users\m.yovchevski\Desktop\Section12b1";

        DirectoryInfo currDir = new DirectoryInfo(@"C:\Users\m.yovchevski\Desktop\Section12b1");

        //Create a new directory 

       currDir.Create();

        if (Directory.Exists(path))
        {
            Console.WriteLine("Directory exists!");

        } else {
            Console.WriteLine("It does not exist.");
        }

        //Short If statement for if the directory exists 
        Console.WriteLine(Directory.Exists(path)?"dIRECTORY EXISTS":"Does not exist");

        var file = $"{path}/file.txt"; //interpolation 
        //File.Create(file) ;



        //another way of doing the same 
        var docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        var dirName = $"{docPath}/TEST";

        // GET INFO ABOUT DIRECTORIES

        DirectoryInfo di = Directory.CreateDirectory(dirName) ;

        Console.ForegroundColor = ConsoleColor.Blue;  
        Console.WriteLine($"Full name:{di.Name}, the directory has been created at {di.CreationTime}");
        Console.ResetColor();


        //simple reading and writing on/from files 


        string[] names = { "Monica", "Chandler", "Rachel" };

        File.WriteAllLines(file, names) ;


        foreach ( string item in File.ReadLines(file) ) 
        
        {
            Console.WriteLine($"Data is:{item}");
        }


    }

}
