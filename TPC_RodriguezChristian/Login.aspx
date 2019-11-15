<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="TPC_RodriguezChristian.Login" %>

<asp:Content ID="head" ContentPlaceHolderID="cuerpo" runat="server">

    <script>
        function validar() {

            var nombre = document.getElementById("txtUsuario").value;
            var clave = document.getElementById("txtClave").value;

            if (nombre === "" || clave === "") {
                alert("Debes completar este campo");
                return false;
            }

            return true;

        }
        </script>

    </asp:Content>

    

	

   
	
	