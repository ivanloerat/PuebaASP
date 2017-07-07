<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tarea01.Login" MasterPageFile="~/MasterPage.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="Principal" runat="server">
    <%-- <link href="style.css" rel="stylesheet" type="text/css" />--%>
        <div>
            <table><tr>
                <td>USUARIO: </td>
            <td><asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                <td>CONTRASEÑA: </td>
            <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
            <td><asp:Button ID="btnAceptar" runat="server" Text="Iniciar Sesión" OnClientClick="if(!validaVacio()) return false" OnClick="btnAceptar_Click" /></td>
                    <td></td>
            <td><asp:Label ID="lblError" runat="server" Text="Label" Visible="false"></asp:Label></td>
                    </tr>
                </table>
        </div>

    <script type="text/javascript">

        function validarVacio() {
            var usuario = $("#<%=txtUsuario.ClientID%>").val();
            var pass = $("#<%=txtPassword.ClientID%>").val();
            var lave = document.getElementById("<%=lblError.ClientID%>");
            if (usuario == "") {
                lave.textContent = "Coloque el usuario"
                lave.style.display = "block";
                return false;
            }
            if (pass == "") {
                lave.textContent = "Coloque la contraseña"
                lave.style.display = "block";
                return false;
            }
            lave.style.display = "block";
            lave.textContent = "Validado";
            return true;
        }

    </script>
</asp:Content>