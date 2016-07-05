<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <h3>Hello, World!</h3>
        <asp:Label ID="Label1" runat="server" Text="Please type in your name:"></asp:Label>
    </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <p>
            <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
        </p>

        <br />
        <asp:Label ID="Label2" runat="server" Text="Please check or uncheck the box"></asp:Label>
        <p>
        <asp:CheckBox ID="CheckBox1" runat="server" />
            
        </p>
        <asp:Button ID="Button2" runat="server" Text="Check Box Button" OnClick="Button2_Click"  />
        <p>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </p>
        <asp:Label ID="Label4" runat="server" Text="Please click the radio button"></asp:Label>

         <p>
            <asp:RadioButton ID="RadioButton2" runat="server" />
            
        </p>
        <asp:Button ID="Button3" runat="server" Text="RadioButton Button" OnClick="Button3_Click" />

        <p>

        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        </p>

        <asp:Label ID="Label6" runat="server" Text="Please click one of the radio buttons in the list:"></asp:Label>
        <%--<asp:RadioButton ID="RadioButton1" runat="server" />
        <asp:RadioButton ID="RadioButton3" runat="server" />
        <asp:RadioButton ID="RadioButton4" runat="server" />--%>

        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>One</asp:ListItem>
            <asp:ListItem>Two</asp:ListItem>
            <asp:ListItem>Three </asp:ListItem>
        </asp:RadioButtonList>

        <p>

        <asp:Button ID="Button4" runat="server" Text="RadioButton List Button" OnClick="Button4_Click" />

        </p>
        <p>

        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
        </p>

        
    </form>
</body>
</html>

