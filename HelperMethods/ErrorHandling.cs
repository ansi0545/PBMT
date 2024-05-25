﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_budget_management_tool.HelperMethods
{
    internal class ErrorHandling
    {
        public static bool IsPositiveNumber(string text, out double number)
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
        public static bool IsPositiveNumber(double number)
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
        public static bool IsValidDescription(string description)
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
    }
    

}