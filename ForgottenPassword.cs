using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baze_booking
{
    public partial class ForgottenPassword : Form
    {
        private string email, password;
        private static string connectionString = "Data Source=DESKTOP-VURJ317;Initial Catalog=Booking;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(connectionString);

        public ForgottenPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            email = mailTextBox.Text.Trim();
            bool emailValid = false;
            password = passwordTextBox.Text.Trim();
            bool passwordValid = false;

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
            {
                if (!label4.Text.EndsWith("*"))
                {
                    label4.ForeColor = Color.Red;
                    label4.Text += '*';
                }
            }
            else
            {
                emailValid = true;
                if (label4.ForeColor == Color.Red)
                {
                    label4.ForeColor = Color.Black;
                    label4.Text = label4.Text.Remove(label4.Text.Length - 1);
                }
            }

            if ((password.Length < 7 || password.Length > 7) || password.Where(x => !char.IsLetterOrDigit(x)).Count() != 6 || !password.Any(x => x == '7') || password.Distinct().Count() != 7)
            {
                if (label5.Text.Last() != '*')
                {
                    label5.ForeColor = Color.Red;
                    label5.Text += '*';
                }
            }
            else
            {
                passwordValid = true;
                if (label5.ForeColor == Color.Red)
                {
                    label5.ForeColor = Color.Black;
                    label5.Text = label5.Text.Remove(label5.Text.Length - 1);
                }
            }

            if (emailValid && passwordValid)
            {
                string insert = $"UPDATE LogIn SET password = '{password}' WHERE email = '{email}'";
                SqlCommand updateCommand = new SqlCommand(insert, connection);
                updateCommand.ExecuteNonQuery();
                Close();
            }

            connection.Close();
        }
    }
}
