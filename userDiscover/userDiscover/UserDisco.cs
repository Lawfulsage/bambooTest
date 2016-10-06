using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices;
using System.Collections;
using System.Security.Principal;
using Microsoft.Win32;
using System.Security.AccessControl;
using System.IO;
using System.Data.SqlClient;

namespace userDiscover
{
    class UserDisco
    {

        /*Constructor*/

        public UserDisco()
        {
        }

        /*Methods*/

        public string AllAD(string d, string u,string p)
        {
            string answer = "";

            DirectoryEntry ent = new DirectoryEntry("LDAP://" + d, u, p);

            DirectorySearcher searcher = new DirectorySearcher(ent);

            SearchResult sres = searcher.FindOne();

            if (sres != null)
            {

                System.Text.StringBuilder strbui = new System.Text.StringBuilder();

                foreach (string var in sres.Properties.PropertyNames)

                    strbui.AppendLine(string.Format("{0} : {1}", var, sres.Properties[var][0].ToString()));

                answer = strbui.ToString();
            }
            else
            {
                answer = "No results found for this user";
            }

            return answer;

        }

        public string ADGroupMembership(string d, string u, string p)
        
        {
            String answer = "";
            DirectoryEntry ent = new DirectoryEntry("LDAP://" + d, u, p);

            DirectorySearcher searcher = new DirectorySearcher(ent);

            searcher.Filter = "samaccountname=" + u;
            searcher.PropertiesToLoad.Add("memberof");
            SearchResult sres = searcher.FindOne();

            System.Text.StringBuilder strbui = new System.Text.StringBuilder();

            if (sres != null)
            {

                foreach (string var in sres.Properties.PropertyNames)
                {

                    for (int i = 0; i < sres.Properties[var].Count; i++)

                        strbui.AppendLine(string.Format("{0}-{1} : {2}", var, i, sres.Properties[var][i].ToString()));

                }

                answer = strbui.ToString();
            }
            else
            {
                answer = "no group membership found";
            }

            return answer;

        }

        public string LocMachineCurrentuser()
        {
            
            WindowsIdentity ident = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(ident);
            SecurityIdentifier sid = new SecurityIdentifier(WellKnownSidType.BuiltinAdministratorsSid, null);
            string output = "";
            output += "Administrator sid: " + principal.IsInRole(sid);
            output += "\nAdministrator: " + principal.IsInRole(WindowsBuiltInRole.Administrator);
            output += "\nPowerUser: " + principal.IsInRole(WindowsBuiltInRole.PowerUser);
            output += "\nUser: " + principal.IsInRole(WindowsBuiltInRole.User);
            output += "\nAccountOperator: " + principal.IsInRole(WindowsBuiltInRole.AccountOperator);
            output += "\nBackupOperator: " + principal.IsInRole(WindowsBuiltInRole.BackupOperator);
            output += "\nGuest: " + principal.IsInRole(WindowsBuiltInRole.Guest);
            output += "\nPrintOperator: " + principal.IsInRole(WindowsBuiltInRole.PrintOperator);
            output += "\nReplicator: " + principal.IsInRole(WindowsBuiltInRole.Replicator);
            output += "\nSystemOperator: " + principal.IsInRole(WindowsBuiltInRole.SystemOperator);

            return output;

        }

        public string LocMachineNamedUser(string upn)
        {

            WindowsIdentity ident = new WindowsIdentity(upn);
            WindowsPrincipal principal = new WindowsPrincipal(ident);
            SecurityIdentifier sid = new SecurityIdentifier(WellKnownSidType.BuiltinAdministratorsSid, null);
            string output = "";
            output += "Administrator sid: " + principal.IsInRole(sid);
            output += "\nAdministrator: " + principal.IsInRole(WindowsBuiltInRole.Administrator);
            output += "\nPowerUser: " + principal.IsInRole(WindowsBuiltInRole.PowerUser);
            output += "\nUser: " + principal.IsInRole(WindowsBuiltInRole.User);
            output += "\nAccountOperator: " + principal.IsInRole(WindowsBuiltInRole.AccountOperator);
            output += "\nBackupOperator: " + principal.IsInRole(WindowsBuiltInRole.BackupOperator);
            output += "\nGuest: " + principal.IsInRole(WindowsBuiltInRole.Guest);
            output += "\nPrintOperator: " + principal.IsInRole(WindowsBuiltInRole.PrintOperator);
            output += "\nReplicator: " + principal.IsInRole(WindowsBuiltInRole.Replicator);
            output += "\nSystemOperator: " + principal.IsInRole(WindowsBuiltInRole.SystemOperator);

            return output;
        }

