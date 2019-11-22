<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaComprasPendientes.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaComprasPendientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="text-center">Lista compras Pendientes</h1>


       
        <div class=" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
      <asp:Repeater runat="server" ID="rptOutter"  >
            <ItemTemplate>
                <div class="card">
                    <div class="card-body">
                <h5 class="card-title">Te compraron: <%#Eval("publicacion.titulo")%> </h5>
                        <p class="card-text">Cantidad comprada: <%#Eval("cantidad")%> </p>
                        <p class="card-text">Precio total: <%#Eval("precioTotal")%> </p>
                        <p class="card-text">Comprador: <%#Eval("comprador.nombreDeUsuario")%> </p>
        <asp:Button ID="btnAceptar" CssClass="btn btn-primary" Text="Aceptar venta" Onclick="btnAceptar_Click" CommandArgument='<%#Eval("id")+";"+ Eval("publicacion.id")+";"+ Eval("cantidad")+";"+ Eval("fecha")+";"+ Eval("vendedor.id")+";"+ Eval("comprador.id")+";"+ Eval("preciototal")+";"+ Eval("publicacion.titulo")%>' CommandName="idCompraPendienteAceptada" runat="server"  />
<asp:Button ID="btnRechazar" CssClass="btn btn-primary" Text="Rechazar venta" Onclick="btnRechazar_Click" CommandArgument='<%#Eval("id")+";"+ Eval("publicacion.id")+";"+ Eval("cantidad")%>' CommandName="idCompraPendienteRechazada" runat="server"  />
                    
                    
                    </div>
                
            </ItemTemplate>
        </asp:Repeater>
            
            </div>
           


    </asp:Content>