<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Send_Data.aspx.cs" Inherits="client_weBsite.Send_Data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Send Data</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>fill in the details below to add to the table of marks</p>
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" Width="180px"></asp:TextBox>
        <asp:Label ID="Label12" runat="server" Text="ROLL NUMBER"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Width="180px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="NAME"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox3" runat="server" Width="180px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="MATHS"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox4" runat="server" Width="180px"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="PHYSICS"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox5" runat="server" Width="180px"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="CHEMISTRY"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox6" runat="server" Width="180px"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="SOCIAL"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox7" runat="server" Width="180px"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="ENGLISH"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox8" runat="server" Width="180px"></asp:TextBox>
            <asp:Label ID="Label8" runat="server" Text="COMPUTERS"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox9" runat="server" Width="180px"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" Text="2ND LANG NAME"></asp:Label>
        <p>
            <asp:TextBox ID="TextBox10" runat="server" Width="180px"></asp:TextBox>
            <asp:Label ID="Label10" runat="server" Text="2ND LANG MARKS"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox11" runat="server" Width="180px"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" Text="IFPASSED"></asp:Label>
        <p>
            <asp:Button ID="Button1" runat="server" Text="click to send data" Width="186px" OnClick="Button1_Click" />
            <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
