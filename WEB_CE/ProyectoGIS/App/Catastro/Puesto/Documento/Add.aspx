<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Documento.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Tipo de Documento</label>
    <asp:DropDownList CssClass="form-control mb-4 mt-2" runat="server" ID="TIPO_DOCUMENTO_PUESTO_ID" />
    <label>Puesto</label>
    <asp:DropDownList CssClass="form-control mb-4 mt-2" runat="server" ID="PUESTO_ID" />
    <label>Nombre del Documento de Puesto</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="TIPO_DOCUMENTO_PUESTO_NOMBRE" />
    <label>Fecha del Documento de Puesto</label>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <asp:Calendar CssClass="form-control " runat="server" ID="DOCUMENTO_PUESTO_FECHA" />
            </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="DOCUMENTO_PUESTO_FECHA" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Archivo</label>
     <asp:FileUpload CssClass="form-control mb-4 mt-2" runat="server" ID="DOCUMENTO_PUESTO_ARCHIVO" />
    <label>Detalle</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="DOCUMENTO_PUESTO_DETALLE" />

    <label>Observacion</label>
    <asp:TextBox CssClass="form-control flex-wrap mt-1" TextMode="MultiLine" Rows="4"  runat="server" ID="DOCUMENTO_PUESTO_OBSERVACION" /> 
   
    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
