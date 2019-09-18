<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAchado.aspx.cs" Inherits="CadastroCliente.View.WebFormAchado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 290px">
            <asp:Button ID="ButtonVoltar" runat="server" Text="Voltar" OnClick="ButtonVoltar_Click" />
        </div>
        <h1>Pesquisar</h1><br />
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nome :"></asp:Label>
&nbsp;<asp:TextBox ID="TextBoxENome" runat="server" Height="15px" Width="150px"></asp:TextBox>
&nbsp;&nbsp;
            <br />
            <br />
&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Data de Nascimento : "></asp:Label>
            <asp:TextBox ID="TextBoxENascimento" runat="server" Height="15px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="E-mail : "></asp:Label>
            <asp:TextBox ID="TextBoxEEmail" runat="server" Height="15px" Width="213px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonEditar" runat="server" Text="Editar" />
        </div>
    </form>
</body>
</html>
