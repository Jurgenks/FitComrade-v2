using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitComradeV2.Models
{
    public class Profile
    {
        public int ProfileID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int CustomerID { get; set; }

        public void Login(string usr, string pass)
        {
            var data = new Profile();
            if(usr.Equals(data.UserName) && pass.Equals(data.Password))
            {

            }
        }
    }
}
