using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace userDiscover
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /****************Button Clicks*******************/

        private void button1_Click(object sender, EventArgs e)
        {
            String username = this.input1.Text;
            String password = this.input2.Text;
            String domain = this.input4.Text;
            check cek = new check();
            UserDisco ud = new UserDisco();

            String check = cek.InputNullCheck(username, password, domain);
            if (check.Equals("noError"))
            {

                bool auth = cek.Authenticate(username, password, domain);
                if (auth == false)
                    this.outputbox.Text = "Authentication Failed";
                else
                {
                  this.outputbox.Text = ud.AllAD(domain, username, password);
                }
            }
            else
            {
                this.outputbox.Text = check;
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {

            String username = this.input1.Text;
            String password = this.input2.Text;
            String domain = this.input4.Text;
            check cek = new check();
            UserDisco ud = new UserDisco();

            String check = cek.InputNullCheck(username, password, domain);
            if (check.Equals("noError"))
            {

                bool auth = cek.Authenticate(username, password, domain);
                if (auth == false)
                    this.outputbox.Text = "Authentication Failed";
                else
                {
                    this.outputbox.Text = ud.ADGroupMembership(domain, username, password);
                }
            }
            else
            {
                this.outputbox.Text = check;
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            UserDisco ud = new UserDisco();
            this.outputbox.Text = ud.LocMachineCurrentuser();

        }




        private void button4_Click(object sender, EventArgs e)
        {

            String username = this.input1.Text;
            String password = this.input2.Text;
            String domain = this.input4.Text;
            String upn = username + "@" + domain;
            check cek = new check();
            UserDisco ud = new UserDisco();

            String check = cek.InputNullCheck(username, password, domain);
            if (check.Equals("noError"))
            {
                bool auth = cek.Authenticate(username, password, domain);
                if (auth == false)
                    this.outputbox.Text = "Authentication Failed";
                else
                {
                    this.outputbox.Text = ud.LocMachineNamedUser(upn);
                }
            }
            else
            {
                this.outputbox.Text = check;
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            String domain = this.input4.Text;
            UserDisco ud = new UserDisco();
            this.outputbox.Text = ud.ADCanDelegate(domain);
        }



        private void button6_Click(object sender, EventArgs e)
        {
            UserDisco ud = new UserDisco();
            this.outputbox.Text = ud.RegWriteDeleteCheck();
        }



        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }





        private void button8_Click(object sender, EventArgs e)
        {
            if (this.input5.Text.Equals(""))
            {
                this.outputbox.Text = "No Folder Entered";
            }
            else
            {
                String folder = this.input5.Text;
                UserDisco ud = new UserDisco();
                this.outputbox.Text = ud.GetSharePermisions(folder);
            }
        }




        private void button9_Click(object sender, EventArgs e)
        {
            if (this.input5.Text.Equals(""))
            {
                this.outputbox.Text = "No Folder Entered";
            }
            else
            {
                String folder = this.input5.Text;
                UserDisco ud = new UserDisco();
                this.outputbox.Text = ud.GetNTFSPermissions(folder);
            }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            String username = this.input1.Text;
            String password = this.input2.Text;
            String server = this.input3.Text;
            String SQLdb = this.input6.Text;
            UserDisco ud = new UserDisco();

            this.outputbox.Text = ud.GetListOfSQLSA(username,password,server,SQLdb);
        }
    }
}

