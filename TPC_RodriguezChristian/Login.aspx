<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPC_RodriguezChristian.Login" %>

 <form id="frm" runat="server">
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
     <div class="container-fluid">
        <div class="jumbotron" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000; margin-top: 30px;">
   
        <asp:Label ID="lblNombreDeUsuario" runat="server" Text="Nombre de usuario"></asp:Label>
        <asp:TextBox ID="txtNombreDeUsuario" runat="server"></asp:TextBox>
    
        <asp:Label ID="lblClave" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="txtClave" runat="server" TextMode="Password" ></asp:TextBox>

            <asp:Button ID="btnCrear" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" CssClass="btn btn-primary"/>

            </div>
         </div>
     <asp:Label ID="lblIncorrecto" runat="server" Text="Nombre y/o contraseña incorrectos" CssClass="alert-warning" Visible="false"></asp:Label>
    
    <br />
    <br />
    <div style="margin-left: 20px">
    <asp:Label ID="Label1" runat="server" Text="No tienes cuenta?"></asp:Label>
    <asp:Button ID="Button1" runat="server" Text="Crear Usuario" OnClick="btnCrear_Click" CssClass="btn btn-primary"/>
        </div>
     </form>
   

    

    

	

   
	
	