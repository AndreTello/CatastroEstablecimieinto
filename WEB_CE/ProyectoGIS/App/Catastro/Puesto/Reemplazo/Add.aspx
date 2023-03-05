<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Reemplazo.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Cedula del Reemplazo</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="REEMPLAZO_CEDULA" />
    <label>Apellidos del Reemplazo</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="REEMPLAZO_APELLIDOS" />
    <label>Nombres del Reemplazo</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="REEMPLAZO_NOMBRES" />
    <label>Autorización del Reemplazo</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="REEMPLAZO_AUTORIZACION" />
    <label>Numero de Oficio del Reemplazo</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="REEMPLAZO_NUMERO_OFICIO" />
    <label>Fecha de Inicio</label>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Calendar CssClass="form-control " runat="server" ID="REEMPLAZO_FECHA_INICIO" />
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="REEMPLAZO_FECHA_INICIO" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Fecha de Fin</label>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:Calendar CssClass="form-control " runat="server" ID="REEMPLAZO_FECHA_FIN" />
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="REEMPLAZO_FECHA_FIN" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Estado</label>
    <asp:DropDownList CssClass="form-control mb-4 mt-2" runat="server" ID="REEMPLAZO_ESTADO" />
        
   <asp:UpdatePanel ID="UpdatePanel3" runat="server">
        <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
