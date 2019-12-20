<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaCrearUsuario.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaCrearUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <script>
        function validar() {
            var nombreDeUsuario = document.getElementById("txtNombreDeUsuario").value;       
            var contraseña = document.getElementById("txtClave").value;
            var dni = document.getElementById("txtDni").value;
            var apellido = document.getElementById("txtApellido").value;
            var nombre = document.getElementById("txtNombre").value;
            var email = document.getElementById("txtEmail").value;
            var telefono = document.getElementById("txtTelefono").value;
            var valido = true;

            if (nombreDeUsuario == '') {
                $("#txtNombreDeUsuario").removeClass("is-valid");
                $("#txtNombreDeUsuario").addClass("is-invalid");
              
                valido = false;
            }
            else
            {
                $("#txtNombreDeUsuario").removeClass("is-invalid");
                $("#txtNombreDeUsuario").addClass("is-valid");            
            }
            if (contraseña === "") {
                $("#txtClave").removeClass("is-valid");
                $("#txtClave").addClass("is-invalid");
                valido = false;
            }
            else
            {
                $("#txtClave").removeClass("is-invalid");
                $("#txtClave").addClass("is-valid");       

            }
            if (dni === "") {
                $("#txtDni").removeClass("is-valid");
                $("#txtDni").addClass("is-invalid");
                
                valido = false;

            }
            else
            {
                $("#txtDni").removeClass("is-invalid");
                $("#txtDni").addClass("is-valid");   
            }
            if (apellido === "") {
                $("#txtApellido").removeClass("is-valid");
                $("#txtApellido").addClass("is-invalid");
                valido = false;

            }
            else {
                $("#txtApellido").removeClass("is-invalid");
                $("#txtApellido").addClass("is-valid");
            }
            if (nombre === "") {
                $("#txtNombre").removeClass("is-valid");
                $("#txtNombre").addClass("is-invalid");
                valido = false;

            }
            else {
                $("#txtNombre").removeClass("is-invalid");
                $("#txtNombre").addClass("is-valid");
            }
            if (email === "") {
                $("#txtEmail").removeClass("is-valid");
                $("#txtEmail").addClass("is-invalid");
                valido = false;

            }
            else {
                $("#txtEmail").removeClass("is-invalid");
                $("#txtEmail").addClass("is-valid");
            }
            if (telefono === "") {
                $("#txtTelefono").removeClass("is-valid");
                $("#txtTelefono").addClass("is-invalid");
                valido = false;

            }
            else {
                $("#txtTelefono").removeClass("is-invalid");
                $("#txtTelefono").addClass("is-valid");
            }

            if (!valido)
            {
                return false;
            }



            return true;


        }

    </script>
    
     <link href="Content/bootstrap.css" rel="stylesheet" />

    <div class="form-group" style="margin-top:30px">
        
       <%-- <div class="jumbotron" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">--%>
        <asp:Label ID="lblNombreDeUsuario"  Text="Nombre de usuario" runat="server"></asp:Label>
        <asp:TextBox ID="txtNombreDeUsuario" ClientIDMode="Static" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
       
      <div class="form-group">
        <asp:Label ID="lblClave"  Text="Contraseña" runat="server"></asp:Label>
        <asp:TextBox ID="txtClave"  ClientIDMode="Static" CssClass="form-control" runat="server"></asp:TextBox>
           </div>

    <div class="form-group">
    
        <asp:Label ID="lblDni"  Text="Dni" runat="server"></asp:Label>
        <asp:TextBox ID="txtDni"  ClientIDMode="Static" CssClass="form-control" runat="server"></asp:TextBox>
        </div>

    <div class="form-group">
          <asp:Label ID="lblApellido"  Text="Apellido" runat="server"></asp:Label>
          <asp:TextBox ID="txtApellido" ClientIDMode="Static" CssClass="form-control" runat="server"   ></asp:TextBox>
         </div>

    <div class="form-group">

        <asp:Label ID="lblNombre"  Text="Nombre" runat="server"></asp:Label>
        <asp:TextBox ID="txtNombre"  ClientIDMode="Static" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
    
    <div class="form-group">
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail"   ClientIDMode="Static" CssClass="form-control" runat="server" ></asp:TextBox>
        <small id="emailHelp" class="form-text text-muted">No compartiremos tu email con nadie.</small>
        </div>
     

    <div class="form-group">
             <asp:Label ID="lblTelefono"  Text="Telefono" runat="server"></asp:Label>
        <asp:TextBox ID="txtTelefono"   ClientIDMode="Static" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
            
   
   
            <%--</div>--%>
    <%--</div>--%>


   <asp:Button ID="btnCrear"  Text="Aceptar" OnClientClick="return validar()" OnClick="btnCrear_Click" CssClass="btn btn-primary" runat="server"/>
        
    
    

    </asp:Content>

