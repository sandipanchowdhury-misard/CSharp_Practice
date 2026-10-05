using System;
using System.Security.AccessControl;

class FileDetails
{
    string fileName = "My_Resume.docx";
    string fileLocations = @"D:\Students\Resumes" ;
    string fileSize =" 208 KB";
    string createdDate = "Mar - 01 - 2026";

    DateTime createDate = DateTime.Now; 


    void showMessage(string fileName, string fileLoction)
    {
        Console.WriteLine($"Hello, file name is {fileName} and flie location is {fileLoction}");
    }


    void ShowDetailsMessage(FileDetails file)
    {
        Console.WriteLine($"Hello, File name {file.fileName} ");
        Console.WriteLine($"Hello, File name {file.fileSize} ");
        Console.WriteLine($"Hello, File name {file.createDate} ");
        Console.WriteLine($"Hello, File name {file.fileLocations} ");
    }

    static void staticShowDetailsMessage(FileDetails file)
    {
        // call the instance method from a static context
        file.ShowDetailsMessage(file);
    }


    static void Main()
    {
        FileDetails fileDetails = new FileDetails();

        Console.WriteLine(fileDetails.fileName);

        Console.WriteLine(fileDetails.fileLocations);

        Console.WriteLine(fileDetails.fileSize);

        Console.WriteLine(fileDetails.createdDate);

        fileDetails.showMessage(fileDetails.fileName, fileDetails.fileLocations);

        FileDetails fileDetails1 = new FileDetails();

        fileDetails1.fileName = "Employee_Salary.pdf";
        fileDetails1.fileLocations = @"D:\Documents";

        fileDetails1.showMessage(fileDetails1.fileName, fileDetails1.fileLocations);

        
        
        fileDetails1.ShowDetailsMessage(fileDetails1);

        staticShowDetailsMessage(fileDetails1);

    }
}

