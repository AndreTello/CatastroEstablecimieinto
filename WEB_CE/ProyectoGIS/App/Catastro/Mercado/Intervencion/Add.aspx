<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Intervencion.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Tipo de Intervención</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="TIPO_INTERVENCION_TECNICA_ESTABLECIMIENTO_ID" />
    <label>Nombre del Tipo Intervención </label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" MaxLength="50" ID="INTERVENCION_TECNICA_ESTABLECIMIENTO_NOMBRE" />
    <label>Fecha de Inicio </label>
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Calendar CssClass="form-control " runat="server"  ID="INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO"  /> 
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_INICIO" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Fecha de Fin </label>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:Calendar CssClass="form-control" runat="server" ID="INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN" />
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="INTERVENCION_TECNICA_ESTABLECIMIENTO_FECHA_FIN" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Estado</label>
    <asp:DropDownList CssClass="form-control mb-4 mt-2" runat="server" ID="INTERVENCION_TECNICA_ESTABLECIMIENTO_ESTADO" />

    <asp:UpdatePanel runat="server">
         <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
         </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
