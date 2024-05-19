using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=AMR-ELHARERY;Database=Restaurant;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    connection.Open();
                    transaction = connection.BeginTransaction();

                    string query = "INSERT INTO food (name, description, status, price) " +
                                   "VALUES (@name, @description, @status, @price)";

                    using (SqlCommand command = new SqlCommand(query, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@name", txtFoodName.Text);
                        command.Parameters.AddWithValue("@description", txtFoodDescription.Text);
                        command.Parameters.AddWithValue("@status", txtFoodStatus.Text);
                        command.Parameters.AddWithValue("@price", decimal.Parse(txtFoodPrice.Text));

                        command.ExecuteNonQuery();
                    }

                    string queryUpdateMenu = "INSERT INTO menu (food_id, staff_id) " +
                                             "VALUES ((SELECT food_id FROM food WHERE name = @name), 5)";

                    using (SqlCommand command = new SqlCommand(queryUpdateMenu, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@name", txtFoodName.Text);

                        int rows = command.ExecuteNonQuery();
                        MessageBox.Show(rows + " row(s) affected");
                    }

                    transaction.Commit();

                    Menus menus = new Menus();
                    this.Hide();
                    menus.Show();
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction?.Rollback();
                    }
                    catch(Exception ex2)
                    {
                        MessageBox.Show("An error occurred: " + ex2.Message);
                    }
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void labelBackToMenu_Click(object sender, EventArgs e)
        {
            Menus menus = new Menus();
            this.Hide();
            menus.Show();
        }
    }
}
