namespace userDiscover
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input1 = new System.Windows.Forms.TextBox();
            this.outputbox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input4 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.input3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.input5 = new System.Windows.Forms.TextBox();
            this.chksqlpermissions = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.input6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(100, 9);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(118, 20);
            this.input1.TabIndex = 0;
            // 
            // outputbox
            // 
            this.outputbox.Location = new System.Drawing.Point(12, 209);
            this.outputbox.Name = "outputbox";
            this.outputbox.ReadOnly = true;
            this.outputbox.Size = new System.Drawing.Size(721, 230);
            this.outputbox.TabIndex = 16;
            this.outputbox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Information";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get AD Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Domain";
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(100, 92);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(118, 20);
            this.input4.TabIndex = 3;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(100, 37);
            this.input2.Name = "input2";
            this.input2.PasswordChar = '*';
            this.input2.Size = new System.Drawing.Size(118, 20);
            this.input2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Get AD Group Membership";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(393, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "Get User Type For Logged On User";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(393, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 27);
            this.button4.TabIndex = 10;
            this.button4.Text = "Get User Type For Named User";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(235, 75);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 27);
            this.button5.TabIndex = 8;
            this.button5.Text = "What Can Delegate?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(393, 75);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(189, 27);
            this.button6.TabIndex = 11;
            this.button6.Text = "Can write to Registry?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(100, 66);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(118, 20);
            this.input3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Server";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(589, 148);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 25);
            this.button7.TabIndex = 15;
            this.button7.Text = "Networking Tools";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(592, 9);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(144, 27);
            this.button8.TabIndex = 12;
            this.button8.Text = "Check Share Permissions";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(592, 42);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(144, 27);
            this.button9.TabIndex = 13;
            this.button9.Text = "Check NTFS Permissions";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Folder";
            // 
            // input5
            // 
            this.input5.Location = new System.Drawing.Point(100, 123);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(118, 20);
            this.input5.TabIndex = 4;
            // 
            // chksqlpermissions
            // 
            this.chksqlpermissions.Location = new System.Drawing.Point(592, 75);
            this.chksqlpermissions.Name = "chksqlpermissions";
            this.chksqlpermissions.Size = new System.Drawing.Size(143, 27);
            this.chksqlpermissions.TabIndex = 14;
            this.chksqlpermissions.Text = "Check Sql Permissions";
            this.chksqlpermissions.UseVisualStyleBackColor = true;
            this.chksqlpermissions.Click += new System.EventHandler(this.button10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "SQL Database";
            // 
            // input6
            // 
            this.input6.Location = new System.Drawing.Point(100, 151);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(118, 20);
            this.input6.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 457);
            this.Controls.Add(this.input6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chksqlpermissions);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputbox);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "userDiscover";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.RichTextBox outputbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input4;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input5;
        private System.Windows.Forms.Button chksqlpermissions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox input6;
    }
}

