<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Intervencion.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Tipo de Intervención</label>
    <asp:DropDownList CssClass="form-select mt-1" runat="server" ID="TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID" />
    <label>Nombre del Tipo Intervención </label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE" />
    <label>Fecha de Inicio </label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO" />
    <label>Fecha de Fin </label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN" />
    


    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
