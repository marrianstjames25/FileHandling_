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
        Console.WriteLine($"Full name:{di.Name}, the directory has been created at {di.CreationTime}, {di.Parent}");
        Console.ResetColor();


        //simple reading and writing ON/FROM Files 


        string[] names = { "Monica", "Chandler", "Rachel","Peter" };


        File.WriteAllLines(file, names) ;
        File.AppendAllLines(file, names) ; //add info to the file 

        //reading from the file in realtime 
        foreach ( string item in File.ReadLines(file) ) 
        
        {
            Console.WriteLine($"Data is:{item}");
        }

        //Search for certain files on PC
        string[] fileDir = Directory.GetDirectories(docPath);

        foreach( var item in fileDir )
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(item);
            Console.ResetColor ();
        }

        //Specific option to search

        DirectoryInfo myDataDir = new DirectoryInfo(docPath);

        //initialize an array of type File Info so we can store the information about the files and then go through them 
        FileInfo[] txtFiles = myDataDir.GetFiles("*.jpg", SearchOption.AllDirectories);

        //Print the actual files from the PC
        foreach (var j in txtFiles)
        {
            Console.WriteLine(j.Name); //gives the name of the file 
            Console.WriteLine(j.Length); // gives he length of the file in bytes 
        }
    }

}
