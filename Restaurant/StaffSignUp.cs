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
    public partial class StaffSignUp : Form
    {
        public StaffSignUp()
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
            int id;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryID = "SELECT ISNULL(MAX(staff_id), 0) AS LastID FROM staff;";
                    using (SqlCommand command = new SqlCommand(queryID, connection))
                    {
                        id = (int)command.ExecuteScalar();
                        id++;
                    }

                    if (txtPasswordSignUp.Text == txtConfirmPassword.Text)
                    {
                        string query = "INSERT INTO staff(password, role, staff_name, salary) VALUES (@password, @role, @staff_name, @salary)";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@password", txtPasswordSignUp.Text);
                            cmd.Parameters.AddWithValue("@role", txtUserRole.Text);
                            cmd.Parameters.AddWithValue("@staff_name", txtFullName.Text);
                            cmd.Parameters.AddWithValue("@salary", double.Parse(txtSalary.Text));

                            int rows = cmd.ExecuteNonQuery();
                            MessageBox.Show($"{rows} row(s) affected");
                            MessageBox.Show($"Your ID is: {id}");

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
