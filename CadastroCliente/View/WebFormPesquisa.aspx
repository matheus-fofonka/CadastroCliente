<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormPesquisa.aspx.cs" Inherits="CadastroCliente.View.WebFormPesquisa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="formPesquisa" runat="server">
       
        <h1>Pesquisa</h1>
        <div style="margin-left: 80px">
            <br />
            <asp:RadioButton ID="RadioButtonNome" runat="server" Text="Nome" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButtonEmail" runat="server" Text="E-mail" />
            <br />
            <br />
            <br />
        </div>
        <div style="margin-left: 70px">
         <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="200px"></asp:TextBox><asp:Button ID="ButtonPesquisar" runat="server" Text="Pesquisar" Width="70px" />

        </div>
    </form>
</body>
</html>
