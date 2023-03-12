<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Administracion.GestionRolPermiso.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Rol</label>
    <asp:DropDownList CssClass="form-control mb-3 mt-2" ID="ROL_ID" runat="server"/>
    <label>Permiso</label>
    <asp:DropDownList CssClass="form-control mb-3 mt-2" ID="PERMISO_ID" runat="server"/>
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" ID="PERMISO_ROL_ESTADO" runat="server">
        <asp:ListItem Text="-- Selecciona un Estado --" Value=""/>
        <asp:ListItem Value="1">Activo</asp:ListItem>
        <asp:ListItem Value="0">Inactivo</asp:ListItem>
    </asp:DropDownList>
    <asp:Button CssClass="btn btn-primary mt-3" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