        public string ADCanDelegate(string domain)
        {
            String answer = "";
        try
            {
                DirectoryEntry ent = new DirectoryEntry("LDAP://" + domain);

                DirectorySearcher searcher = new DirectorySearcher(ent, "(objectCategory=Computer)");

                searcher.PropertiesToLoad.Add("samAccountName");
                searcher.PropertiesToLoad.Add("userAccountControl");

                SearchResultCollection sres = searcher.FindAll();
                String outp = "";
                String outp2 = "";
                int NoNotADelegator = 0;

                if (sres != null)
                {

                    foreach (SearchResult computeracc in sres)
                    {

                        DirectoryEntry comp = computeracc.GetDirectoryEntry();
                        int userAccountControlFlags = (int)comp.Properties["userAccountControl"].Value;
                        String ComputerAccountName = (String)comp.Properties["samAccountName"].Value;

                        if (userAccountControlFlags >= 524288 && userAccountControlFlags <= 998395)
                        {
                            outp = outp + ComputerAccountName + " TRUSTED_FOR_DELEGATION " + userAccountControlFlags + " \n";
                        }
                        else if (userAccountControlFlags >= 16777216)
                        {
                            outp = outp + ComputerAccountName + " TRUSTED_TO_AUTH_FOR_DELEGATION " + userAccountControlFlags + " \n";
                        }
                        else
                        {
                            NoNotADelegator++;
                        }
                    }
                }
                else
                {

                    answer = "Not Found";
                }


                DirectorySearcher searcher2 = new DirectorySearcher(ent, "(objectClass=User)");

                searcher2.PropertiesToLoad.Add("samAccountName");
                searcher2.PropertiesToLoad.Add("userAccountControl");

                SearchResultCollection sres2 = searcher2.FindAll();

                if (sres2 != null)
                {

                    foreach (SearchResult computeracc2 in sres2)
                    {

                        DirectoryEntry comp2 = computeracc2.GetDirectoryEntry();
                        int userAccountControlFlags2 = (int)comp2.Properties["userAccountControl"].Value;
                        String ComputerAccountName2 = (String)comp2.Properties["samAccountName"].Value;

                        if (userAccountControlFlags2 >= 524288 && userAccountControlFlags2 <= 998395)
                        {
                            outp2 = outp2 + ComputerAccountName2 + " TRUSTED_FOR_DELEGATION " + userAccountControlFlags2 + " \n";
                        }
                        else if (userAccountControlFlags2 >= 16777216)
                        {
                            outp2 = outp2 + ComputerAccountName2 + " TRUSTED_TO_AUTH_FOR_DELEGATION " + userAccountControlFlags2 + " \n";
                        }
                        else
                        {
                            NoNotADelegator++;
                        }


                        answer = outp + outp2 + " " + NoNotADelegator + " Not Trusted for Delegation or Trusted to Auth for Delegation";
                    }
                }
                else
                {
                    answer = "Not Found";
                }
            }
            catch (System.Runtime.InteropServices.COMException) { answer = "Invalid Domain"; }

        return answer;

        }

        public string RegWriteDeleteCheck()
        {
            string answer = "";
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\m0rt1skun", "MyApp", Application.ExecutablePath);
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Red Gate\SQL Backup\m0rt1skun", "MyApp", Application.ExecutablePath);

            answer = "Test registry write and delete... Test Key written to HKEY_CURRENT_USER\\Software\\m0rt1skun and HKEY_LOCAL_MACHINE\\Software\\Red Gate\\SQL Backup\\m0rt1skun";

            string keyName = @"Software";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key == null)
                {
                    answer = "Failed";
                }
                else
                {
                    key.DeleteSubKey("m0rt1skun");
                }
            }

