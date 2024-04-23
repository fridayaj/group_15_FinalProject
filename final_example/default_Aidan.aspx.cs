/*
# Name: Aidan Friday
# email: fridayaj@uc.mail.edu
# Assignment Title: Final Project
# Due Date: 4/23/24
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
    public partial class default_Aidan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DisplayProblemDescription();
                DisplayLeetCodeTestCase();
                DisplaySolution();
            }
        }

        protected void DisplayProblemDescription()
        {
            OutputText.Text += "Problem Description: Given a list of building outlines represented by their left and right x-coordinate and height, return the skyline formed by these buildings. Each building is represented by a triplet of integers [left, right, height].<br/><br/>";
        }

        protected void DisplayLeetCodeTestCase()
        {
            // Example Test Case (Skyline)
            int[][] buildings = new int[][] {
                new int[] {2, 9, 10},
                new int[] {3, 7, 15},
                new int[] {5, 12, 12},
                new int[] {15, 20, 10},
                new int[] {19, 24, 8}
            };

            OutputText.Text += "LeetCode Test Case (Skyline):<br/>";
            foreach (var building in buildings)
            {
                OutputText.Text += $"[{building[0]}, {building[1]}, {building[2]}]<br/>";
            }
            OutputText.Text += "<br/>";
        }

        protected void DisplaySolution()
        {
            Aidan_Solution solution = new Aidan_Solution();
            var skyline = solution.GetSkyline(new int[][] {
                new int[] {2, 9, 10},
                new int[] {3, 7, 15},
                new int[] {5, 12, 12},
                new int[] {15, 20, 10},
                new int[] {19, 24, 8}
            });

            OutputText.Text += "Solution (Skyline):<br/>";
            foreach (var point in skyline)
            {
                OutputText.Text += $"[{point[0]}, {point[1]}]<br/>";
            }
        }
    }
}
