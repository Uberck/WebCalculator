<!-- Christos Kokkalis Web Calculator 2020 -->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Web Calculator Demo - ITC3100</title>
    <link rel="stylesheet" href="styles.css" />
</head>
<body>
    <div id="container">
        <form id="form1" runat="server">
            <div class="style1">
                <fieldset class="style2">
                    <h2>Web Calculator Demo</h2>
                    <h4>Fill in the first two fields and select the operand, clear to clear the fields</h4>
                    <table class="style5">
                        <tr>
                            <td class="style3">
                                <asp:Label ID="lblFirstNumber" Text="First Number:" runat="server" />
                            </td>
                            <td class="style4">
                                <asp:TextBox runat="server" ID="txtFirstNumber" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style3">
                                <asp:Label ID="lblSecondNumber" Text="Second Number:" runat="server" />
                            </td>
                            <td class="style4">
                                <asp:TextBox runat="server" ID="txtSecondNumber" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style3">
                                <asp:Label ID="lblResult" Text="Result:" runat="server" />
                            </td>
                            <td class="style4">
                                <asp:TextBox runat="server" ID="txtResult" ReadOnly="true" BackColor="Yellow" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label runat="server" ID="lblMessage" ForeColor="Red" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="+" />
                                <asp:Button ID="btnSubtract" runat="server" OnClick="btnSubtract_Click" Text="-" />
                                <asp:Button ID="btnMultiply" runat="server" OnClick="btnMultiply_Click" Text="x" />
                                <asp:Button ID="btnDivide" runat="server" OnClick="btnDivide_Click" Text="÷" />
                                <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </div>
        </form>
    </div>
</body>
</html>