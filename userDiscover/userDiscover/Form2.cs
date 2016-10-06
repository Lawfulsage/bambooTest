using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace userDiscover
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NetTool tool = new NetTool();
            String Server = this.input1.Text;
            String Args = this.input3.Text;

            this.Output.Text = tool.Ping(Server,Args);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NetTool tool = new NetTool();
            String Args = this.input3.Text;

            this.Output.Text = tool.IPConfig(Args);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NetTool tool = new NetTool();
            String Server = this.input1.Text;
            String Args = this.input3.Text;
            
            this.Output.Text = tool.Nslookup(Server,Args);
        }


    }
}
