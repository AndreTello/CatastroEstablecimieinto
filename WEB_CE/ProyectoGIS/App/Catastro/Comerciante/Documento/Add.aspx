<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Comerciante.Documento.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Tipo de Documento</label>
    <asp:DropDownList CssClass="form-select  mb-3 mt-2" ID="TIPO_DOCUMENTO" runat="server"/>
    <label>Comerciante</label>
    <asp:DropDownList CssClass="form-select  mb-3 mt-2" ID="COMERCIANTE_ID" runat="server"/>
    <label>Nombre del Documento</label>
    <asp:TextBox CssClass="form-control  mb-3 mt-2" ID="DOCUMENTO_NOMBRE" runat="server"/>
    <label>Fecha</label>
     <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Calendar CssClass="form-control " runat="server"  ID="DOCUMENTO_FECHA"  /> 
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="DOCUMENTO_FECHA" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Detalle</label>
    <asp:TextBox CssClass="form-control  mb-3 mt-2" ID="DOCUMENTO_DETALLE" runat="server"/>
    <label>Observación</label>  
    <asp:TextBox CssClass="form-control  mb-3 mt-2" TextMode="MultiLine" Rows="4" ID="DOCUMENTO_OBSERVACION" runat="server"/>
    <asp:DropDownList CssClass="form-select" runat="server" ID="DOCUMENTO_ESTADO"  >
        <asp:ListItem Text="-- Selecciona un Estado --"  Value=""/>
        <asp:ListItem Value="1">Activo</asp:ListItem>
        <asp:ListItem Value="0">Inactivo</asp:ListItem>
    </asp:DropDownList>

    <asp:Button CssClass="btn btn-primary mt-3" ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
