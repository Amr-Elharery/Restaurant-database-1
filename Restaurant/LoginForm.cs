﻿using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = AMR-ELHARERY; Database = restaurant; Integrated Security = True;";
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (chBoxStaff.Checked)
                    {
                        string query = "SELECT staff_id, password FROM staff WHERE staff_id=@id AND password=@password";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@id", txtUserIDSignUp.Text);
                        cmd.Parameters.AddWithValue("@password", int.Parse(txtPasswordSignUp.Text));
                        SqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            MessageBox.Show("Logging in...");
                        }
                        else
                        {
                            MessageBox.Show("Check yout credentials");
                        }

                    }
                    else if (!chBoxStaff.Checked)
                    {
                        string query = "SELECT customer_name, customer_number FROM customer WHERE customer_number=@password AND customer_name=@id";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@password", int.Parse(txtPasswordSignUp.Text));
                        cmd.Parameters.AddWithValue("@id", txtUserIDSignUp.Text);
                        SqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        { 
                            Menu menu = new Menu();
                            menu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Check yout credentials");
                        }
                    }
                    connection.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}