<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.TipoArea.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Identificación del Tipo de Area</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="TIPO_AREA_IDENTIFICACION" />
    <label>Nombre del Tipo de Area</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="TIPO_AREA_NOMBRE" />
    <label>Observacion</label>
    <asp:TextBox CssClass="form-control flex-wrap mt-1" TextMode="MultiLine" Rows="4"  runat="server" ID="TIPO_AREA_OBSERVACION" /> 
   
    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
