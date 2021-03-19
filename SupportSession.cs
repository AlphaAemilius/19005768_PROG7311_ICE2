namespace StudentV2
{
    public class SupportSession // S- for the single responsibility
    {
        public string StudentID;
        public string Date;
        public string Comments;
        public string Module;

        public SupportSession(string stID, string date, string comm,string mod ){
            StudentID = stID;
            Date = date;
            Comments = comm;
            Module = mod;
        }


        public string toString(){
            return Module + " - " + Date + " - '" + Comments + "'"; 
        }

    }
}