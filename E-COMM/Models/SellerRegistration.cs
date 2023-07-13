using System.Data;

namespace E_COMM.Models
{
    public class SellerRegistration
    {
        public int id { get; set; } 
        public string name { get; set; }
        public string email { get; set; }
        public long number { get; set; }
        public string password { get; set; }
        public string conformpassword { get; set; }

    }
}
