﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Success : Form
    {
        public Success()
        {
            InitializeComponent();
        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            CustomerChoice customerChoice = new CustomerChoice();
            this.Hide();
            customerChoice.Show();
        }
    }
}
