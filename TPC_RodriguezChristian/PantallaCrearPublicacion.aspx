<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaCrearPublicacion.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaCrearPublicacion" %>


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
          <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control"></asp:TextBox>
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
        <asp:DropDownList ID="cboMarcas" runat="server" OnSelectedIndexChanged="cboMarcas_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
            </div>
    
        <div class="form-group">
        <asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
        <asp:DropDownList ID="cboCategorias" runat="server" OnSelectedIndexChanged="cboCategorias_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control"></asp:DropDownList>
            </div>
    </div>
        </div>
    <div style="margin-left:30px">
    <asp:Button ID="btnCrear" runat="server" Text="Crear publicacion" OnClick="btnCrear_Click" CssClass="btn btn-primary"/>
    <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="btn btn-primary"/>
      
    </div>
    <div>
        <asp:Label ID="lblExitoPublicacion" runat="server" Text="La publicacion ha sido creada con exito" CssClass="alert-success" Visible="false"></asp:Label>

    </div>
     
    <asp:Label ID="lblAgregarCategoria" runat="server" Text="Solicitud para agregar categoria con nombre:" Visible="false"></asp:Label>
    <asp:TextBox ID="txtNuevaCategoria" runat="server" Visible="false" ></asp:TextBox>
    <asp:Button ID="btnAgregarCategoria" runat="server" Text="Enviar solicitud" CssClass="btn btn-primary" OnClick="btnAgregarCategoria_Click" Visible="false"/>
     <asp:Label ID="lblAgregarCategoriaExito" runat="server" Visible="false" Text="La categoria ha sido solicitada con exito, por favor espere la respuesta de un administrador" CssClass="alert-success"></asp:Label>
     <asp:Label ID="lblAgregarCategoriaError" runat="server" Visible="false" Text="El nombre de categoria ya ha sido solicitado o ya existe" CssClass="alert-warning"></asp:Label>      


    <asp:Label ID="lblAgregarMarca" runat="server" Text="Solicitud para agregar marca con nombre:" Visible="false" ></asp:Label>
    <asp:TextBox ID="txtNuevaMarca" runat="server" Visible="false" ></asp:TextBox>
    <asp:Button ID="btnAgregarMarca" runat="server" Text="Enviar solicitud" CssClass="btn btn-primary" OnClick="btnAgregarMarca_Click" Visible="false"/>
     <asp:Label ID="lblAgregarMarcaExito" runat="server" Visible="false" Text="La marca ha sido solicitada con exito, por favor espere la respuesta de un administrador" CssClass="alert-success" role="alert"></asp:Label>
     <asp:Label ID="lblAgregarMarcaError" runat="server" Visible="false" Text="El nombre de marca ya ha sido solicitado o ya existe" CssClass="alert-warning" role="alert"></asp:Label>
           

            

    </asp:Content>

