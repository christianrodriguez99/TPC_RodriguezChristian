<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SegundaPantalla.aspx.cs" Inherits="TPC_RodriguezChristian.SegundaPantalla" %>


<asp:Content ID="head" ContentPlaceHolderID="cuerpo" runat="server">

    <asp:Button ID="btnCargarPublicacion" runat="server" Text="Cargar nueva publicacion" OnClick="btnCargar_Click"  />
    <asp:Button ID="btnListar" runat="server" Text="Listar productos" OnClick="btnListar_Click" />
    <asp:Button ID="btnPerfil" runat="server" Text="Mi perfil" OnClick="btnPerfil_Click" />

    </asp:Content>

