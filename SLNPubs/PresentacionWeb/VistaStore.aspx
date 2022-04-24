<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaStore.aspx.cs" Inherits="PresentacionWeb.VistaStore" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridState" runat="server" OnLoad="GridView1_Load">
            </asp:GridView>
            <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
            <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" />
        </div>
    </form>
</body>
</html>
