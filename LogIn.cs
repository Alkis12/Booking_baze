using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace baze_booking
{
    public partial class LogIn : Form
    {
        private string email, password;
        private static string connectionString = "Data Source=DESKTOP-VURJ317;Initial Catalog=Booking;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(connectionString);

        public LogIn()
        {
            InitializeComponent();
        }

        private void registerLink_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.ShowDialog();
            Close();
        }

        private void forgottenPasswordLink_Click(object sender, EventArgs e)
        {
            ForgottenPassword forgottenPasswordForm = new ForgottenPassword();
            forgottenPasswordForm.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            email = mailTextBox.Text.Trim();
            password = passwordTextBox.Text.Trim();

            if (email == "" || password == "")
            {
                if (label4.Text.Last() != '*')
                {
                    label4.ForeColor = Color.Red;
                    label4.Text += '*';
                    label5.ForeColor = Color.Red;
                    label5.Text += '*';
                }
            }
            else
            {
                string selectPassword = $"SELECT password FROM LogIn WHERE email = '{email}'";
                SqlCommand passwordCommand = new SqlCommand(selectPassword, connection);

                string userPassword = "";

                try
                {
                    object result = passwordCommand.ExecuteScalar();
                    if (result != null)
                    {
                        userPassword = result.ToString();
                    }
                    else
                    {
                        Debug.WriteLine("No password found for the email: " + email);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception occurred: " + ex.Message);
                }

                if (password == userPassword)
                {
                    Form1.IsLogedIn = true;
                    this.Close();
                }
                else
                {
                    if (label4.Text.Last() != '*')
                    {
                        label4.ForeColor = Color.Red;
                        label4.Text += '*';
                        label5.ForeColor = Color.Red;
                        label5.Text += '*';
                    }
                }
            }

            connection.Close();
        }
    }
}
