using System.Collections.Generic;
using System;

namespace StudentV2
{
    public class PTStudent : Student
    {
        public List<SupportSession> lsSSessions;

        public PTStudent(string stID, string stName, double oF, string enrollD):base(stID, stName, oF, enrollD){
            lsSSessions = new List<SupportSession>();
        }


        public override string ToString(){
            return StudentID + " - " + Name + " - R" + OutstandingFees + " - " + EnrollDate + " - PT"; 
        }

    }
}