<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.Genero.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Nombre</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="100" runat="server" ID="GENERO_NOMBRE" />
    <label>Detalle</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" ID="GENERO_DETALLE" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="GENERO_ESTADO" />
    <asp:UpdatePanel runat="server">
         <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
         </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
