using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finale.UI.Managers
{
    public static class AuthManager
    {
        static string[] cookie;

        public static int CurrentUserID { get {

                cookie = cookie ?? HttpContext.Current.User.Identity.Name.Split(',');

                return int.Parse(cookie[2]);
            } }

        public static string CurrentUserName { get
            {
                cookie = cookie ?? HttpContext.Current.User.Identity.Name.Split(',');

                return (cookie[0]);
            } }

        public static void Null()
        {
            cookie = null;
        }
    }
}