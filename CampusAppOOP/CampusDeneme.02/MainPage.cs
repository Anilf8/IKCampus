using System;
using System.IO;
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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

           

        }

        // Event handler for when the MainPage form loads
        public void MainPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oKULDBDataSet.IKCUCAMPUSapp' table. You can move, or remove it, as needed.
            this.iKCUCAMPUSappTableAdapter.Fill(this.oKULDBDataSet.IKCUCAMPUSapp);
            // Display the logged-in user's name and surname in uppercase
            lblMain.Text = $"Welcome! {Variables.loggedName.ToUpper()} {Variables.loggedSurname.ToUpper()}";

            try
            {
                string query2 = "SELECT ImgFilePath FROM IKCUCAMPUSapp WHERE StudentNo = @pno";

                SqlCommand command = new SqlCommand(query2, SqlOperations.connection);

                command.Parameters.AddWithValue("@pno", Variables.loggedNumber);

                SqlOperations.CheckConnection(SqlOperations.connection);

                object result = command.ExecuteScalar();

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
                // Hata mesajını göster
                MessageBox.Show($"Error: {ex.Message}");
            }

            //###################################################################################


            try
            {
                // Clear any existing controls in the feed and enable scrolling
                flowLayoutFeed.Controls.Clear();
                flowLayoutFeed.AutoScroll = true;

                // SQL query to select post details along with the student name and surname
                string query = @"
    SELECT p.PostText, p.PostTime, u.StudentName, u.StudentSurname, p.PostPicture
    FROM PostDT p
    INNER JOIN IKCUCAMPUSapp u ON p.PostOwnerID = u.StudentNo
    ORDER BY p.PostTime DESC";

                // Create a new SqlCommand with the query and the database connection
                using (SqlCommand cmd = new SqlCommand(query, SqlOperations.connection))
                {
                    // Ensure the database connection is open
                    SqlOperations.CheckConnection(SqlOperations.connection);

                    // Execute the SQL query and use a SqlDataReader to read the results
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Iterate through each row returned by the query
                        while (reader.Read())
                        {
                            // Retrieve the post text, post time, student name, surname, and image path from the current row
                            string postText = reader["PostText"].ToString();
                            DateTime postTime = Convert.ToDateTime(reader["PostTime"]);
                            string studentName = reader["StudentName"].ToString();
                            string studentSurname = reader["StudentSurname"].ToString();
                            string imagePath = reader["PostPicture"].ToString();

                            // Create a panel to hold the post's content
                            Panel postPanel = new Panel
                            {
                                BorderStyle = BorderStyle.FixedSingle,
                                Padding = new Padding(10),
                                Width = flowLayoutFeed.Width - 25,
                                AutoSize = true,
                                Margin = new Padding(5)
                            };

                            // Create a PictureBox to display the post image (if the image path is valid)
                            PictureBox pictureBox = new PictureBox
                            {
                                Image = !string.IsNullOrEmpty(imagePath) && File.Exists(imagePath) ? Image.FromFile(imagePath) : null,
                                Width = mainPagePostPicture.Width,
                                Height = mainPagePostPicture.Height,
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Margin = mainPagePostPicture.Margin
                            };

                            // Create a RichTextBox to display the post text and metadata (student name, post time)
                            RichTextBox rtbPostText = new RichTextBox
                            {
                                Multiline = txtMainPostText.Multiline,
                                ReadOnly = txtMainPostText.ReadOnly,
                                Width = txtMainPostText.Width,
                                Height = txtMainPostText.Height,
                                Margin = txtMainPostText.Margin,
                                Font = txtMainPostText.Font,
                                Location = new Point(txtMainPostText.Location.X + 20, txtMainPostText.Location.Y)
                            };

                            // Add the post timestamp and student name in bold font
                            rtbPostText.SelectionFont = new Font(rtbPostText.Font, FontStyle.Bold);
                            rtbPostText.AppendText($"{postTime:yyyy-MM-dd HH:mm} - {studentName} {studentSurname}\r\n");

                            // Add the post text in regular font
                            rtbPostText.SelectionFont = new Font(rtbPostText.Font, FontStyle.Regular);
                            rtbPostText.AppendText($"{postText}\r\n");

                            // Add the PictureBox and RichTextBox to the post panel
                            postPanel.Controls.Add(pictureBox);
                            postPanel.Controls.Add(rtbPostText);

                            // Add the post panel to the flow layout feed
                            flowLayoutFeed.Controls.Add(postPanel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"Error: {ex.Message}");
            }








        }

        // Event handler for logging out
        public void btnLogout_Click(object sender, EventArgs e)
        {
            // Display a message indicating the user is logging out
            MessageBox.Show("Logging out...");

            // Clear the user's session data
            Variables.loggedName = null;
            Variables.loggedSurname = null;
            Variables.loggedNumber = null;
            Variables.loggedDepartment = null;
            Variables.loggedMail = null;
            Variables.loggedPassword = null;
            Variables.loggedID = -1;

            // Navigate back to the login form (Form1)
            Register newform = new Register();
            newform.Show();
            this.Hide();
        }

        // Event handler for navigating to the profile page
        private void btnProfile_Click(object sender, EventArgs e)
        {
            // Open the Profile form and hide the current MainPage form
            Profile profile = new Profile();
            profile.Show();
            this.Hide();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            PostShare post = new PostShare();
            post.Show();
            this.Hide();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
           Message message= new Message();
           message.Show();
           this.Hide();

        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutFeed_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMain_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
