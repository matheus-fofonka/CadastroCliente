<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormHome.aspx.cs" Inherits="CadastroCliente.View.WebFormHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro Usuário</title>
</head>
<body>
    <form id="formHome" runat="server">
        <h1>Cadastro de Usuário</h1>
        <div style="margin-left: 100px">
            <asp:Button ID="ButtonPesquisar" runat="server" Height="30px" Text="Pesquisar" Width="80px" OnClick="ButtonPesquisar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonListar" runat="server" Height="30px" Text="Listar" Width="80px" OnClick="ButtonListar_Click" />
        </div>
        <div style="margin-left: 130px">
            <br />
            <br />
            <br />
            <br />
            <asp:TextBox ID="TextBoxNome" runat="server" Height="20px"  Width="120px">Nome</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxEmail" runat="server" Height="20px"  Width="200px">E-mail</asp:TextBox>

            <br />
            <br />
            <asp:TextBox ID="TextBoxNascimento" runat="server" Height="20px" Width="120px">Data Nascimento</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCadastrar" runat="server" Height="30px" Text="Cadastrar" Width="80px" />

        </div>

    </form>
</body>
</html>
