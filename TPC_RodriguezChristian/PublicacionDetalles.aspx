<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PublicacionDetalles.aspx.cs" Inherits="TPC_RodriguezChristian.PublicacionDetalles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card" style="width: 25%;">
            <img src="<% = publicacion.urlImagen %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h3 class="card-title" ><% = publicacion.titulo %></h3>
                <p class="card-text">Descripcion: <% = publicacion.descripcion %></p>
                <p class="card-text"><% = publicacion.precio %>$</p>
                <p class="card-text">Unidades disponibles: <% = publicacion.stock %> unidades</p>
                <p class="card-text">Estado: <% = publicacion.estadoProducto %></p>
            </div>
        </div>

    <asp:Label ID="lblCantidad" runat="server" Text="Ingrese la cantidad a comprar"  ></asp:Label>
<asp:TextBox ID="txtCantidad" runat="server" value="1" ></asp:TextBox>
    <asp:Button ID="btnSiguiente" runat="server" Text="Siguiente" OnClick="btnSiguiente_Click" CssClass="btn btn-primary" />

    <div>
    <asp:Label ID="lblErrorCantidadNumeros" runat="server" Text="La cantidad solo puede contener numeros" Visible="false" ></asp:Label>
   
    <asp:Label ID="lblErrorCantidadStock" runat="server" Text="La cantidad es mayor a el stock" Visible="false" ></asp:Label>
    
    <asp:Label ID="lblErrorCompra" runat="server" Text="No podes comprar un producto tuyo" Visible="false" ></asp:Label>
   
    <asp:Label ID="Label1" runat="server" Text="El precio final es:" Visible="false" ></asp:Label>
    
    <asp:Label ID="lblPrecioFinal" runat="server"  Visible="false" ></asp:Label>
    
     </div>
</asp:Content>