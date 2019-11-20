<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PublicacionDetalles.aspx.cs" Inherits="TPC_RodriguezChristian.PublicacionDetalles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <div class="card" style="width: 25%">
            <img src="<% = publicacion.urlImagen %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h3 class="card-title"><% = publicacion.titulo %></h3>
                <p class="card-text"><% = publicacion.descripcion %></p>
                <p class="card-text"><% = publicacion.precio %>$</p>
                <p class="card-text">Quedan <% = publicacion.stock %> unidades</p>
            </div>
        </div>
</asp:Content>