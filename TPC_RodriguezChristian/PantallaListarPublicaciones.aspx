<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaListarPublicaciones.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaListarProductos" %>


<asp:Content ID="PantallaListarPublicaciones" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Label ID="Label1" runat="server" Text="No hay productos" Visible="false"  ></asp:Label>
     <%--  <asp:Label ID="lblBuscar" runat="server" Text="Buscar: "></asp:Label>
       <asp:TextBox ID="txtBusquedaxNombre" runat="server" AutoPostBack="true" OnTextChanged="txtBusquedaxNombre_TextChanged"></asp:TextBox>--%>


       
       <div class="container">
       <div class="row">
      <asp:Repeater runat="server" ID="rptOutter"  >
            <ItemTemplate>        
                      <div class="col-sm">
                        <div class="card" style="width: 18rem;">
                        <img src="<%#Eval("urlImagen") %>" class="card-img-top" alt="..." style="max-height:250px;max-width:250px">
                         <div class="card-body">
                         <h5 class="card-title"><%#Eval("titulo")%> </h5>
                         <p class="card-text"><%#Eval("descripcion")%> </p>     
                         <a class="btn btn-primary" href="PublicacionDetalles.aspx?id=<%#Eval("Id")%>">Detalles</a>
                         </div>
                        </div>
                      </div>                         
                    
            </ItemTemplate>
      </asp:Repeater>
                        
       </div>
       </div>
       
      
                   
                    
                    
                   
                
           
            
         
           



</asp:Content>