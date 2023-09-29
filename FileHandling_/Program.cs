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

        }
        else
        {
            Console.WriteLine("It does not exist.");
        }

        //Short If statement for if the directory exists 
        Console.WriteLine(Directory.Exists(path) ? "dIRECTORY EXISTS" : "Does not exist");

        var file = $"{path}/file.txt"; //interpolation 
        //File.Create(file) ;
        string input = "Hello";

        File.WriteAllText(path, input); //single string

        File.WriteAllText(path, string.Empty); 
        //Clear the contents of a file


        //another way of doing the same 
        var docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        var dirName = $"{docPath}/TEST";

        // GET INFO ABOUT DIRECTORIES

        DirectoryInfo di = Directory.CreateDirectory(dirName);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Full name:{di.Name}, the directory has been created at {di.CreationTime}, {di.Parent}");
        Console.ResetColor();


        //simple reading and writing ON/FROM Files 


        string[] names = { "Monica", "Chandler", "Rachel", "Peter" };


        File.WriteAllLines(file, names);
        File.AppendAllLines(file, names); //add info to the file 

        //reading from the file in realtime 
        foreach (string item in File.ReadLines(file))

        {
            Console.WriteLine($"Data is:{item}");
        }

        //Search for certain files on PC
        string[] fileDir = Directory.GetDirectories(docPath);

        foreach (var item in fileDir)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(item);
            Console.ResetColor();
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


//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
////using FreeProject2023;
//using Hashtables_;

//public class Program
//{
//    public static void Main(string[] args)
//    {

//        Employee test = new Employee(1001, "Jack", "Silverstone");
//        Employee test2 = new Employee(1002, "Jack2", "Silverstone");
//        Employee test3 = new Employee(1003, "Jack3", "Silverstone");
//        Employee test4 = new Employee(1004, "Jack4", "Silverstone");
//        Employee test5 = new Employee(1005, "Jack5", "Silverstone");

//        test.PrintInfo();

//        Employee richard = new Employee(1005, "Richard", "Bradford");


//        //create a hashtable 
//        Hashtable empTable = new Hashtable();
//        empTable.Add(test.EmployeeID, test);
//        empTable.Add(test2.EmployeeID, test2);
//        empTable.Add(test3.EmployeeID, test3);
//        empTable.Add(test4.EmployeeID, test4);
//        empTable.Add(richard.EmployeeID, richard);

//        Employee empTest = (Employee)empTable[test.EmployeeID]; //cast it

//        empTest.PrintInfo();

//        foreach (Employee e in empTable.Values)
//        {
//            e.PrintInfo();
//        }

//        //foreach (DictionaryEntry e in empTable)
//        //{

//        //    Employee tempEmp = (Employee)e.Value;
//        //    tempEmp.PrintInfo();
//        //}

//        foreach (var e in empTable.Keys) //print only the primary keys 
//        {
//            Console.ForegroundColor = ConsoleColor.DarkCyan;
//            Console.WriteLine(e);
//            Console.ResetColor();
//        }

//        //here we guys are going to talk a bit about validation check 
//        Console.WriteLine("Please input an employee ID:");
//        string inputEmpID = Console.ReadLine();

//        int validEmpId;

//        int.TryParse(inputEmpID, out validEmpId);

//        while ((validEmpId == 0) || (!empTable.ContainsKey(validEmpId)))
//        {
//            Console.WriteLine("Please enter a vaild ID!");
//            inputEmpID = Console.ReadLine();
//            int.TryParse(inputEmpID, out validEmpId);

//        }



//        Employee storedEmp = (Employee)empTable[validEmpId];
//        storedEmp.PrintInfo(); //we are getting this exception because right now
//        //we've got a string and we need an integer 



//    }
//}