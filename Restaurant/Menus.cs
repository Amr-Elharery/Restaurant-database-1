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
    public partial class Menus : Form
    {
        public Menus()
        {
            InitializeComponent();
        }

        private void Menus_Load(object sender, EventArgs e)
        {
            string connectionString = "Server = AMR-ELHARERY; Database = Restaurant; Integrated Security = True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT m.*, f.name, f.price + 1 AS updated_price FROM menu AS m"+
                        " JOIN food AS f ON m.food_id = f.food_id JOIN staff AS s ON s.staff_Id = m.staff_id"+
                        " WHERE s.role IN ('admin', 'manage')";

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

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = AMR-ELHARERY; Database = Restaurant; Integrated Security = True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE menu WHERE food_id=@id";
                    string queryDeleteFood = "DELETE food WHERE food_id=@id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", int.Parse(txtFoodId.Text));

                        int rows = command.ExecuteNonQuery();

                    }

                    using (SqlCommand command = new SqlCommand(queryDeleteFood, connection))
                    {
                        command.Parameters.AddWithValue("@id", int.Parse(txtFoodId.Text));

                        int rows = command.ExecuteNonQuery();

                        MessageBox.Show(rows + " row(s) affected");

                        txtFoodId.Text = "";
                    }

                    string queryUpdate = "SELECT m.*, f.name, f.price + 1 AS updated_price FROM menu AS m" +
                        " JOIN food AS f ON m.food_id = f.food_id JOIN staff AS s ON s.staff_Id = m.staff_id" +
                        " WHERE s.role IN ('admin', 'manage')";

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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();
            this.Hide();
            addItem.Show();
        }

        private void labelBackToAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            this.Hide();
            admin.Show();
        }
    }
}
