<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Site.Master" CodeBehind="PantallaNotificacion.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaNotificiacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1 class="text-center">Notificaciones</h1>

    <asp:Label ID="Label1" runat="server" Text="No tienes notificaciones" Visible="false"  ></asp:Label>
       
        <div class=" style="border:1px solid #808080 ;box-shadow: 0px 2px 5px #000000;">
      <asp:Repeater runat="server" ID="rptOutter"  >
            <ItemTemplate>
                <div class="card">
                    <div class="card-body">
                     <p class="card-text"> <%#Eval("descripcion")%></p>

                                   
                    </div>
                    
                
            </ItemTemplate>
        </asp:Repeater>
            
            </div>
           


        </asp:Content>