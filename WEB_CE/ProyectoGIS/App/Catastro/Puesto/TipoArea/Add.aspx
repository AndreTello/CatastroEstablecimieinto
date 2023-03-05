<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.TipoArea.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Identificación del Tipo de Area</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" MaxLength="5" runat="server" ID="TIPO_AREA_IDENTIFICACION" />
    <label>Nombre del Tipo de Area</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" MaxLength="50" runat="server" ID="TIPO_AREA_NOMBRE" />
    <label>Observacion</label>
    <asp:TextBox CssClass="form-control flex-wrap mt-1" TextMode="MultiLine" Rows="4"  runat="server" ID="TIPO_AREA_OBSERVACION" /> 
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="TIPO_AREA_ESTADO"  />
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
