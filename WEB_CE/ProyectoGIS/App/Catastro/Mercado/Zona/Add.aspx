<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Zona.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Canton</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="CANTON_ID" />
    <label>Codigo de la Zona </label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="3" runat="server" ID="ZONA_CODIGO"  />
    <label>Nombre de la Zona </label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="50" runat="server" ID="ZONA_NOMBRE" />
    <label>Estado </label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="ZONA_ESTADO" />
    <label>Observaciòn</label>

    <asp:TextBox CssClass="form-control flex-wrap mb-3 mt-2" TextMode="MultiLine" Rows="4"  runat="server" ID="ZONA_OBSERVACION" />
    <asp:UpdatePanel runat="server">
         <ContentTemplate>
    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar"   onClick="btnGuardar_Click" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
             </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
