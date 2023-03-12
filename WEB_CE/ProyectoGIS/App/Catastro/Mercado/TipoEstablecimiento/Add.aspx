<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.TipoEstablecimiento.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <label>Nombre del Tipo de Establecimiento</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="50" runat="server" ID="TIPO_ESTABLECIMIENTO_NOMBRE" />
    <label>Detalle</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" ID="TIPO_ESTABLECIMIENTO_DETALLE" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select" runat="server" ID="TIPO_ESTABLECIMIENTO_ESTADO"  >
        <asp:ListItem Text="-- Selecciona un Estado --" Value="" />
        <asp:ListItem Value="1">Activo</asp:ListItem>
        <asp:ListItem Value="0">Inactivo</asp:ListItem>
    </asp:DropDownList>

    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
     
</asp:Content>
