using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CampusDeneme._02
{
    public static class Validation
    {
        // Validates if the provided email is in a correct format
        public static bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid email address.");
                return false;
            }
        }

        // Validates if the password is at least 8 characters long and contains at least one letter
        public static bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[a-zA-Z]).{8,}$";
            if (Regex.IsMatch(password, pattern))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Password must be at least 8 characters long and contain at least one letter.");
                return false;
            }
        }

        // Validates if the student number is between 7 and 10 digits
        public static bool ValidateStudentNumber(string studentNumber)
        {
            // Regex pattern to check if the student number is 7 to 10 digits
            string pattern = @"^\d{7,10}$";
            if (!Regex.IsMatch(studentNumber, pattern))
            {
                MessageBox.Show("Student number must be between 7 and 10 digits.");
                return false;
            }

            try
            {
                // Check if the student number already exists in the database
                SqlOperations.CheckConnection(SqlOperations.connection);

                SqlCommand checkCommand = new SqlCommand(
                    "SELECT COUNT(*) FROM IKCUCAMPUSapp WHERE StudentNo = @studentNo",
                    SqlOperations.connection
                );

                checkCommand.Parameters.AddWithValue("@studentNo", studentNumber);

                int userExists = (int)checkCommand.ExecuteScalar();

                if (userExists > 0)
                {
                    MessageBox.Show("This student number is already registered. Please use a different student number.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }

            return true;
        }
    


    // Validates if the department field is not empty
    public static bool ValidateDepartment(string department)
        {
            if (!string.IsNullOrWhiteSpace(department))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Department cannot be empty.");
                return false;
            }
        }

        // Validates if the name field is not empty
        public static bool ValidateName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Name cannot be empty.");
                return false;
            }
        }

        // Validates if the surname field is not empty
        public static bool ValidateSurname(string surname)
        {
            if (!string.IsNullOrWhiteSpace(surname))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Surname cannot be empty.");
                return false;
            }
        }
    }
}
