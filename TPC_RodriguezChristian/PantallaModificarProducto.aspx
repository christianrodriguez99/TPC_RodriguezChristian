<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaModificarProducto.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaModificarProducto" %>

<asp:Content ID="Default" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     

    <div style="margin-right:500px;margin-left:30px">
    <div class="form-group" style="margin-top:30px">
    
   <div class="form-group">
        <asp:Label ID="lblTitulo" runat="server" Text="Nombre de la publicacion"></asp:Label>
        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control"></asp:TextBox>
       </div>

    <div class="form-group">
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
    
        <div class="form-group">
        <asp:Label ID="lblImagen" runat="server" Text="Imagen"></asp:Label>
        <asp:TextBox ID="txtImagen" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        <div class="form-group">
          <asp:Label ID="lblPrecio" runat="server" Text="Precio"></asp:Label>
          <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" Text="<% = publicacion.precio %>"></asp:TextBox>
            <asp:Label ID="lblErrorPrecio" runat="server" Text="El precio debe contener numeros" CssClass="alert-warning" Visible ="false"></asp:Label>
            </div>

        <div class="form-group">
        <asp:Label ID="lblStock" runat="server" Text="Cantidad"></asp:Label>
        <asp:TextBox ID="txtStock" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:Label ID="lblErrorStock" runat="server" Text="El stock debe contener numeros" CssClass="alert-warning" Visible ="false"></asp:Label>
            </div>
    
        <div class="form-group">
        <asp:Label ID="lblEstado" runat="server" Text="Estado"></asp:Label>
        <asp:DropDownList ID="cboEstados" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
   
        <div class="form-group">
        <asp:Label ID="lblMarca" runat="server" Text="Marca"></asp:Label>
        <asp:DropDownList ID="cboMarcas" runat="server" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
            </div>
    
        <div class="form-group">
        <asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
        <asp:DropDownList ID="cboCategorias" runat="server"  AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
            </div>
    </div>
        </div>
    <div style="margin-left:30px">
    <asp:Button ID="btnModificar" runat="server" Text="Modificar publicacion" OnClick="btnModificar_Click" CssClass="btn btn-primary"/>
      
    </div>
    <div>
        <asp:Label ID="lblExitoPublicacion" runat="server" Text="La publicacion ha sido modificida con exito" CssClass="alert-success" Visible="false"></asp:Label>

    </div>
     
           

        

    </asp:Content>
