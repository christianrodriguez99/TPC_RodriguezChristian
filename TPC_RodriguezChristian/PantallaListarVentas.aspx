<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaListarVentas.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaListarVentas" %>

<asp:Content ID="PantallaListarMisProductos" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h1 class="text-center">Mis Publicaciones</h1>


       
        <div class=" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
      <asp:Repeater runat="server" ID="rptOutter"  >
            <ItemTemplate>
                <div class="card">
                    <div class="card-body">
                <h5 class="card-title"><%#Eval("publicacion.titulo")%> </h5>
                <p class="card-text"><%#Eval("cantidad")%> </p>
                       <p class="card-text"><%#Eval("precioTotal")%> </p>
      
                              
                    </div>
                
            </ItemTemplate>
        </asp:Repeater>
            
            </div>
           



</asp:Content>