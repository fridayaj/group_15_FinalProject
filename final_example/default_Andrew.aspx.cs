/*
<!--# Name: Andrew Mehlman
# email: mehlmadm@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 04/23/24
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: Solve leet code and display it
# Citations: LeetCode.com, ChatGPT, Professor Nicholson
# Anything else that's relevant:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_example
{
    public partial class default_Andrew : System.Web.UI.Page
    {


            protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ComputeButton_Click(object sender, EventArgs e)
            {
                int n = Convert.ToInt32(InputTextBox.Text);

                int result = NumberOfMatches(n);

                ResultLabel.Text = "Number of matches: " + result.ToString();
            }


        public int NumberOfMatches(int n)
            {
                int count = 0;
                while (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        count += n / 2;
                        n = n / 2;
                    }
                    else
                    {
                        count += (n - 1) / 2;
                        n = (n - 1) / 2 + 1;
                    }
                }
                return count;
            }
        }
    }
