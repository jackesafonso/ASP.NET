<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h3>Simple Control</h3>
        <asp:Label ID="Label1" runat="server" Text="Here is a check box:"></asp:Label>
    </div>
        <p>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Please check this checkbox and click the button" />
        </p>
        <asp:Button ID="Button1" runat="server" Text="Check Button" />

        <p>LinkButton which is just a link really</p>
        <p>
        <asp:Label ID="Label2" runat="server" Text="Click on the image button to follow the link:"></asp:Label>
        </p>
        <p>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/euro2016.jpg" PostBackUrl="http://www.guardian.co.uk" Width="44px" />
        </p>

        <p>This is an image Map. Click on the Earth or Moon for a little bit of information about them. This can also be used for links</p>
        <asp:ImageMap ID="ImageMap1" runat="server"></asp:ImageMap>

     
    </form>
</body>
</html>
