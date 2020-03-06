<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PantallaCrearUsuario.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaCrearUsuario" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="Ajax" %>

 <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>


    <script>      
        function validar() {                 
            var contraseña = document.getElementById("txtClave").value;
            var dni = document.getElementById("txtDni").value;
            var apellido = document.getElementById("txtApellido").value;
            var nombre = document.getElementById("txtNombre").value;
            var email = document.getElementById("txtEmail").value;
            var telefono = document.getElementById("txtTelefono").value;
            valido = true;
          
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
<script>
    function verificarNombreDeUsuario() {
        var spancheck = document.getElementById('<%=spancheck.ClientID %>')
        var usuario = document.getElementById('<%=txtNombreDeUsuario.ClientID %>').value;
        var valido = Page.Methods.verificarUsuario(usuario);
        
        if (valido == true)
        {
          alert('Cannot process your request at the moment, please try later.');
        }
        else
        {
            alert('Cannot process your request at the moment, please try later.');
        }
</script>



     
  <div style="margin-right:500px;margin-left:30px">
    <div class="form-group" style="margin-top:30px">
        
        <form id="frm" runat="server"> 

      <div class="form-group">
        <asp:Label ID="lblNombreDeUsuario"  Text="Nombre de usuario" runat="server"></asp:Label>
    
          <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
          <div> 
              <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                        <asp:TextBox ID="txtNombreDeUsuario" CssClass="form-control" runat="server" AutoPostBack="true" OnTextChanged="txtNombreDeUsuario_TextChanged"></asp:TextBox>
                    <span id="spancheck" runat="server" visible="false">
                        <div class="alert alert-warning" role="alert" id="miDiv">
 <asp:Label id="lblcheckUsuario" runat="server" Text="Label" ></asp:Label>
</div>
                        </span>
                 
                
      
    
       
      <div class="form-group">
        <asp:Label ID="lblClave"  Text="Contraseña" runat="server"></asp:Label>
        <asp:TextBox ID="txtClave"  ClientIDMode="Static" CssClass="form-control" runat="server"></asp:TextBox>
           </div>

    <div class="form-group">
    
        <asp:Label ID="lblDni"  Text="Dni" runat="server"></asp:Label>
        <asp:TextBox ID="txtDni"  ClientIDMode="Static" CssClass="form-control" runat="server" input type="number"></asp:TextBox>
       
        </div>

     

    <div class="form-group">
          <asp:Label ID="lblApellido"  Text="Apellido" runat="server"></asp:Label>
          <asp:TextBox ID="txtApellido" ClientIDMode="Static" CssClass="form-control" runat="server" ></asp:TextBox>
         </div>

    <div class="form-group">

        <asp:Label ID="lblNombre"  Text="Nombre" runat="server"></asp:Label>
        <asp:TextBox ID="txtNombre"  ClientIDMode="Static" CssClass="form-control" runat="server" ></asp:TextBox>
        </div>
    
    <div class="form-group">
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="txtEmail"   ClientIDMode="Static" CssClass="form-control" runat="server"></asp:TextBox>
        <small id="emailHelp" class="form-text text-muted">No compartiremos tu email con nadie.</small>
      
  </div>
        
     

    <div class="form-group">
             <asp:Label ID="lblTelefono"  Text="Telefono" runat="server" required></asp:Label>
        <asp:TextBox ID="txtTelefono"   ClientIDMode="Static" CssClass="form-control" runat="server" input type="number"></asp:TextBox>

        </div>
        
        
      
   
   

   <asp:Button ID="btnCrear"  Text="Aceptar" OnClientClick="return validar(); verificarNombreDeUsuario();" OnClick="btnCrear_Click" CssClass="btn btn-primary" runat="server" style="margin-left:30px"/>

   <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="btn btn-primary"/>

                    <div>
    <asp:Label ID="lblExitoUsuario" runat="server" Text="Usuario creado correctamente!" CssClass="alert-success" Visible="false"></asp:Label>
</div>
                    </ContentTemplate>
                   </asp:UpdatePanel>
                  </div>     
              </div>      
        </div>
             </div >

     </form>


    
    
    



