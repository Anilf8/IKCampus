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
    public partial class PostShare : Form
    {
        // Field to store the selected image file path for the post
        string selectedPostFilePath;

        // Constructor: Initializes the PostShare form
        public PostShare()
        {
            InitializeComponent();
        }

        // Event handler to navigate back to the main page
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create a new instance of the MainPage form
            MainPage mainPage = new MainPage();

            // Show the MainPage form
            mainPage.Show();

            // Hide the current PostShare form
            this.Hide();
        }

        // Event handler for selecting a picture for the post
        public void btnPostSelectPic_Click(object sender, EventArgs e)
        {
            try
            {
                // Open a file dialog to allow the user to select an image file
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "PICTURE SELECTION SCREEN";
                openFileDialog.Filter = "PNG|*.png|JPG|*.jpg|JPEG|*.jpeg";

                // Check if the user selected a file and clicked OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the full path of the selected file
                    selectedPostFilePath = openFileDialog.FileName;

                    // Display the selected image in the PictureBox
                    postAddPicture.Image = Image.FromFile(selectedPostFilePath);
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Event handler for sharing the post
        public void btnShare_Click(object sender, EventArgs e)
        {
            // Check if the post text is empty
            if (string.IsNullOrEmpty(txtPostText.Text))
            {
                MessageBox.Show("Message cannot be empty!");
                return;
            }

            try
            {
                // Get the current date and time for the post timestamp
                DateTime currentPostTime = DateTime.Now;

                // SQL query to insert the new post into the PostDT table
                string query = @"
                    INSERT INTO PostDT (PostText, PostPicture, PostOwnerID, PostTime)
                    VALUES (@pPostText, @pPostPicture, @pPostOwnerID, @pPostTime)";

                // Create the SQL command using the query and connection
                using (SqlCommand Postcmd = new SqlCommand(query, SqlOperations.connection))
                {
                    // Ensure the database connection is open
                    SqlOperations.CheckConnection(SqlOperations.connection);

                    // Add parameters to the SQL command
                    Postcmd.Parameters.AddWithValue("@pPostText", txtPostText.Text);
                    Postcmd.Parameters.AddWithValue("@pPostPicture", selectedPostFilePath ?? (object)DBNull.Value);
                    Postcmd.Parameters.AddWithValue("@pPostOwnerID", Variables.loggedNumber);
                    Postcmd.Parameters.AddWithValue("@pPostTime", currentPostTime);

                    // Execute the SQL command to insert the post
                    Postcmd.ExecuteNonQuery();

                    // Notify the user that the post was shared successfully
                    MessageBox.Show("Post shared successfully!");
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
