﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baze_booking
{
    public partial class Form2 : Form
    {
        private Form1 f1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
        }

        private void Form2_Closing(object sender, EventArgs e)
        {
            f1.Close();
        }
    }
}
