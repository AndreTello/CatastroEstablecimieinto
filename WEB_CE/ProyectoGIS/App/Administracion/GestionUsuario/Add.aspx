<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Administracion.GestionUsuario.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Rol</label>
    <asp:DropDownList CssClass="form-select" ID="ROL_ID" runat="server"/>
    <label>Usuario</label>
    <asp:TextBox CssClass="form-control" runat="server" ID="USUARIO_LOGIN" />
    <label>Clave</label>
    <asp:TextBox TextMode="Password" CssClass="form-control" runat="server" ID="USUARIO_CLAVE" />
    <label>Cedula</label>
    <asp:TextBox CssClass="form-control" runat="server" ID="USUARIO_CEDULA" />
    <label>Apellidos</label>
    <asp:TextBox CssClass="form-control" runat="server" ID="USUARIO_APELLIDOS" />
    <label>Nombres</label>
    <asp:TextBox CssClass="form-control" runat="server" ID="USUARIO_NOMBRES" />
    <label>Mail</label>
    <asp:TextBox CssClass="form-control" runat="server" ID="USUARIO_MAIL" />
    <label>Dirección</label>
    <asp:TextBox CssClass="form-control" runat="server" ID="USUARIO_DIRECCION" />
    <label>Telefono</label>
    <asp:TextBox CssClass="form-control" runat="server" ID="USUARIO_TELEFONO" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select" runat="server" ID="USUARIO_ESTADO"  >
        <asp:ListItem Text="-- Selecciona un Estado --" Value="" />
        <asp:ListItem Value="1">Activo</asp:ListItem>
        <asp:ListItem Value="0">Inactivo</asp:ListItem>
    </asp:DropDownList>


    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-primary mt-3" OnClick="btnGuardar_Click" />
    <a class="btn btn-danger mt-3" href="./GestionUsuario" >Cancelar</a>



</asp:Content>
