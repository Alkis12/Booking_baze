using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baze_booking
{
    public partial class Form1 : Form
    {
        private static bool isLogedIn = false;
        public static Form1 instance;

        public static bool IsLogedIn
        {
            get { return isLogedIn; }
            set
            {
                isLogedIn = value;
                instance.IsLogedInValueChanged(isLogedIn);
            }
        }

        public Form1()
        {
            instance = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2(this);

            fr2.StartPosition = FormStartPosition.Manual;
            fr2.Location = Location;
            fr2.Size = Size;

            fr2.Show();
            Hide();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            logInForm.ShowDialog();
        }

        private void IsLogedInValueChanged(bool isLogedIn)
        {
            if(isLogedIn)
            {
                logInButton.Visible = false;
                logInButton.Enabled = false;
                userIcon.Visible = true;
            }
            else
            {
                userIcon.Visible = false;
                logInButton.Visible = true;
                logInButton.Enabled = true;
            }

        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
