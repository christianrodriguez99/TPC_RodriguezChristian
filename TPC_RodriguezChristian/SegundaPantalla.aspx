<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SegundaPantalla.aspx.cs" Inherits="TPC_RodriguezChristian.SegundaPantalla" %>


<asp:Content ID="head" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container-fluid" style="margin-top:20px">
        <div class="jumbotron" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
    <asp:Button ID="btnCargarPublicacion" runat="server" Text="Cargar nueva publicacion" OnClick="btnCargar_Click" class="btn btn-primary btn-sm"  />
    <asp:Button ID="btnListar" runat="server" Text="Listar productos" OnClick="btnListar_Click" class="btn btn-primary btn-sm" />
    <asp:Button ID="btnPerfil" runat="server" Text="Mi perfil" OnClick="btnPerfil_Click" class="btn btn-primary btn-sm" />
            </div>
          </div>
    </asp:Content>

