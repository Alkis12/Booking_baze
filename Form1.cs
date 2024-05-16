using System;
using System.Diagnostics;
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
            if (isLogedIn)
            {
                Debug.WriteLine("dasd11111");
                logInButton.Visible = false;
                logInButton.Enabled = false;
                userIcon.Visible = true;
            }
            else
            {
                Debug.WriteLine("dasd");
                userIcon.Visible = false;
                logInButton.Enabled = true;
                logInButton.Visible = true;
                LogIn.email = "";
                LogIn.password = "";
            }
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                panel1.Visible = true;
                mailPanel1Lbl.Text = $"E-mail: {LogIn.email}";
                passwordPanel1Lbl.Text = $"Lozinka: {LogIn.password}";
            }
            else
            {
                mailPanel1Lbl.Text = $"E-mail:";
                passwordPanel1Lbl.Text = $"Lozinka:";
                panel1.Visible = false;
            }
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            IsLogedIn = false;
            mailPanel1Lbl.Text = $"E-mail:";
            passwordPanel1Lbl.Text = $"Lozinka:";
            panel1.Visible = false;
        }
    }
}
