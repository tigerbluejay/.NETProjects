<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vistaAutor.aspx.cs" Inherits="WebPubs.vistaAutor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnListar" runat="server" Text="Listar" OnClick="btnListar_Click" />
            <asp:Button ID="btnLintarCity" runat="server" Text="Listar por ciudad" OnClick="btnLintarCity_Click" />
            <asp:Button ID="btnTraerUno" runat="server" Text="Traer uno" OnClick="btnTraerUno_Click" />
            <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
            <br />
            <asp:GridView ID="gridAuthor" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
