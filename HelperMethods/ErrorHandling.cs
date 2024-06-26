﻿namespace Personal_budget_management_tool.HelperMethods
{
    internal class ErrorHandling
    {
        internal static bool IsPositiveNumber(string text, out double number)
        {
            if (double.TryParse(text, out number) && number > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void ValidateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentException("User cannot be null.");
            }
        }
        internal static bool IsPositiveNumber(double number)
        {
            if (number > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        internal static bool IsValidDescription(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Description cannot be null or empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static void ValidateReminderDate(DateTime date)
        {
            if (date < DateTime.Now)
            {
                throw new ArgumentException("Reminder date cannot be in the past.");
            }
        }

        internal static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void CheckFilePath(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                ShowErrorMessage("File path has not been set.");
                throw new InvalidOperationException("File path has not been set.");
            }
        }

        internal static void CheckFileToken(string line, string token)
        {
            if (line != token)
            {
                ShowErrorMessage("File was not saved by this application.");
                throw new InvalidOperationException("File was not saved by this application.");
            }
        }

        public static bool IsValidAmount(string amount)
        {
            if (double.TryParse(amount, out double parsedAmount) && parsedAmount > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a valid positive number for the amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }


}
