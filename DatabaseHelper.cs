// Assume connection string is stored in web.config
string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

// Create
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    SqlCommand command = new SqlCommand("INSERT INTO Employee VALUES (@EmployeeID, @FirstName, @LastName, @Department, @Salary)", connection);
    // Add parameters and set values
    command.Parameters.AddWithValue("@EmployeeID", employeeID);
    // ... other parameters
    command.ExecuteNonQuery();
}

// Read
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    SqlCommand command = new SqlCommand("SELECT * FROM Employee", connection);
    SqlDataReader reader = command.ExecuteReader();
    // Process the reader and display the information
}

// Update
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    SqlCommand command = new SqlCommand("UPDATE Employee SET FirstName = @FirstName, LastName = @LastName, Department = @Department, Salary = @Salary WHERE EmployeeID = @EmployeeID", connection);
    // Add parameters and set values
    command.Parameters.AddWithValue("@EmployeeID", employeeID);
    // ... other parameters
    command.ExecuteNonQuery();
}

// Delete
using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    SqlCommand command = new SqlCommand("DELETE FROM Employee WHERE EmployeeID = @EmployeeID", connection);
    // Add parameters and set values
    command.Parameters.AddWithValue("@EmployeeID", employeeID);
    command.ExecuteNonQuery();
}
