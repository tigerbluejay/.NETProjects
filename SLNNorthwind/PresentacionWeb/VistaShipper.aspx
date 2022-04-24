<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaShipper.aspx.cs" Inherits="PresentacionWeb.VistaShipper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblShipperId" runat="server" Text="Shipper Id"></asp:Label>
            <asp:TextBox ID="txtShipperId" runat="server"></asp:TextBox>
            <asp:Button ID="btnShipper" runat="server" OnClick="btnShipper_Click" Text="Search" />
            <br />
            <asp:GridView ID="gridShipper" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
