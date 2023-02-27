<%@ Page Title="Gestión de Estatus Legal" Language="C#" MasterPageFile="~/Forms.Master" MaintainScrollPositionOnPostBack="true" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.EstatusLegal.EstatusLegal.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Fecha Ocupación</label>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Calendar CssClass="form-control" runat="server" ID="ESTATUS_LEGAL_FECHA_OCUPACION" TitleFormat="MonthYear"  />
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ESTATUS_LEGAL_FECHA_OCUPACION" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Historial</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_HISTORIAL" />
    <label>Estado Adjudicado</label>
    <asp:DropDownList CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_ESTADO_ADJUDICADO" />
    <label>Numero del Puesto Adjudicado</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_NUMERO_PUESTO_ADJUDICADO" />
    <label>Condición de Uso</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_CONDICION_USO" />
    <label>Carta de Adjudicación</label>
    <asp:FileUpload CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_CARTA_ADJUDICACION" />
    <label>Fecha de Notificación</label>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
    <asp:Calendar CssClass="form-control " runat="server" ID="ESTATUS_LEGAL_FECHA_NOTIFICACION" />
            </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ESTATUS_LEGAL_FECHA_NOTIFICACION" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Notificación de Acta de Resolucion</label>
    <asp:FileUpload CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_NOTIFICACION_ACTA_RESOLUCION" />
    <label>Fecha de Notificación de Acta de Resolucion</label>
    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
        <ContentTemplate>
    <asp:Calendar CssClass="form-control" runat="server" ID="ESTATUS_LEGAL_FECHA_NOTIFICACION_ACTA_RESOLUCION" />
            </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ESTATUS_LEGAL_FECHA_NOTIFICACION_ACTA_RESOLUCION" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Nombre de Convenio</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_NOMBRE_CONVENIO" />
    <label>Numero de Convenio</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_NUMERO_CONVENIO" />
    <label>Fecha de Convenio</label>
     <asp:UpdatePanel ID="UpdatePanel4" runat="server">
        <ContentTemplate>
    <asp:Calendar CssClass="form-control " runat="server" ID="ESTATUS_LEGAL_FECHA_CONVENIO" />
            </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ESTATUS_LEGAL_FECHA_CONVENIO" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Condición</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_CONDICION" />
    <label>Cambio de Giro</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_CAMBIO_GIRO" />
    <label>Numero de Cambio de Giro</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_NUMERO_OFICIO_CAMBIO_GIRO" />
    <label>Fecha de Cambio de Giro</label>
     <asp:UpdatePanel ID="UpdatePanel5" runat="server">
        <ContentTemplate>
    <asp:Calendar CssClass="form-control " runat="server" ID="ESTATUS_LEGAL_FECHA_CAMBIO_GIRO" />
            </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ESTATUS_LEGAL_FECHA_CAMBIO_GIRO" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <label>Sanciones</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_SANCIONES" />
    <label>Numero de Resolución de Sanción</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="ESTATUS_LEGAL_NUMERO_RESOLUCION_SANCION" />
    <label>Fecha de Resolución de Sanción</label>
     <asp:UpdatePanel ID="UpdatePanel6" runat="server">
        <ContentTemplate>
    <asp:Calendar CssClass="form-control " runat="server" ID="ESTATUS_LEGAL_FECHA_RESOLUCION_SANCION" />
            </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ESTATUS_LEGAL_FECHA_RESOLUCION_SANCION" EventName="SelectionChanged" />
        </Triggers>
    </asp:UpdatePanel>
    

    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
