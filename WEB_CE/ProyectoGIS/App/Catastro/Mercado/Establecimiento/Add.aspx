<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Establecimiento.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Lote</label>
    <asp:DropDownList CssClass="form-select mt-1" runat="server" ID="LOTE_ID" />
    <label>Administración Zonal</label>
    <asp:DropDownList CssClass="form-select mt-1" runat="server" ID="ADMINISTRACION_ZONAL_ID" />
    <label>Tipo de Establecimiento</label>
    <asp:DropDownList CssClass="form-select mt-1" runat="server" ID="TIPO_ESTABLECIMIENTO_ID" />
    <label>Asociación</label>
    <asp:DropDownList CssClass="form-select mt-1" runat="server" ID="ASOCIACION_ID" />
    <label>Intervencion Técnica del Establecimiento</label>
    <asp:DropDownList CssClass="form-select mt-1" runat="server" ID="INTERVENCION_TECNICA_ESTABLECIMIENTO_ID" />
    <label>Predio</label>
    <asp:TextBox CssClass="form-control mt-1" MaxLength="5" runat="server" ID="ESTABLECIMIENTO_PREDIO" />
    <label>Clave Catastral</label>
    <asp:TextBox CssClass="form-control mt-1" MaxLength="20" runat="server" ID="ESTABLECIMIENTO_CLAVE_CATASTRAL" />
    <label>Nomenclatura Vial</label>
    <asp:TextBox CssClass="form-control mt-1" MaxLength="20" runat="server" ID="ESTABLECIMIENTO_NOMENCLATURA_VIAL" />
    <label>Calle Principal</label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" MaxLength="100" ID="ESTABLECIMIENTO_CALLE_PRINCIPAL" />
    <label>Calle Secundaria</label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" MaxLength="100" ID="ESTABLECIMIENTO_CALLE_SECUNDARIA" />
    <label>Parqueadero</label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" MaxLength="10" ID="ESTABLECIMIENTO_PARQUEADERO" />
    <label>Numero de Parqueadero</label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" onkeypress="return isNumberKey(event)" ID="ESTABLECIMIENTO_NUMERO_PARQUEADERO" />
    <label>Dias de Apertura</label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" MaxLength="1" ID="ESTABLECIMIENTO_DIAS_APERTURA" />
    <label>Horario de Atención</label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" MaxLength="100" ID="ESTABLECIMIENTO_HORARIO_ATENCION" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select mt-1" runat="server" ID="ESTABLECIMIENTO_ESTADO" />

    <asp:UpdatePanel runat="server">
         <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
