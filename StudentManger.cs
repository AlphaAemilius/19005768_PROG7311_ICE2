using System.Collections.Generic;
using System;

namespace StudentV2
{
    public sealed class StudentManger  // this deals with the source 
    {

     
     private StudentManger(){
        assignStudents();
     }   

     public static StudentManger instance = null;
     public static StudentManger Instance{
        get
        {
            if (instance == null){
                instance = new StudentManger();
            }
            return instance;
        }
    }
    public void assignStudents(){ //override 
        StudentList.Instance.lsStudents = TextFileManager.readF();
        Console.WriteLine("Students' data read successfully");
    }


    public void addStudent(FTStudent ft){ //override 
        StudentList.Instance.lsStudents.Add(ft);
        Console.WriteLine("Student successfully added");
    }
     
    public void addStudent(PTStudent pt){ //override 
        StudentList.Instance.lsStudents.Add(pt);
        Console.WriteLine("Student successfully added");
    }

    public List<Student> getStudents(){  //must not be with the list
          return StudentList.Instance.lsStudents;  
    }

    public void saveStudents(){
        TextFileManager.writeToF(getStudents());
    }


    }
}