            string keyName2 = @"SOFTWARE\Red Gate\SQL Backup";
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyName2, true))
            {
                if (key == null)
                {
                    answer = "Failed";
                }
                else
                {
                    key.DeleteSubKey("m0rt1skun");
                }
            }


            answer = "Test registry write and delete... Test Key written to HKEY_CURRENT_USER\\Software\\m0rt1skun and HKEY_LOCAL_MACHINE\\Software\\Red Gate\\SQL Backup\\m0rt1skun... Test Keys Deleted";

            return answer;
        }



        public string GetSharePermisions(string folder)
        {
            String answer = "";
               try
                {

                    

                    ActiveDs.IADsAccessControlList dacl;
                    ActiveDs.IADsSecurityDescriptor securitydes;
                    ActiveDs.ADsSecurityUtility secuUtil = new ActiveDs.ADsSecurityUtility();

                    

                    securitydes = (ActiveDs.IADsSecurityDescriptor)secuUtil.GetSecurityDescriptor(folder, 1 /* (int)
                    ActiveDs.ADS_PATHTYPE_ENUM.ADS_PATH_FILE*/, 1) /*(int)ActiveDs.ADS_SD_FORMAT_ENUM.ADS_SD_FORMAT_IID)*/;
                    
                    dacl = (ActiveDs.IADsAccessControlList)securitydes.DiscretionaryAcl;

                    System.Text.StringBuilder strbui = new System.Text.StringBuilder();

                    foreach (ActiveDs.IADsAccessControlEntry entry in dacl)
                    {
                        string permission = "";
                        if (entry.AccessMask == 2032127)
                            permission = "- Full Permissions";
                        else if (entry.AccessMask == 1245631)
                            permission = "- Change Permissions";
                        else if (entry.AccessMask == 1179817)
                            permission = "- Read Permissions";
                        strbui.AppendLine(string.Format("AccessMask: {0}", entry.AccessMask + " " + permission ));
                        strbui.AppendLine(string.Format("Trustee: {0}\n", entry.Trustee));
                    }

                    answer = strbui.ToString();
                }

                catch (System.IO.FileNotFoundException) { answer = "Cannot find path or folder specified, Please check your input and make sure the folder exists"; }
                catch (System.Runtime.InteropServices.COMException) { answer = "Invalid Folder, Please check your input"; }
                catch (System.UnauthorizedAccessException) { answer = "Unauthorized Access, you do not have permission to check that folder"; }
                catch (Exception ex) { answer = ex.ToString(); }
               
            return answer;
        }

        public string GetNTFSPermissions(string folder)
        {

            String info = "";

            try
            {

                DirectoryInfo myDirectoryInfo = new DirectoryInfo(folder);
                DirectorySecurity myDirectorySecurity = myDirectoryInfo.GetAccessControl();
                AuthorizationRuleCollection rules = myDirectorySecurity.GetAccessRules(true, true, typeof(NTAccount));
                foreach (AuthorizationRule rule in rules)
                {

                    StringBuilder bldr = new StringBuilder();

                    if (rule.IsInherited)

                        bldr.Append("[INHERITED] ");

                    bldr.AppendFormat("{0} ", rule.IdentityReference);

                    info = info + bldr.ToString() + " \n";
                }

               // this.outputbox.Text = info;
            }
            catch (System.ArgumentException) { info = "Invalid Folder"; }
            catch (System.IO.DirectoryNotFoundException) { info = "Invalid Folder"; }
            catch (System.IO.PathTooLongException) { info = "The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters."; }

            return info;
        }

        public string GetListOfSQLSA(string u, string p, string s, string sql)
        {

            string outp = "";
            string print = "";
            string answer = "";

        try
            {
            
                SqlConnection myConnection = new SqlConnection("user id=" + u +";password=" + p + ";server=" + s + ";Trusted_Connection=yes;" + "database=" + sql +";connection timeout=30");

            
                myConnection.Open();
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("SELECT u.name FROM sys.server_role_members rm JOIN sys.server_principals p ON rm.role_principal_id = p.principal_id JOIN sys.server_principals u ON rm.member_principal_id = u.principal_id WHERE p.name = 'sysadmin'", myConnection);
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    outp = myReader.GetString(0);
                    print = print + outp + "\n";
                }

                answer = "List of SQL Server System Administrators Users \n\n" +  print;
                myConnection.Close();

            }
            catch (System.ArgumentException) { answer = "Invalid Input, Check the Values you have entered."; }
            catch (Exception ex){ answer = ex.ToString(); }

        return answer;
        }
            

        
    


    }
}
