using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FitComradeV2.Models
{
    public class SessionUser
    {
        public string SessionUserID { get; set; }
        public int ProfileID { get; set; }
        public string CartID { get; set; }

        
        
        public SessionUser GetSession(ISession session, SessionUser sessionUser)
        {
            
            if(session.Keys.Contains("sessionUserID"))
            {
                sessionUser.SessionUserID = session.GetString("sessionUserID");
            }
            else
            {
                session.SetString("sessionUserID", session.Id);
                sessionUser.SessionUserID = session.GetString("sessionUserID");
            }
            if (session.Keys.Contains("ProfileID") && session.Keys.Contains("CartID"))
            {
                sessionUser.ProfileID = session.GetInt32("profileID").Value;
                sessionUser.CartID = session.GetString("cartID");
            }            
            return sessionUser;
        }


    }
}
