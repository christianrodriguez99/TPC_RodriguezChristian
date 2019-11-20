<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaListarPublicaciones.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaListarProductos" %>


<asp:Content ID="head" ContentPlaceHolderID="cuerpo" runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" />
     <h1>Lista Publicaciones</h1>
        <div class="container-fluid">
        <div class="jumbotron" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
   
   

   

      <asp:Repeater runat="server" ID="rptOutter"  >
            <ItemTemplate>
                <div class="card">
                    <img src="<%#Eval("urlImagen") %>" class="card-img-top" alt="...">
                    <div class="card-body">
                <h5 class="card-title"><%#Eval("titulo")%> </h5>
                <p class="card-text"><%#Eval("descripcion")%> </p>
           </div>
                   
                    <a class="btn btn-primary" href="PublicacionDetalles.aspx?id=<%#Eval("Id")%>">Detalles</a>
                    
                    </div>
                
            </ItemTemplate>
        </asp:Repeater>
            
            </div>
            </div>



</asp:Content>