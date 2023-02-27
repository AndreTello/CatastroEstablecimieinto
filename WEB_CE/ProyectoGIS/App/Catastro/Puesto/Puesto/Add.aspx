<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Puesto.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Piso</label>
    <asp:DropDownList CssClass="form-select mb-4 mt-2" runat="server" ID="PISO_ID" />
    <label>Tipo de Area</label>
    <asp:DropDownList CssClass="form-select mb-4 mt-2" runat="server" ID="TIPO_AREA_ID" />
    <label>Comerciante</label>
    <asp:DropDownList CssClass="form-select mb-4 mt-2" runat="server" ID="COMERCIANTE_ID" />
    <label>Ayudante</label>
    <asp:DropDownList CssClass="form-select mb-4 mt-2" runat="server" ID="AYUDANTE_ID" />
    <label>Reemplazo</label>
    <asp:DropDownList CssClass="form-select mb-4 mt-2" runat="server" ID="REEMPLAZO_ID" />
    <label>Documento del Puesto</label>
    <asp:DropDownList CssClass="form-select mb-4 mt-2" runat="server" ID="DOCUMENTO_PUESTO_ID" />
    <label>Predio del Puesto</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="PUESTO_PREDIO" />
    <label>Clave Catastral del Puesto</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="PUESTO_CLAVE_CATASTRAL" />
    <label>Area de Puesto</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="PUESTO_AREA" />
    <label>Frente</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="PUESTO_FRENTE" />
    <label>Fondo</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="PUESTO_FONDO" />
    <label>Estado de Conservación del Puesto</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="PUESTO_ESTADO_CONSERVACION" />
    <label>Acabados del Puesto</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="PUESTO_ACABADOS" />
    <label>Paredes del Puesto</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="PUESTO_PAREDES" />
    <label>Remodelación del Puesto</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="PUESTO_REMODELACION" />

    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
