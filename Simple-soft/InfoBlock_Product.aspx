<%@ Page Language="VB" AutoEventWireup="false" CodeFile="InfoBlock_Product.aspx.vb" Inherits="InfoBlock_Product" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="https://www.w3.org/1999/xhtml/">
<head id="Head1" runat="server">
    <title></title>
    <link href="styles.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
		<table id="tblProductTitle" border="0" width="100%">
            <tr>
                <td>
                    <b class="CPageCaption">
                        <asp:Label ID="lblProduct" runat="server"></asp:Label>
                    </b>
                </td>
                <td align="center" style="color: DarkRed;">
                    <asp:Label ID="lblProductDescription" runat="server"></asp:Label>
                </td>
                <td align="right" style="padding-right: 20px;">
                    <b class="CPageCaption">
                        <asp:Label ID="lblProductPrice" runat="server"></asp:Label>
                    </b>
                </td>
                <td align="right" class="CButton">
                    <a href="prices.htm#OrderForm" style="color: Black; text-decoration: none;" target="_parent">Купить</a>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <hr class="CHr" style="margin-bottom: 10px;" />
                    &nbsp;<asp:Label ID="lblProductVersion" runat="server" CssClass="CProgVersion"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
