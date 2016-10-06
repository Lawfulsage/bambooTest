using System.IO;

namespace userDiscover
{
    class NetTool
    {

        /*Constructor*/

        public NetTool()
        {
        }

        /*Methods*/

        public string Ping(string server, string args)
        {


            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "cmd";
            proc.StartInfo.Arguments = "/c ping " + server + " " + args;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();

            StreamReader reader = proc.StandardOutput;
            string res = reader.ReadToEnd();

            return res;

        }

        public string IPConfig(string args)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "cmd";
            proc.StartInfo.Arguments = "/c ipconfig " + args;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();

            StreamReader reader = proc.StandardOutput;
            string res = reader.ReadToEnd();
            return res;
        }

        public string Nslookup(string server, string args)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "cmd";
            proc.StartInfo.Arguments = "/c nslookup " + server + " " + args;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.Start();

            StreamReader reader = proc.StandardOutput;
            string res = reader.ReadToEnd();
            
            return res;
        }

    }
}
