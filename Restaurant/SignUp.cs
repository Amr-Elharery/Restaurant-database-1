using System;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnStaffSignUp_Click(object sender, EventArgs e)
        {
            StaffSignUp staffSignUp = new StaffSignUp();
            this.Hide();
            staffSignUp.Show();
        }

        private void btnCustomerSignUp_Click(object sender, EventArgs e)
        {
            CustomerSignUp customerSignUp = new CustomerSignUp();
            this.Hide();
            customerSignUp.Show();
        }

        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
