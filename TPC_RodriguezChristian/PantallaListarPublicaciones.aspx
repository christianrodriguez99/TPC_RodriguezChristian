<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaListarPublicaciones.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaListarProductos" %>


<asp:Content ID="PantallaListarPublicaciones" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <h1 class="text-center">Lista Publicaciones</h1>


       
        <div class=" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
      <asp:Repeater runat="server" ID="rptOutter"  >
            <ItemTemplate>
                <div class="card">
                    <img src="<%#Eval("urlImagen") %>" class="card-img-top" alt="..." style="max-height:250px;max-width:250px">
                    <div class="card-body">
                <h5 class="card-title"><%#Eval("titulo")%> </h5>
                <p class="card-text"><%#Eval("descripcion")%> </p>
      
                   
                    <a class="btn btn-primary" href="PublicacionDetalles.aspx?id=<%#Eval("Id")%>">Detalles</a>
                    
                    </div>
                
            </ItemTemplate>
        </asp:Repeater>
            
            </div>
            </div>



</asp:Content>