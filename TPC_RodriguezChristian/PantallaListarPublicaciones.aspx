<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaListarPublicaciones.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaListarProductos" %>


<asp:Content ID="PantallaListarPublicaciones" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Label ID="Label1" runat="server" Text="No hay productos" Visible="false"  ></asp:Label>
       <asp:Label ID="lblBuscar" runat="server" Text="Buscar: "></asp:Label>
       <asp:TextBox ID="txtBusquedaxNombre" runat="server" AutoPostBack="true" OnTextChanged="txtBusquedaxNombre_TextChanged"></asp:TextBox>
<asp:DropDownList ID="cboMarcas" runat="server" AutoPostBack="true" OnSelectedIndexChanged="cboMarcas_SelectedIndexChanged">

</asp:DropDownList> <asp:DropDownList ID="cboCategorias" runat="server" AutoPostBack="true" OnSelectedIndexChanged="cboCategorias_SelectedIndexChanged"></asp:DropDownList>


       
        <div class=" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
      <asp:Repeater runat="server" ID="rptOutter"  >
            <ItemTemplate>
                <div class="card">
                    <img src="<%#Eval("urlImagen") %>" class="card-img-top" alt="..." style="max-height:250px;max-width:250px">
                    <div class="card-body">
                <h5 class="card-title"><%#Eval("titulo")%> </h5>
                <p class="card-text"><%#Eval("descripcion")%> </p>
                    <p class="card-text"><%#Eval("estadoProducto")%> </p>
      
                   
                    <a class="btn btn-primary" href="PublicacionDetalles.aspx?id=<%#Eval("Id")%>">Detalles</a>
                    
                    </div>
                
            </ItemTemplate>
        </asp:Repeater>
            
            </div>
           



</asp:Content>