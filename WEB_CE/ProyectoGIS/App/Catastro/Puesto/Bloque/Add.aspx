<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Bloque.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Establecimiento</label>
    <asp:DropDownList CssClass="form-control mb-4 mt-2" runat="server" ID="ESTABLECIMIENTO_ID" />
    <label>Codigo del Bloque</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" MaxLength="4" runat="server" ID="BLOQUE_CODIGO" />
    <label>Nombre del Bloque</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" MaxLength="50" runat="server" ID="BLOQUE_NOMBRE" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-control mb-4 mt-2" runat="server" ID="BLOQUE_ESTADO" />
    <label>Observacion</label>
    <asp:TextBox CssClass="form-control flex-wrap mt-2" TextMode="MultiLine" Rows="4"  runat="server" ID="BLOQUE_OBSERVACION" /> 
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
