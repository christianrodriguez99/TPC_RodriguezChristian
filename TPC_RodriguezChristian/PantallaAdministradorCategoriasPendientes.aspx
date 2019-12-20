<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Site.Master" CodeBehind="PantallaAdministradorCategoriasPendientes.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaAdministradorPendientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1 class="text-center">Administrador. -Categorias Pendientes</h1>

    <asp:Label ID="Label1" runat="server" Text="No tienes categorias/marcas pendientes" Visible="false"  ></asp:Label>
       
        <div class=" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
      <asp:Repeater runat="server" ID="rptOutter"  >
            <ItemTemplate>
                <div class="card">
                    <div class="card-body">
                <h5 class="card-title">El usuario: <%#Eval("usuario.nombreDeUsuario")%> </h5>
                        <p class="card-text">Solicito agregar: <%#Eval("nombre")%> </p>
        <asp:Button ID="btnAceptar" CssClass="btn btn-primary" Text="Aceptar categoria" Onclick="btnAceptar_Click" CommandArgument='<%#Eval("nombre")+";"+ Eval("id")+";"+ Eval("usuario.id")%>' CommandName="idCategoriaPendienteAceptada" runat="server"  />
<asp:Button ID="btnRechazar" CssClass="btn btn-primary" Text="Rechazar categoria" Onclick="btnRechazar_Click" CommandArgument='<%#Eval("nombre")+";"+ Eval("id")+";"+ Eval("usuario.id")%>' CommandName="idCategoriaPendienteRechazada" runat="server"  />
                    
                    
                    </div>
                    
                
            </ItemTemplate>
        </asp:Repeater>
            <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="btn btn-primary" />
            </div>
           


        </asp:Content>