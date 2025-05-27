using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusDeneme._02
{
    public partial class Message : Form
    {
        // Constructor: Initializes the Message form
        public Message()
        {
            InitializeComponent();
        }

        // Event handler for sending a message
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            // Check if the message content is empty
            if (string.IsNullOrEmpty(txtMessageContent.Text))
            {
                MessageBox.Show("Message cannot be empty!");
                return;
            }

            try
            {
                // Get the current date and time for the message timestamp
                DateTime currentTime = DateTime.Now;

                // SQL query to insert the message into the MessageDataTable
                string query = @"
                    INSERT INTO MessageDataTable (SenderId, ReceiverId, MessageContent, MessageTime)
                    VALUES (@SenderId, @ReceiverId, @MessageContent, @MessageTime)";

                // Create the SQL command with the query and connection
                using (SqlCommand cmd = new SqlCommand(query, SqlOperations.connection))
                {
                    // Add parameters to the SQL command to prevent SQL injection
                    cmd.Parameters.AddWithValue("@SenderId", Variables.loggedNumber);
                    cmd.Parameters.AddWithValue("@ReceiverId", int.Parse(txtReciverID.Text));
                    cmd.Parameters.AddWithValue("@MessageContent", txtMessageContent.Text);
                    cmd.Parameters.AddWithValue("@MessageTime", currentTime);

                    // Execute the SQL command to insert the message
                    cmd.ExecuteNonQuery();

                    // Ensure the database connection is open
                    SqlOperations.CheckConnection(SqlOperations.connection);

                    // Display the sent message on the chat screen
                    txtChatScreen.AppendText($"Me: {txtMessageContent.Text} ({currentTime:yyyy-MM-dd HH:mm}){Environment.NewLine}");

                    // Clear the message input field
                    txtMessageContent.Clear();
                }
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Event handler for loading messages
        private void btnLoadMessages_Click(object sender, EventArgs e)
        {
            // SQL query to retrieve messages between the logged-in user and the selected receiver
            string query = @"
                SELECT m.SenderId, m.MessageContent, m.MessageTime, u.StudentName, u.StudentSurname
                FROM MessageDataTable m
                JOIN IKCUCAMPUSapp u ON m.SenderId = u.StudentNo
                WHERE (m.SenderId = @UserId AND m.ReceiverId = @PartnerId)
                   OR (m.SenderId = @PartnerId AND m.ReceiverId = @UserId)
                ORDER BY m.MessageTime ASC";

            // Create the SQL command with the query and connection
            using (SqlCommand cmd = new SqlCommand(query, SqlOperations.connection))
            {
                // Add parameters for the logged-in user and the receiver
                cmd.Parameters.AddWithValue("@UserId", Variables.loggedNumber);
                cmd.Parameters.AddWithValue("@PartnerId", int.Parse(txtReciverID.Text));

                // Execute the SQL command and read the results
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Clear the chat screen before loading new messages
                    txtChatScreen.Clear();

                    while (reader.Read())
                    {
                        // Get message details from the reader
                        int senderId = (int)reader["SenderId"];
                        string message = reader["MessageContent"].ToString();
                        string timestamp = Convert.ToDateTime(reader["MessageTime"]).ToString("yyyy-MM-dd HH:mm");

                        // Determine if the message is sent by the logged-in user or the partner
                        string senderName = senderId == int.Parse(Variables.loggedNumber) ? "Me" : $"{reader["StudentName"]} {reader["StudentSurname"]}";

                        // Define fonts for bold (sender name) and regular (message content)
                        Font boldFont = new Font(txtChatScreen.Font, FontStyle.Bold);
                        Font regularFont = new Font(txtChatScreen.Font, FontStyle.Regular);

                        // Display the sender's name in bold
                        txtChatScreen.SelectionFont = boldFont;
                        txtChatScreen.AppendText($"{senderName}: ");

                        // Display the message content in regular font
                        txtChatScreen.SelectionFont = regularFont;
                        txtChatScreen.AppendText($"{message} ({timestamp}){Environment.NewLine}");
                    }
                }
            }
        }

        // Event handler for exiting the message form and returning to the main page
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Create a new instance of the MainPage form
            MainPage mainPage = new MainPage();

            // Show the MainPage form
            mainPage.Show();

            // Hide the current Message form
            this.Hide();
        }
    }
}
