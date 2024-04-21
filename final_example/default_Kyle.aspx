<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default_Kyle.aspx.cs" Inherits="final_example.default_Kyle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>LeetCode Number to Roman Numeral converter</h2>
            <asp:Label ID="Label1" runat="server" Text="Problem Description: Given a random integer, return the number input in Roman Numeral form"></asp:Label>
            <br />
            <asp:TextBox ID="NumberTextBox" runat="server"></asp:TextBox>
            <asp:Button ID="ConvertButton" runat="server" Text="Convert" OnClick="ConvertButton_Click" />
            <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
