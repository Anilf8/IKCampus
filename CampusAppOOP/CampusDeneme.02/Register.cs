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

namespace CampusDeneme._02
{
    public partial class Register : Form
    {
        // Constructor: Initializes the form components
        public Register()
        {
            InitializeComponent();
        }

        // Event handler for the registration button click event
        public void button1_Click(object sender, EventArgs e)
        {
            // Validate name input
            if (!Validation.ValidateName(txtStudentName.Text))
                return;

            // Validate surname input
            if (!Validation.ValidateSurname(txtStudentSurname.Text))
                return;

            // Validate email input
            if (!Validation.ValidateEmail(txtStudentEmail.Text))
                return;

            // Validate password input
            if (!Validation.ValidatePassword(txtPassword.Text))
                return;

            // Validate student number input
            if (!Validation.ValidateStudentNumber(txtStudentNumber.Text))
                return;

            // Validate department input
            if (!Validation.ValidateDepartment(txtDepartment.Text))
                return;

            // Create a SQL command to insert registration details into the database
            SqlCommand commandRegister = new SqlCommand(
                "INSERT INTO IKCUCAMPUSapp (StudentName, StudentSurname, StudentNo, StudentDep, StudentMail, Password) " +
                "VALUES (@pname, @psurname, @pno, @pdep, @pmail, @ppassword)",
                SqlOperations.connection
            );

            // Ensure the database connection is open
            SqlOperations.CheckConnection(SqlOperations.connection);

            // Add parameters to the SQL command to prevent SQL injection
            commandRegister.Parameters.AddWithValue("@pname", txtStudentName.Text);
            commandRegister.Parameters.AddWithValue("@psurname", txtStudentSurname.Text);
            commandRegister.Parameters.AddWithValue("@pno", txtStudentNumber.Text);
            commandRegister.Parameters.AddWithValue("@pdep", txtDepartment.Text);
            commandRegister.Parameters.AddWithValue("@pmail", txtStudentEmail.Text);
            commandRegister.Parameters.AddWithValue("@ppassword", txtPassword.Text);

            // Execute the SQL command to insert the data
            commandRegister.ExecuteNonQuery();

            // Notify the user that registration was successful
            MessageBox.Show("Registration successful!");
        }

        // Event handler for the login button click event
        private void button2_Click(object sender, EventArgs e)
        {
            // Create a SQL command to verify login credentials
            SqlCommand loginCommand = new SqlCommand(
                "SELECT * FROM IKCUCAMPUSapp WHERE StudentNo = @pno AND Password = @ppassword",
                SqlOperations.connection
            );

            // Ensure the database connection is open
            SqlOperations.CheckConnection(SqlOperations.connection);

            // Add parameters to the SQL command to prevent SQL injection
            loginCommand.Parameters.AddWithValue("@pno", txtSignInNumber.Text);
            loginCommand.Parameters.AddWithValue("@ppassword", txtSignInPassword.Text);

            // Execute the command and fill the results into a DataTable
            SqlDataAdapter da = new SqlDataAdapter(loginCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Check if any rows were returned (indicating valid login)
            if (dt.Rows.Count > 0)
            {
                // Notify the user that login was successful
                MessageBox.Show("Login successful!");

                // Assign user information to global variables for use in the application
                Variables.loggedName = dt.Rows[0]["StudentName"].ToString();
                Variables.loggedSurname = dt.Rows[0]["StudentSurname"].ToString();
                Variables.loggedNumber = dt.Rows[0]["StudentNo"].ToString();
                Variables.loggedDepartment = dt.Rows[0]["StudentDep"].ToString();
                Variables.loggedMail = dt.Rows[0]["StudentMail"].ToString();
                Variables.loggedPassword = dt.Rows[0]["Password"].ToString();
                Variables.loggedID = Convert.ToInt32(dt.Rows[0]["StudentID"]);

                // Open the main application page and hide the current login form
                MainPage mainform = new MainPage();
                mainform.Show();
                this.Hide();
            }
            else
            {
                // Display an error message if login credentials are incorrect
                MessageBox.Show("Invalid student number or password.");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtSignInNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
