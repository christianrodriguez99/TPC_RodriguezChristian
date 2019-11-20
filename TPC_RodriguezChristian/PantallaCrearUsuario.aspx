<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaCrearUsuario.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaCrearUsuario" %>


<asp:Content ID="head" ContentPlaceHolderID="cuerpo" runat="server">
  

     <link href="Content/bootstrap.css" rel="stylesheet" />

    <div class="container-fluid">
        
        <div class="jumbotron" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
        <asp:Label ID="lblNombreDeUsuario" runat="server" Text="Nombre del usuario" ></asp:Label>
        <asp:TextBox ID="txtNombreDeUsuario" runat="server" ></asp:TextBox>
    
        <asp:Label ID="lblClave" runat="server" Text="Contraseña" ></asp:Label>
        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
    
        <asp:Label ID="lblDni" runat="server" Text="Dni"></asp:Label>
        <asp:TextBox ID="txtDni" runat="server"></asp:TextBox>

          <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
          <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>

        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
             <asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            
   
   
            </div>
    </div>

   <asp:Button ID="btnCrear" runat="server" Text="Aceptar" OnClick="btnCrear_Click" CssClass="btn-default btn active center-block"/>
    

    </asp:Content>

