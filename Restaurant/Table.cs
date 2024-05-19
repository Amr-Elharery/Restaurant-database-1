using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Table : Form
    {
        private string food;
        private string number;

        public Table(string number, string food)
        {
            InitializeComponent();
            this.food = food;
            this.number = number;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=AMR-ELHARERY;Database=Restaurant;Integrated Security=True;";
            int foodId = 0;
            decimal amount = 0; // Change to decimal for better monetary precision
            int orderId = 0;
            DateTime reservationDate;

            // Ensure the reservation date is valid
            if (!DateTime.TryParse(dateReservation.Text, out reservationDate))
            {
                MessageBox.Show("Invalid date format.");
                return;
            }

            // Retrieve food_id and price
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string foodIDQuery = "SELECT food_id, price FROM food WHERE name=@name";
                    using (SqlCommand command = new SqlCommand(foodIDQuery, conn))
                    {
                        command.Parameters.AddWithValue("@name", this.food);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                foodId = reader.GetInt32(reader.GetOrdinal("food_id"));
                                amount = reader.GetDecimal(reader.GetOrdinal("price")); // Use GetDecimal for decimal type
                            }
                            else
                            {
                                MessageBox.Show("Invalid food name.");
                                return;
                            }
                            // MessageBox.Show("Food Id and price retrieved successfully.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving food details: " + ex.Message);
                    return;
                }
            }

            // Retrieve the latest order_id
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string orderIDQuery = "SELECT ISNULL(MAX(order_id), 0) + 1 AS NextID FROM order_customer";
                    using (SqlCommand command = new SqlCommand(orderIDQuery, conn))
                    {
                        orderId = (int)command.ExecuteScalar();
                        //MessageBox.Show("Order Id retrieved successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving order ID: " + ex.Message);
                    return;
                }
            }

            // Insert a new order
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertOrderQuery = "INSERT INTO order_customer(order_date, total_amount, type, staff_id, food_id, customer_number, order_status) " +
                                              "VALUES (@date, @amount, 'table', 1, @food, @number, 'pending')";
                    using (SqlCommand command = new SqlCommand(insertOrderQuery, conn))
                    {
                        command.Parameters.AddWithValue("@date", reservationDate);
                        command.Parameters.AddWithValue("@amount", amount);
                        command.Parameters.AddWithValue("@food", foodId);
                        command.Parameters.AddWithValue("@number", this.number);
                        command.ExecuteNonQuery();
                        // MessageBox.Show("Order inserted successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting the order: " + ex.Message);
                    return;
                }
            }

            // Insert table reservation
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string reserveTableQuery = "INSERT INTO table_reservation (staff_id, order_id, customer_number, number_of_people, reservation_date, status) " +
                                               "VALUES (1, @orderId, @number, @people, @date, 'accept')";
                    using (SqlCommand command = new SqlCommand(reserveTableQuery, conn))
                    {
                        command.Parameters.AddWithValue("@orderId", orderId);
                        command.Parameters.AddWithValue("@number", this.number);
                        command.Parameters.AddWithValue("@people", int.Parse(txtNumberOfPeople.Text));
                        command.Parameters.AddWithValue("@date", reservationDate);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Table reserved successfully!");
                    }

                    Success success = new Success();
                    this.Hide();
                    success.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while reserving the table: " + ex.Message);
                }
                
            }
        }
    }
}
