//  Liskov Substitution Principle - as the system stands there is no need/insance where this applies, each class has only the methods that they require
namespace StudentV2
{
    public abstract class Student 
    {
        public string StudentID;
        public string Name;
        public double OutstandingFees;
        public string EnrollDate;

        public Student (string stID, string nm, double outFees,string enD ){
            StudentID = stID;
            Name = nm;
            OutstandingFees = outFees;
            EnrollDate = enD;

        }


        public string getStudentID()
        {
            return this.StudentID;
        }

        public void setStudentID(string StudentID)
        {
            this.StudentID = StudentID;
        }

        public string getName()
        {
            return this.Name;
        }

        public void setName(string Name)
        {
            this.Name = Name;
        }

        public double getOutstandingFees()
        {
            return this.OutstandingFees;
        }

        public void setOutstandingFees(double OutstandingFees)
        {
            this.OutstandingFees = OutstandingFees;
        }

        public string getEnrollDate()
        {
            return this.EnrollDate;
        }

        public void setEnrollDate(string EnrollDate)
        {
            this.EnrollDate = EnrollDate;
        }


        


    }
}