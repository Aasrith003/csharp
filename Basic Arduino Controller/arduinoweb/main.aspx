<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="arduinoweb.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
         <div><h1>site to control arduino </h1> </div>
        <asp:Button ID="Button1" runat="server" Text="click to turn led on" OnClick="Button1_Click" Width="161px"/>
         <asp:Button ID="Button4" runat="server" Text="LedBlink" Width="161px" OnClick="Button4_Click" />
         <p>
        <asp:Button ID="Button2" runat="server" Text="click to turn led off" OnClick="Button2_Click" Width="161px" />  
         </p>
         <p>
        <asp:Label ID="LedState" runat="server" Text="Label"></asp:Label>
         </p>
         <asp:Button ID="BuzzerOn" runat="server" Text="Buzzer on"  OnClick="BuzzerOn_Click" Width="161px" />
         <asp:Button ID="BuzzerBeep" runat="server" OnClick="Button3_Click" Text="BuzzerBeep" Width="161px" />
         <p>
             <asp:Button ID="BuzzerOff" runat="server" Text="Buzzer off" Width="161px" OnClick="BuzzerOff_Click" />
         </p>
         <asp:Label ID="buzzerState" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
