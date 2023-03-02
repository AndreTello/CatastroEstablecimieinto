<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Mercado.Provincia.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <label>Codigo de la Provincia </label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="PROVINCIA_CODIGO"  />
    <label>Nombre de la Provincia </label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="PROVINCIA_NOMBRE" />
    <label>Estado </label>
    <asp:DropDownList CssClass="form-select mt-1" runat="server" ID="PROVINCIA_ESTADO" />
    <label>Observaciòn</label>

    <asp:TextBox CssClass="form-control flex-wrap mt-1" TextMode="MultiLine" Rows="4"  runat="server" ID="PROVINCIA_OBSERVACION" />
    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
