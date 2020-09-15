<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormGravadora.aspx.cs" Inherits="POO3B1_32.UI.FormGravadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="MensagemDeErro" runat="server" Text=""></asp:Label>  
        </div><asp:Label ID="Label1" runat="server" Text="Gravadora"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nome Gravadora:"></asp:Label>
        <br />
        <asp:TextBox ID="txtnomegravadora" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nome CD:"></asp:Label>
        <br />
        <asp:TextBox ID="txtnomecd" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Preço de Venda:"></asp:Label>
        <br />
        <asp:TextBox ID="txtpreco" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Data Lançamento:"></asp:Label>
        <br />
        <asp:TextBox ID="txtdata" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Nome da Música:"></asp:Label>
        <br />
        <asp:TextBox ID="txtnomemusica" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Nome do Autor:"></asp:Label>
        <br />
        <asp:TextBox ID="txtnomeautor" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btncriar" runat="server" Text="Criar" OnClick="btncriar_Click" />
        <asp:Button ID="btnpesquisar" runat="server" Text="Pesquisar" OnClick="btnpesquisar_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" EnableViewState="false" runat="server" Height="138px" Width="330px" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:CommandField HeaderText="Ações" ShowEditButton="true" ShowDeleteButton="true"/>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
