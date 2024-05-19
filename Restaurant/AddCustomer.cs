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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = AMR-ELHARERY; Database = Restaurant; Integrated Security = True;";

            using(SqlConnection  conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO customer(customer_name, customer_number, email, [address], [password])" +
                        " VALUES (@name, @number, 'email@example.com', 'GIZA', 'password')";

                    using (SqlCommand  cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtCustomerName.Text);
                        cmd.Parameters.AddWithValue("@number", txtCustomerNumber.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Customer Added successfully.\n? Update your data in customer mode");
                        
                        Customers customers = new Customers();
                        this.Hide();
                        customers.Show();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void labelBackToCustomers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            this.Hide();
            customers.Show();
        }
    }
}
