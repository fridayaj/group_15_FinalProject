<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="final_example._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="cmd_Kyle" runat="server" Text="Leet Code Kyle" OnClientClick="cmd_Kyle_Click"/>
            <asp:Button ID="cmd_Aidan" runat="server" Text="Leet Code Aidan" OnClientClick="cmd_Aidan_Click"/>
            <asp:Button ID="cmd_Andrew" runat="server" Text="Leet Code Andrew" OnClientClick="cmd_Andrew_Click"/>
        </div>
    </form>
</body>
</html>
