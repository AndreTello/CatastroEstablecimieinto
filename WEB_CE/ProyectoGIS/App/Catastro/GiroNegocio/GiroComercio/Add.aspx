<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.GiroNegocio.GiroComercio.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Tipo de Producto</label>
    <asp:DropDownList CssClass="form-control mt-1" runat="server" ID="TIPO_PRODUCTO_ID" />
    <label>Nombre del Giro de Negocio</label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="GIRO_NEGOCIO_NOMBRE" />
    <label>SubGiros</label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="GIRO_NEGOCIO_SUBGIROS" />
    <label>Abastecimiento</label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="GIRO_NEGOCIO_ABASTECIMIENTO" />
    <label>Observación</label>
    <asp:TextBox CssClass="form-control flex-wrap mt-1" TextMode="MultiLine" Rows="4"  runat="server" ID="GIRO_NEGOCIO_OBSERVACION" /> 
    <label>Estado</label>
    <asp:DropDownList CssClass="form-control mt-1" runat="server" ID="GIRO_NEGOCIO_ESTADO" />

    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
