<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.TipoDocumento.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Nombre del Tipo de Identificación del Puesto</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" MaxLength="50" runat="server" ID="TIPO_DOCUMENTO_PUESTO_NOMBRE" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select" runat="server" ID="TIPO_DOCUMENTO_PUESTO_ESTADO"  >
        <asp:ListItem Text="-- Selecciona un Estado --" Value="" />
        <asp:ListItem Value="1">Activo</asp:ListItem>
        <asp:ListItem Value="0">Inactivo</asp:ListItem>
    </asp:DropDownList>
        
    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
            
</asp:Content>
