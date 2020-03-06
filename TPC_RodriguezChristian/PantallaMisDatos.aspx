<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaMisDatos.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaMisDatos" %>

<asp:Content ID="PantallaListarMisProductos" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

    
        <div class=" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
      <asp:Repeater runat="server" ID="rptOutter"  >
            <ItemTemplate>

                <div class="card" style="width: 18rem;margin-left:15px;">
                    <div class="card-header">
                <li class="list-group-item">Usuario: <%#Eval("nombreDeUsuario")%> </li>
                        </div>
                     <ul class="list-group list-group-flush">
                <li class="list-group-item">Nombre: <%#Eval("nombre")%> </li>
                  <li class="list-group-item">Apellido: <%#Eval("apellido")%> </li>
                <li class="list-group-item">Dni: <%#Eval("dni")%> </li>
             <li class="list-group-item">Email: <%#Eval("email")%> </li>
                <li class="list-group-item">Numero de telefono: <%#Eval("nroTelefono")%> </li>
                         </ul>
                    </div>
               
             <asp:Button ID="btnEliminar" CssClass="btn btn-primary" Text="Eliminar mi usuario" Onclick="btnEliminar_Click" CommandArgument='<%#Eval("id")%>' CommandName="idEliminar" runat="server" style="margin-top:15px;margin-left:15px;" Visible="false" />
               
                    </div>
                
            </ItemTemplate>
        </asp:Repeater>
            
            </div>
           



</asp:Content>