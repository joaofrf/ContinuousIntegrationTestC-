<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ContinuousIntegrationTest</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Soma: </p>
            <asp:TextBox type="text" runat="server" id="txtTeste" OnTextChanged="txtTeste_TextChanged" AutoPostBack="true" value="" />
            <p>Resultado: </p>
            <p runat="server" id="txtResult"></p>
        </div>
    </form>
</body>
</html>
