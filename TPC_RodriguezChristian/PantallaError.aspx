<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PantallaError.aspx.cs" Inherits="TPC_RodriguezChristian.PantallaError" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cuerpo" runat="server">
    <p><% = Session["Error" + Session.SessionID] %></p>
</asp:Content>
