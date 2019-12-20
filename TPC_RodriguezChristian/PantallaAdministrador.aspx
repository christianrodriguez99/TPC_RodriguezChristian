<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaAdministrador.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaAdministrador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:Button ID="btnMarcasPendientes" runat="server" Text="Marcas" OnClick="btnMarcasPendientes_Click" CssClass="btn btn-primary" />
    <asp:Button ID="btnCategoriasPendientes" runat="server" Text="Categorias" OnClick="btnCategoriasPendientes_Click" CssClass="btn btn-primary"/>
        </div>
    </asp:Content>