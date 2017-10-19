<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main_page.aspx.cs" Inherits="client_weBsite.main_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Marks Storage Server Client</title>
</head>
<body>
    <h1>
        Marks Storage Website
    </h1>
    <form id="form1" runat="server">
    
        <asp:GridView ID="GridView1" runat="server" Height="197px" Width="368px"></asp:GridView>
        <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="356px"></asp:TextBox>
        
   
        <p>
           
            <asp:Label ID="Label2" runat="server" Text="enter subject name"></asp:Label>
        </p>
        <p>
        <asp:Button ID="Button1" runat="server" Text="click to get data" Height="39px" OnClick="Button1_Click1" Width="367px" />
            <asp:Label ID="Label3" runat="server" Text="errors" BackColor="Red"></asp:Label>
        </p>
        <asp:HyperLink ID="GoToSendData" NavigateUrl ="~/Send_Data.aspx" Text ="click here to go to the page to send data" runat="server"></asp:HyperLink>

    </form>
     </body>
</html>
