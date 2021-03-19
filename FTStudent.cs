using System.Collections.Generic;

namespace StudentV2
{
    public class FTStudent : Student 
    {
        public List<Attendance> lsAttendance;  //S - fuctionality is seperate (attendace object can extend other classes - "O")

        public FTStudent(string stID, string stName, double oF, string enrollD):base(stID, stName, oF, enrollD){
            lsAttendance = new List<Attendance>();
        }



        public override string ToString(){
            return StudentID + " - " + Name + " - R" + OutstandingFees + " - " + EnrollDate + " - FT"; 
        }
    }
}