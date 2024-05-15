using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baze_booking
{
    public partial class Register : Form
    {
        private string email, password;
        private static string connectionString = "Data Source=DESKTOP-VURJ317;Initial Catalog=Booking;Integrated Security=True";
        private SqlConnection connection = new SqlConnection(connectionString);

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            email = mailTextBox.Text.Trim();
            password = passwordTextBox.Text.Trim();

            if (!Regex.IsMatch(mailTextBox.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
            {
                if (!label4.Text.EndsWith("*"))
                {
                    label4.ForeColor = Color.Red;
                    label4.Text += '*';
                }
            }

            if ((password.Length < 7 || password.Length > 7) || password.Where(x=>!char.IsLetterOrDigit(x)).Count() != 6 || !password.Any(x=>x=='7') || password.Distinct().Count() != 7) 
            {
                if (label5.Text.Last() != '*')
                {
                    label5.ForeColor = Color.Red;
                    label5.Text += '*';
                }
            }



            connection.Close();
        }
    }
}
