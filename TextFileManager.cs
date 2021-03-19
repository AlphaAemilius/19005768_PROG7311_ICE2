using System.Collections.Generic;
using System;
using System.IO;

namespace StudentV2
{
    public static class TextFileManager
    {
        public static List<Student> readF()
        {
            List<Student> lsTemp = new List<Student>();
            string sLine = "";
            try // when we are reading the students
            {

                using (StreamReader sw1 = new StreamReader("Students.txt")) // using opens and closes file automatically 
                {
                    while ((sLine = sw1.ReadLine()) != null)
                    {
                        lsTemp.Add(ToStudent(sLine)); //gets text string converts it and adds it to the list
                    }

                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found. Creating file");
                StreamWriter sw = new StreamWriter("Students.txt");
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Menu names text reading error " + ex.ToString());

            }

            return lsTemp;

        }
        public static void writeToF( List<Student> lsTemp) //updates text file
        {
            try
            {
                using (StreamWriter sw1 = new StreamWriter("Students.txt")) // using opens and closes file automatically 
                {

                    foreach (Student s in lsTemp)
                    {
                        sw1.WriteLine(ToFileString(s));
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public static Student ToStudent(string txt)
        {  //converts txt string to studentObject
            string[] lineParts = txt.Split(',');
            if (lineParts[0].Equals("0"))
            {
                PTStudent pt = new PTStudent(lineParts[1], lineParts[2], Double.Parse(lineParts[3]), lineParts[4]);
                return pt;
            }
            else
            {
                FTStudent ft = new FTStudent(lineParts[1], lineParts[2], Double.Parse(lineParts[3]), lineParts[4]);
                return ft;
            }
        }
        public static string ToFileString(Student st)
        {  //converts student to delimeted string
            string line = "";
            if (st.GetType() == typeof(PTStudent))
            {
                PTStudent tempPTS = (PTStudent) st;
                line = "0," + tempPTS.StudentID + "," + tempPTS.Name + "," + tempPTS.OutstandingFees + "," + tempPTS.EnrollDate; 
            } else{
                FTStudent tempFTS = (FTStudent) st;
                line = "1," + tempFTS.StudentID + "," + tempFTS.Name + "," + tempFTS.OutstandingFees + "," + tempFTS.EnrollDate; 
            }
            return line;
        }

    }

}
