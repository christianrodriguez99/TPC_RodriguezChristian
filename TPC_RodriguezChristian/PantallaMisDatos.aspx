<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaMisDatos.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaMisDatos" %>

<asp:Content ID="PantallaListarMisProductos" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h2 class="text-center"><u>Mis datos</u></h2>

    
        <div class=" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
      <asp:Repeater runat="server" ID="rptOutter"  >
            <ItemTemplate>
                
                <h5>Usuario: <%#Eval("nombreDeUsuario")%> </h5>
                <p>Nombre: <%#Eval("nombre")%> </p>
                  <p>Apellido: <%#Eval("apellido")%> </p>
                <p>Dni: <%#Eval("dni")%> </p>
             <p>Email: <%#Eval("email")%> </p>
                <p>Numero de telefono: <%#Eval("nroTelefono")%> </p>
                   
             <asp:Button ID="btnEliminar" CssClass="btn btn-primary" Text="Eliminar usuario" Onclick="btnEliminar_Click" CommandArgument='<%#Eval("id")%>' CommandName="idEliminar" runat="server"  />
                    
                    </div>
                
            </ItemTemplate>
        </asp:Repeater>
            
            </div>
           



</asp:Content>