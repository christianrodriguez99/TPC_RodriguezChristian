<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaListarProductos.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaListarProductos" %>


<asp:Content ID="head" ContentPlaceHolderID="cuerpo" runat="server">

     <h1>Lista Publicaciones</h1>

   

    <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">

      <asp:Repeater runat="server" ID="rptOutter"  >
            <ItemTemplate>
                <div class="card">
                <p><%#Eval("titulo")%> </p>
                <p><%#Eval("descripcion")%> </p>
           
                    </div>
                    <a class="btn btn-primary" href="PublicacionDetail.aspx?id=<%#Eval("Id")%>">Seleccionar</a>
                </div>
            </ItemTemplate>
        </asp:Repeater>

    </div>



</asp:Content>