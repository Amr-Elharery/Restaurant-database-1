using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class CustomerProfile : Form
    {
        private string number;

        public CustomerProfile()
        {
            InitializeComponent();
        }

        private void labelBackToHome_Click(object sender, EventArgs e)
        {
            CustomerChoice customerChoice = new CustomerChoice();
            this.Hide();
            customerChoice.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=AMR-ELHARERY;Database=Restaurant;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM customer WHERE customer_number=@id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", txtUserNumberProfile.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        this.number = txtUserNumberProfile.Text;
                        txtUserNameProfile.Text = reader["customer_name"].ToString();
                        txtUserEmailAddressProfile.Text = reader["email"].ToString();
                        txtUserAddressProfile.Text = reader["address"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Check your number.");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=AMR-ELHARERY;Database=Restaurant;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE customer " +
                                    "SET customer_name=@name, email=@email, address=@address " +
                                    "WHERE customer_number=@number";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@number", txtUserNumberProfile.Text);
                    cmd.Parameters.AddWithValue("@name", txtUserNameProfile.Text);
                    cmd.Parameters.AddWithValue("@email", txtUserEmailAddressProfile.Text);
                    cmd.Parameters.AddWithValue("@address", txtUserAddressProfile.Text);

                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show(rows + " row(s) affected.");
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
    }
}
