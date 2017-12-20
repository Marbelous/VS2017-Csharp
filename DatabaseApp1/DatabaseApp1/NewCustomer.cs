using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseApp1
{
    public partial class NewCustomer : Form
    {
        // Identity value from db variables
        private int parsedCustomerID;
        private int orderID;

        // Verify customer name is not empty
        private bool IsCustomerNameValid()
        {
            if (textBoxCustName.Text == "")
            {
                MessageBox.Show("Please enter a customer name...");
                return false;
            }
            else
            {
                return true;
            }

        }

        // Verify Customer ID and order amount
        private bool IsOrderDateValid()
        {
            // Verify CustomerID
            if (textBoxCustID.Text == "")
            {
                MessageBox.Show("You must create a customer account before placing an order.");
                return false;
            }
            else if (numericUpDownOrderAmount.Value < 1)
            {
                MessageBox.Show("Please specify an order amount.");
                    return false;
            }
            else
            {
                return true;
            }
        }
        
        // Clears the form
        private void ClearForm()
        {
            textBoxCustName.Clear();
            textBoxCustID.Clear();
            dateTimePickerOrderDate.Value = DateTime.Now;
            numericUpDownOrderAmount.Value = 0;
            this.parsedCustomerID = 0;
        }

        // --- Handle control events ---
        
        // Calls the Sales.uspNewCustomer stored procedure
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (IsCustomerNameValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString)) // Create connection
                {
                    using (SqlCommand sqlCommand = new SqlCommand("Sales.uspNewCustomer", connection)) // Create SqlCommand as a stored procedure
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Add input parameter and spec its value
                        sqlCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@CustomerName"].Value = textBoxCustName.Text;

                        // Add output parameter and spec its value
                        sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
                        sqlCommand.Parameters["@CustomerID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();

                            sqlCommand.ExecuteNonQuery();

                            this.parsedCustomerID = (int)sqlCommand.Parameters["@CustomerID"].Value;

                            this.textBoxCustID.Text = Convert.ToString(parsedCustomerID);
                        }
                        catch
                        {
                            MessageBox.Show("Customer ID ws not returned.  Account could not be created.");
                        }
                        finally
                        {
                            connection.Close();
                        }

                    }
                }
            }
        }

        private void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderDateValid())
            {
                using (SqlCommand sqlCommand = new SqlCommand("Sales.uspPlaceOrder", connection)) 
            }

        }
        //  --- Required initialize method ---
        public NewCustomer()
        {
            InitializeComponent();
        }

    }
}
