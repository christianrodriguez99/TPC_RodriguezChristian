<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaPerfil.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Button ID="btnMisVentas" runat="server" Text="Cargar nueva publicacion" Onclick="btnMisVentas_Click" />
    <asp:Button ID="btnMisCompras" runat="server" Text="Listar productos" Onclick="btnMisCompras_Click" />
    <asp:Button ID="btnMisDatos" runat="server" Text="Mis Datos" Onclick="btnMisDatos_Click" />

    </asp:Content>

