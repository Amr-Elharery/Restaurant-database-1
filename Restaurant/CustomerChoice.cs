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
    public partial class CustomerChoice: Form
    {
        public CustomerChoice()
        {
            InitializeComponent();
        }

        private void CustomerChoice_Load(object sender, EventArgs e)
        {
            string connectionString = "Server = AMR-ELHARERY; Database = Restaurant; Integrated Security = True;";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT m.*, f.name, f.price + 1 AS updated_price FROM menu AS m" +
                    " JOIN food AS f ON m.food_id = f.food_id JOIN staff AS s ON s.staff_Id = m.staff_id"+
                    " WHERE s.role IN ('admin', 'manage');";

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataMenu.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
