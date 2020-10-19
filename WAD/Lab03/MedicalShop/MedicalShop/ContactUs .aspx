<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs .aspx.cs" Inherits="MedicalShop.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Contact Us<br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <br />
            <br />
            Category : <asp:DropDownList ID="DropDownList" runat="server">
                <asp:ListItem Selected="True" Text="--Select--" Value="--Select--"></asp:ListItem>
                <asp:ListItem Text="News" Value="News"></asp:ListItem>
                <asp:ListItem Text="Report" Value="Report"></asp:ListItem>
                <asp:ListItem Text="System" Value="System"></asp:ListItem>
                <asp:ListItem Text="Reminder" Value="Reminder"></asp:ListItem>

                      </asp:DropDownList>
            <br />
            <br />
            Decription : 
            <textarea id="txtDecription" cols="20" name="S1" rows="2"></textarea>
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSunmit_Click" /> 
            <br />
        </div>
        
    </form>
</body>
</html>
