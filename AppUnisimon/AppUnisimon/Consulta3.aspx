<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta3.aspx.cs" Inherits="AppUnisimon.Consulta3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div aria-autocomplete="none">
    
        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblEdad" runat="server" Text="Edad"></asp:Label>
        <asp:TextBox ID="txtEdad0" runat="server" OnTextChanged="txtApellido0_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="lblCorreo" runat="server" Text="Correo"></asp:Label>
        <asp:TextBox ID="txtCorreo" runat="server" OnTextChanged="txtApellido0_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" />
    
    </div>
    </form>
</body>
</html>
