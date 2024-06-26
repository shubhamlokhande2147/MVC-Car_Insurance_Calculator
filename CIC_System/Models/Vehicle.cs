
using System.Collections.Generic;

namespace Models
{
    public class Vehicle
    {
       public Vehicle()
        {

        }

        public Vehicle(int vid, string vno, double vprice, string vcompany, string date_of_Purchase, string engine_no, string fuel_Type, int userId)
        {
            Vid = vid;
            Vno = vno;
            Vprice = vprice;
            Vcompany = vcompany;
            Date_of_Purchase = date_of_Purchase;
            Engine_no = engine_no;
            Fuel_Type = fuel_Type;
            UserId = userId;
        }


        public int Vid { get; set; }
        public string Vno { get; set; }
        public double Vprice { get; set; }
        public string Vcompany { get; set; }
        public string Date_of_Purchase { get; set; }
        public string Engine_no { get; set; }
        public string Fuel_Type { get; set; }

        // Foreign key
        public int UserId { get; set; }
        public User_Registration User { get; set; }
    }
}
