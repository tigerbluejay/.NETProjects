<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtNombre" ErrorMessage="Nombre es un campo obligatorio!!" 
                ToolTip="Ingrese un Nombre. Es obligatorio."></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblEdad" runat="server" Text="Edad"></asp:Label>
            <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" 
                ControlToValidate="txtEdad" ErrorMessage="Debe ingresar una edad valida!" 
                ToolTip="Ingrese una edad entre 18 y 100" MaximumValue="100" MinimumValue="18" Type="Integer"></asp:RangeValidator>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="E-mail"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtEmail" ErrorMessage="Email es obligatorio" 
                ToolTip="Debe ingresar un email."></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
    ControlToValidate="txtEmail" ErrorMessage="Ingrese un e-mail valido!" 
    ToolTip="Ingreser un email por ejemplo nombre@dominio.com" 
    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="lblCiudad" runat="server" Text="Ciudad"></asp:Label>
            <asp:DropDownList ID="cbCiudad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cbCiudad_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
        </div>



    </form>
</body>
</html>
