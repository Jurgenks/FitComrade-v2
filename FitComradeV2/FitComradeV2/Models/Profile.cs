using Microsoft.AspNetCore.Http;
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

        
        public Profile Login(ISession session, Profile profile)
        {
            var db = new Data.FitComradeV2Context();
            var login = db.Profiles.Where(s => s.UserName.Equals(profile.UserName) && s.Password.Equals(profile.Password));
            
            if(login.Count() > 1)
            {                                
                session.SetString("UserName", profile.UserName);                
                if(session.Keys.Contains("CustomerID"))
                {
                   profile.CustomerID = session.GetInt32("CustomerID").Value;
                }
                return profile;
            }
            else
            {
                return profile;
            }
        }
    }
}
