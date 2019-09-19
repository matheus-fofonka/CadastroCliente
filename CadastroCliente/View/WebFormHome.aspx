<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="WebFormHome.aspx.cs" Inherits="CadastroCliente.View.WebFormHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro Usuário</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
</head>
<body>
    <form id="formHome" runat="server">
        <h1>Cadastro de Usuário</h1>
        <br /><br />
        <div style="margin-left: 100px">
            <asp:Button ID="ButtonPesquisar" runat="server" Height="30px" Text="Pesquisar" Width="80px" OnClick="ButtonPesquisar_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonListar" runat="server" Height="30px" Text="Listar" Width="80px" OnClick="ButtonListar_Click" />
        </div>
        <div style="margin-left: 130px">
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="E-mail"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxNome" runat="server" Height="20px"  Width="120px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxEmail" runat="server" Height="20px"  Width="200px"></asp:TextBox>

            <br />

            <br />
            <asp:Label ID="Label3" runat="server" Text="Data de Nascimento"></asp:Label>
            <br />
            <asp:TextBox ID="TextBoxNascimento" runat="server" Height="20px" Width="120px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonCadastrar" runat="server" Height="30px" Text="Cadastrar" Width="80px" OnClick="ButtonCadastrar_Click"/>

        </div>

    </form>
</body>
</html>
