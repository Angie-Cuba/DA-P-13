<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practica_2_EjerProp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Aplicacion web</title>
    <style type="text/css">
        .Imagen {
            height: 211px;
            width: 332px;
            margin-left: 166px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="FACULTADES" 
            Width="479px" Height="36px" Font-Bold="True" Font-Name="Arial Black"
            Font-Size="X-Large" ></asp:Label>
        </div>
        <p class="Facultades">
            <asp:Label ID="Label2" runat="server" Text="Facultades"></asp:Label>&nbsp;
            <asp:DropDownList ID="Productos" runat="server" Autopostback="True" OnSelectedIndexChanged="SelectedIndexChanged"></asp:DropDownList>
        </p>
        <p class="f1">
            <asp:TextBox ID="f1" runat="server" Height="24px" Width="230px"></asp:TextBox>&nbsp;       
        </p>
        <p class="f12">
            <asp:TextBox ID="TextBox1" runat="server" Height="24px" Width="230px"></asp:TextBox>&nbsp;       
        </p>
        <p class="f3">
            <asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="230px"></asp:TextBox>&nbsp;       
        </p>
        <p class="f4">
            <asp:TextBox ID="TextBox3" runat="server" Height="24px" Width="230px"></asp:TextBox>&nbsp;       
        </p>
        <p class="f5">
            <asp:TextBox ID="TextBox4" runat="server" Height="24px" Width="230px"></asp:TextBox>&nbsp;       
        </p>
        
        
    </form>
</body>
</html>
