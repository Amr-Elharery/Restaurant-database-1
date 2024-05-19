using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class CustomerSignUp : Form
    {
        public CustomerSignUp()
        {
            InitializeComponent();
        }

        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=AMR-ELHARERY;Database=Restaurant;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (txtPasswordSignUp.Text == txtConfirmPassword.Text)
                    {
                        string query = "INSERT INTO customer(customer_name, customer_number, email, address, password)" +
                            " values (@name, @number, @email, @address, @password)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@password", txtPasswordSignUp.Text);
                            cmd.Parameters.AddWithValue("@name", txtUserNameSignUp.Text);
                            cmd.Parameters.AddWithValue("@number", txtUserNumber.Text);
                            cmd.Parameters.AddWithValue("@email", txtUserEmailAddress.Text);
                            cmd.Parameters.AddWithValue("@address", txtUserAddress.Text);

                            int rows = cmd.ExecuteNonQuery();
                            MessageBox.Show($"{rows} row(s) affected");

                            LoginForm loginForm = new LoginForm();
                            this.Hide();
                            loginForm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password and confirm password should be the same!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void chBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswordSignUp.PasswordChar = chBoxShowPassword.Checked ? '\0' : '*';

        }

        private void chBoxShowConfirmPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmPassword.PasswordChar = chBoxShowConfirmPassword.Checked ? '\0' : '*';

        }
    }
}
