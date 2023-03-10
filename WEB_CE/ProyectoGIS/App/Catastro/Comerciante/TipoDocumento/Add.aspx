<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Comerciante.TipoDocumento.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Nombre</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" ID="TIPO_DOCUMENTO_COMERCIANTE_NOMBRE" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select" runat="server" ID="TIPO_DOCUMENTO_COMERCIANTE_ESTADO"  >
        <asp:ListItem Text="-- Selecciona un Estado --"  Value=""/>
        <asp:ListItem Value="1">Activo</asp:ListItem>
        <asp:ListItem Value="0">Inactivo</asp:ListItem>
    </asp:DropDownList>
    <asp:Button CssClass="btn btn-primary mt-3" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
