using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserApp.Domain;

namespace UserApp
{
    public static class SessionManager
    {

        public static User User
        {
            get { return HttpContext.Current.ApplicationInstance.Session["User"] as User; }

            set { HttpContext.Current.ApplicationInstance.Session["User"] = value; }
        }
    }
}