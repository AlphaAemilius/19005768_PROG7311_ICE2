using System;

namespace StudentV2
{
    public class Attendance
    {
        public string Date;
        public string Module;
        public string Status;

        public Attendance(string date, string module, string status){
            Date = date;
            Module= module;
            Status = status;
        }
    }
}