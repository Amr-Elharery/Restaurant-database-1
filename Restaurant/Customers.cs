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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = AMR-ELHARERY; Database = Restaurant; Integrated Security = True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE customer WHERE customer_number=@number";
                    string queryDeleteFromTable = "DELETE table_reservation WHERE customer_number=@number";



                    using (SqlCommand command = new SqlCommand(queryDeleteFromTable, connection))
                    {
                        command.Parameters.AddWithValue("@number", txtCustomerNumber.Text);

                        int rows = command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@number", txtCustomerNumber.Text);

                        int rows = command.ExecuteNonQuery();

                        MessageBox.Show(rows + " row(s) affected");

                        txtCustomerNumber.Text = "";
                    }

                    string queryUpdate = "SELECT * FROM customer";

                    using (SqlCommand command = new SqlCommand(queryUpdate, connection))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataMenus.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            string connectionString = "Server = AMR-ELHARERY; Database = Restaurant; Integrated Security = True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM customer";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataMenus.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            this.Hide();
            addCustomer.Show();
        }

        private void labelBackToAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }
    }
}
