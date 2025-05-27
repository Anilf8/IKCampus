using System;
using System.Collections;
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
    public partial class Profile : Form
    {
        // Constructor: Initializes the Profile form
        public Profile()
        {
            InitializeComponent();
        }

        // Event handler to navigate back to the main page
        private void btnMain_Click(object sender, EventArgs e)
        {
            // Create a new instance of the MainPage form
            MainPage mainPage = new MainPage();

            // Show the MainPage form
            mainPage.Show();

            // Hide the current Profile form
            this.Hide();
        }

        // Event handler to add or update the profile photo
        public void btnPhotoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Open a file dialog for selecting an image
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "PICTURE SELECTION SCREEN";
                openFileDialog.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg";

                // Check if the user selected a file and clicked OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string selectedFilePath = openFileDialog.FileName;

                    // Display the selected image in the PictureBox
                    pictureBox1.Image = Image.FromFile(selectedFilePath);

                    // Create an SQL command to update the image file path in the database
                    SqlCommand commandUpdate = new SqlCommand(
                        "UPDATE IKCUCAMPUSapp SET ImgFilePath = @pfilepath WHERE StudentNo = @pno",
                        SqlOperations.connection
                    );

                    // Ensure the database connection is open
                    SqlOperations.CheckConnection(SqlOperations.connection);

                    // Add parameters for the image file path and student number
                    commandUpdate.Parameters.AddWithValue("@pfilepath", selectedFilePath);
                    commandUpdate.Parameters.AddWithValue("@pno", Variables.loggedNumber);

                    // Execute the update command
                    int rowsAffected = commandUpdate.ExecuteNonQuery();

                    // Notify the user if the photo update was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Photo updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No matching user found to update.");
                    }
                }
                else
                {
                    // Notify the user if no file was selected
                    MessageBox.Show("No file was selected.");
                }
            }
            catch (Exception ex)
            {
                // Display any error that occurs during the process
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Event handler for when the Profile form loads
        public void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                // SQL query to retrieve the image file path for the logged-in user
                string query = "SELECT ImgFilePath FROM IKCUCAMPUSapp WHERE StudentNo = @pno";

                // Create an SQL command
                SqlCommand command = new SqlCommand(query, SqlOperations.connection);

                // Add parameter for the student number
                command.Parameters.AddWithValue("@pno", Variables.loggedNumber);

                // Ensure the database connection is open
                SqlOperations.CheckConnection(SqlOperations.connection);

                // Execute the query and get the result (image file path)
                object result = command.ExecuteScalar();

                // Load the image if a valid file path is returned
                if (result != null && result != DBNull.Value)
                {
                    string filePath = result.ToString();

                    if (System.IO.File.Exists(filePath))
                    {
                        pictureBox1.Image = Image.FromFile(filePath);
                    }
                    else
                    {
                        MessageBox.Show("Image file not found at the specified path.");
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                // Display error message if an exception occurs
                MessageBox.Show($"Error: {ex.Message}");
            }

            // Load user profile details into text fields
            string query02 = "SELECT StudentName, StudentSurname, StudentNo, StudentDep, Password, StudentMail FROM IKCUCAMPUSapp WHERE StudentNo = @pno";

            // Create SQL command to fetch user data
            SqlCommand command02 = new SqlCommand(query02, SqlOperations.connection);
            command02.Parameters.AddWithValue("@pno", Variables.loggedNumber);

            // Ensure the database connection is open
            SqlOperations.CheckConnection(SqlOperations.connection);

            // Execute the command and read data
            SqlDataReader reader = command02.ExecuteReader();

            // Populate text fields with user data
            if (reader.Read())
            {
                txtNewName.Text = reader["StudentName"].ToString();
                txtNewSurname.Text = reader["StudentSurname"].ToString();
                txtNewNumber.Text = reader["StudentNo"].ToString();
                txtNewDep.Text = reader["StudentDep"].ToString();
                txtNewPassword.Text = reader["Password"].ToString();
                txtNewMail.Text = reader["StudentMail"].ToString();
            }

            // Close the reader
            reader.Close();
        }

        // Event handler for editing and updating the profile details
        public void btnEditProfile_Click(object sender, EventArgs e)
        {
            // SQL command to update user profile details
            SqlCommand commandUpdate = new SqlCommand(
                "UPDATE IKCUCAMPUSapp " +
                "SET StudentName = @pname, StudentSurname = @psurname, StudentNo = @pno, StudentDep = @pdep, Password = @ppassword, StudentMail = @pmail " +
                "WHERE StudentNo = @currentNo",
                SqlOperations.connection
            );

            // Ensure the database connection is open
            SqlOperations.CheckConnection(SqlOperations.connection);

            // Add parameters for the updated profile details
            commandUpdate.Parameters.AddWithValue("@pname", txtNewName.Text);
            commandUpdate.Parameters.AddWithValue("@psurname", txtNewSurname.Text);
            commandUpdate.Parameters.AddWithValue("@pno", txtNewNumber.Text);
            commandUpdate.Parameters.AddWithValue("@pdep", txtNewDep.Text);
            commandUpdate.Parameters.AddWithValue("@ppassword", txtNewPassword.Text);
            commandUpdate.Parameters.AddWithValue("@pmail", txtNewMail.Text);
            commandUpdate.Parameters.AddWithValue("@currentNo", Variables.loggedNumber);

            // Execute the update command
            commandUpdate.ExecuteNonQuery();

            // Notify the user that the profile was updated successfully
            MessageBox.Show("Profile updated successfully!");

            // Update global variables with new data
            Variables.loggedName = txtNewName.Text;
            Variables.loggedSurname = txtNewSurname.Text;
            Variables.loggedNumber = txtNewNumber.Text;
            Variables.loggedDepartment = txtNewDep.Text;
            Variables.loggedPassword = txtNewPassword.Text;
            Variables.loggedMail = txtNewMail.Text;
        }
    }
}
