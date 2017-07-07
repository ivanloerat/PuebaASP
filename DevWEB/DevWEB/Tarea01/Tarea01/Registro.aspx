<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Tarea01.Registro" MasterPageFile="~/MasterPage.Master" %>


<asp:Content ID="Content5" ContentPlaceHolderID="Principal" runat="server">
    <table>
       
        <tr>
            <td>Alias</td>
            <td>
                <input type="text" name="txtAlias" id="txtAlias" /></td>
        </tr>
        <tr>
            <td>Nombre</td>
            <td>
                <input type="text" name="txtNombre" id="txtNombre" /></td>
        </tr>
        <tr>
            <td class="auto-style1">Password</td>
            <td class="auto-style1">
                <input type="password" name="txtPass" id="txtPass" /></td>
        </tr>
        <tr>
            <td>TipoUsuario</td>
            <td>
                <select id="selectTipo" name="selectTipo">
                    <option value="1">Administrador</option>
                    <option value="0">Usuario</option>
                </select>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <input type="button" name="btnGuardar" id="btnGuardar" value="Guardar" onclick="ObtenerDatos()" /></td>
            <!--<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <!--DE ESTE TENGO DUDA PORQUE SE TIENE QUE GENERAR, POR AHI INVESTIGUE QUE TE SIRVE COMO PUENTE EN EL JAVASCRIPT-->
            <!--para que sirve ese text? que pasa si no lo pongo?-->

        </tr>
         <tr>
             <td />
            <td>
                <asp:Button ID="btnCerrar" runat="server" Text="Cerrar Sesion" OnClick="btnCerrar_Click" />
            </td>
        </tr>
    </table>

    <script type="text/javascript">
        function ObtenerDatos() {
            //
            var nombre;
            var registro;
            alias = document.getElementById('txtAlias').value;
            nombre = document.getElementById('txtNombre').value;
            password = document.getElementById('txtPass').value;
            tipo = document.getElementById('selectTipo').value;
            $.ajax({
                url: 'Registro.aspx/RegistraUsuario',
                data: "{alias: '" + alias + "', nombre: '" + nombre + "', password: '" + password + "', tipo: '" + tipo + "'}",
                type: "POST",
                contentType: 'application/json; charset=UTF-8',
                dataType: 'json',
                cache: false,
                async: false,
                success: function (resultado) {
                    registro = resultado.d
                }
            });

            alert(registro);
        }
    </script>
</asp:Content>
<asp:Content ID="Content6" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</asp:Content>

