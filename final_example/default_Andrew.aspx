<!--# Name: Andrew Mehlman
# email: mehlmadm@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 04/23/24
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: Solve leet code and display it
# Citations: LeetCode.com, ChatGPT, Professor Nicholson
# Anything else that's relevant: -->


<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default_Andrew.aspx.cs" Inherits="final_example.default_Andrew"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Leetcode Count of Matches in Tournament | Easy</h2>
            <asp:Label ID="Label1" runat="server" Text="Problem Description: "></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="You are given an integer n, the number of teams in a tournament that has strange rules.
If the current number of teams is even, each team gets paired with another team. A total of n / 2 matches are played, and n / 2 teams advance to the next round.
If the current number of teams is odd, one team randomly advances in the tournament, and the rest gets paired. A total of (n - 1) / 2 matches are played, and (n - 1) / 2 + 1 teams advance to the next round.
Return the number of matches played in the tournament until a winner is decided."></asp:Label>
            <br />
         <asp:TextBox ID="InputTextBox" runat="server"></asp:TextBox>
         <asp:Button ID="ComputeButton" runat="server" Text="Compute" OnClick="ComputeButton_Click" />
         <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
       </div>
       
    </form>
</body>
</html>
