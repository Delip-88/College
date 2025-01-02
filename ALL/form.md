<form runat="server">
    <label for="accNo">Account_No:</label>
    <asp:TextBox TextMode="Number" ID="accNo" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ControlToValidate="accNo" runat="server" ForeColor="Red" ErrorMessage="This field is required"></asp:RequiredFieldValidator>
    <label for="Name">Name:</label>
    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ControlToValidate="Name" runat="server" ForeColor="Red" ErrorMessage="This field is required"></asp:RequiredFieldValidator>
    <label for="Address">Address:</label>
    <asp:TextBox ID="Address" runat="server"></asp:TextBox>
    <label for="age">Age:</label>
    <asp:TextBox TextMode="Number" runat="server" ID="Age"></asp:TextBox>
    <asp:RangeValidator ControlToValidate="Age" ForeColor="Red" runat="server" MinimumValue="15" MaximumValue="40" ErrorMessage="Age must be between 15 and 40"></asp:RangeValidator>
    Password: 
    <asp:TextBox TextMode="Password" ID="psw" runat="server"></asp:TextBox>
    Confirm Password: 
    <asp:TextBox TextMode="Password" ID="cpsw" runat="server"></asp:TextBox>
    <asp:CompareValidator ControlToCompare="psw" ControlToValidate="cpsw" ForeColor="Red" runat="server" ErrorMessage="Passwords do not match"></asp:CompareValidator>
    Email: 
    <asp:TextBox ID="mail" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ControlToValidate="mail" ValidationExpression="^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$" runat="server" ForeColor="Red" ErrorMessage="Invalid email address"></asp:RegularExpressionValidator>
    <asp:Button ID="submit" Text="Submit" runat="server" OnClick="btn_submit" />
 </form>

 CREATE TABLE Accounts (
    Account_No INT PRIMARY KEY,
    Name NVARCHAR(100),
    Address NVARCHAR(200),
    Age INT,
    Password NVARCHAR(100),
    Email NVARCHAR(100)
);

""
protected void btn_submit(object sender, EventArgs e)
{
    if (Page.IsValid) // Check if all validators pass
    {
        // Retrieve values from the form
        int accountNo = int.Parse(accNo.Text);
        string name = Name.Text;
        string address = Address.Text;
        int age = int.Parse(Age.Text);
        string password = psw.Text; // Ensure passwords are hashed in real applications
        string email = mail.Text;

        // Connection string (replace with your actual connection string)
        string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Simplified query using string interpolation
                string query = $"INSERT INTO Accounts (Account_No, Name, Address, Age, Password, Email) " +
                               $"VALUES ({accountNo}, '{name}', '{address}', {age}, '{password}', '{email}')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery(); // Execute the query
                }
            }

            // Notify the user of success
            Response.Write("<script>alert('Data successfully saved to the database!');</script>");
        }
        catch (Exception ex)
        {
            // Handle exceptions
            Response.Write($"<script>alert('Error: {ex.Message}');</script>");
        }
    }
}
""


<%@ Page Title="View Data" Language="C#" AutoEventWireup="true" CodeBehind="ViewData.aspx.cs" Inherits="FORM.ViewData" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>View Stored Data</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Stored Account Data</h1>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="True"></asp:GridView>
    </form>
</body>
</html>


using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FORM
{
    public partial class ViewData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Load data only on first load, not on postbacks
            {
                BindData();
            }
        }

        private void BindData()
        {
            // Connection string from Web.config
            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringName"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Query to fetch all data from the Accounts table
                    string query = "SELECT Account_No, Name, Address, Age, Email FROM Accounts";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to GridView
                        GridView1.DataSource = dataTable;
                        GridView1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Response.Write($"<script>alert('Error: {ex.Message}');</script>");
            }
        }
    }
}
