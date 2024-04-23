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
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Attach the event handler to the button
            cmd_Kyle.Click += new EventHandler(cmd_Kyle_Click);
            cmd_Aidan.Click += new EventHandler(cmd_Aidan_Click);
            cmd_Andrew.Click += new EventHandler(cmd_Andrew_Click);
        }

        protected void cmd_Kyle_Click(object sender, EventArgs e)
        {
            // Redirect to default_Kyle.aspx when cmd_Kyle button is clicked
            Response.Redirect("default_Kyle.aspx");
        }

        protected void cmd_Aidan_Click(object sender, EventArgs e)
        {
            // Redirect to default_Aida.aspx when cmd_Kyle button is clicked
            Response.Redirect("default_Aidan.aspx");
        }

        protected void cmd_Andrew_Click(object sender, EventArgs e)
        {
            // Redirect to default_Andrew.aspx when cmd_Kyle button is clicked
            Response.Redirect("default_Andrew.aspx");
        }
    }
}