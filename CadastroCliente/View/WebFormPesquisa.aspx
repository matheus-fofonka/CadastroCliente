<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="WebFormPesquisa.aspx.cs" Inherits="CadastroCliente.View.WebFormPesquisa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pesquisar</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
</head>
<body>
    <form id="formPesquisa" runat="server">
       
        <h1>Pesquisa</h1>
        <div style="margin-left: 80px">
            <br />
           <asp:RadioButton ID="RadioButtonNome" GroupName="S" runat="server" Text="Nome" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButtonEmail" GroupName="S" runat="server" Text="E-mail" />
            <br />
            <br />
            <br />
        </div>
        <div style="margin-left: 80px">
         <asp:TextBox ID="TextBoxPesquisa" runat="server" Height="20px" Width="200px"></asp:TextBox><asp:Button ID="ButtonPesquisar" runat="server" Text="Pesquisar" Width="70px" OnClick="ButtonPesquisar_Click" />

        </div>

            <br />
            <br />
            <br />

        <div style="margin-left: 60px">   
            <asp:Label ID="Label1" runat="server" Text="Nome : "></asp:Label>
            <asp:Label ID="LabelNome" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="E-mail : "></asp:Label>
            <asp:Label ID="LabelEmail" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Data de Nascimento : "></asp:Label>
            <asp:Label ID="LabelNasc" runat="server"></asp:Label>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonEditar" runat="server" Text="Editar" />
        </div>

    </form>
</body>
</html>
