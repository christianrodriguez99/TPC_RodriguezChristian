<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaCrearPublicacion.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaCrearPublicacion" %>


<asp:Content ID="head" ContentPlaceHolderID="cuerpo" runat="server">
     
      <link href="Content/bootstrap.css" rel="stylesheet" />

    <div class="container-fluid">
        <div class="jumbotron" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
   
        <asp:Label ID="lblTitulo" runat="server" Text="Nombre de la publicacion"></asp:Label>
        <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
    
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
    
        <asp:Label ID="lblImagen" runat="server" Text="Imagen"></asp:Label>
        <asp:TextBox ID="txtImagen" runat="server"></asp:TextBox>

          <asp:Label ID="lblPrecio" runat="server" Text="Precio"></asp:Label>
          <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>

        <asp:Label ID="lblStock" runat="server" Text="Cantidad"></asp:Label>
        <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
    
        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
        <asp:DropDownList ID="cboEstados" runat="server"></asp:DropDownList>
   
        <asp:Label ID="lblMarca" runat="server" Text="Marca"></asp:Label>
        <asp:DropDownList ID="cboMarcas" runat="server" ></asp:DropDownList>
    
        <asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
        <asp:DropDownList ID="cboCategorias" runat="server"></asp:DropDownList>
    </div>
        </div>

    <asp:Button ID="btnCrear" runat="server" Text="Crear publicacion" OnClick="btnCrear_Click" CssClass="btn-default btn active center-block"/>
    

    </asp:Content>

