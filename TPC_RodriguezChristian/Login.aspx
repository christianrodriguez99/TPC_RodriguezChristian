<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="TPC_RodriguezChristian.Login" %>

<asp:Content ID="head" ContentPlaceHolderID="cuerpo" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
     <div class="container-fluid">
        <div class="jumbotron" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
   
        <asp:Label ID="lblNombreDeUsuario" runat="server" Text="Nombre de usuario"></asp:Label>
        <asp:TextBox ID="txtNombreDeUsuario" runat="server"></asp:TextBox>
    
        <asp:Label ID="lblClave" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>

            <asp:Button ID="btnCrear" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" CssClass="btn-default btn active right-block"/>

            </div>
         </div>
    
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Crear Usuario" OnClick="btnCrear_Click" CssClass="btn-default btn active center-block"/>
   

    </asp:Content>

    

	

   
	
	