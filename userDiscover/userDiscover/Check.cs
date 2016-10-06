using System;
using System.Collections.Generic;
using System.Text;
using System.DirectoryServices;

namespace userDiscover
{
    class check
    {
        
        /*Constructor*/

        public check()
    {
    }

        /*Methods*/
        
        public bool Authenticate(string userName,
    string password, string domain)
        {
            bool authentic = false;
            try
            {
                DirectoryEntry ent = new DirectoryEntry("LDAP://" + domain,
                    userName, password);
                object nativeObject = ent.NativeObject;
                authentic = true;
            }
            catch (DirectoryServicesCOMException) { authentic = false; }
            catch (System.Runtime.InteropServices.COMException) { authentic = false; }
            return authentic;
        }

        public string InputNullCheck(string usr, string pwd, string dom)
        {
            String e = "";

            if (usr.Equals(""))
            {
                e = e + " username,";
            }

            if (pwd.Equals(""))
            {
                e = e + " password,";
            }

            if (dom.Equals(""))
            {
                e = e + " domain,";
            }

            String error = "no" + e + " entered, check cannot proceed. Please enter value";

            if (e.Equals(""))
            {
                error = "noError";
            }

            return error;
        }


    }
}
