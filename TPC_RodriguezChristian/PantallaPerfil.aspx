<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaPerfil.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container-fluid" style="margin-top:30px">
        <div class="jumbotron" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
   
    <asp:Button ID="btnMisVentas" runat="server" Text="Mis ventas" Onclick="btnMisVentas_Click" CssClass="btn btn-primary"/>
    <asp:Button ID="btnMisCompras" runat="server" Text="Mis compras" Onclick="btnMisCompras_Click" CssClass="btn btn-primary"/>
    <asp:Button ID="btnMisProductos" runat="server" Text="Mis productos" Onclick="btnMisProductos_Click" CssClass="btn btn-primary"/>
    <asp:Button ID="btnComprasPendientes" runat="server" Text="Ventas pendientes de pago" Onclick="btnComprasPendientes_Click" CssClass="btn btn-primary"/>
    <asp:Button ID="btnMisDatos" runat="server" Text="Mis Datos" Onclick="btnMisDatos_Click" CssClass="btn btn-primary" />
            </div>
          </div>
    </asp:Content>

