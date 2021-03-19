using System.Collections.Generic;

using System;

namespace StudentV2
{
    public sealed class StudentList  //this is just the source 
    {
        public List<Student> lsStudents = new List<Student>();   //potential db connection

        private StudentList()
        {
        
        }

        public static StudentList instance = null;
        public static StudentList Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentList();
                }
                return instance;
            }
        }
        




    }

}