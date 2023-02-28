<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.AdministracionZonal.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Nombre de la Administración Zonal</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="100" runat="server" ID="ADMINISTRACION_ZONAL_NOMBRE" />
    <label>Detalle de la Administración Zonal</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" ID="ADMINISTRACION_ZONAL_DETALLE" />
    <label>Telefono</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="15" onkeypress="return isNumberKey(event)" runat="server" ID="ADMINISTRACION_ZONAL_TELEFONO" />
    <label>Celular</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" onkeypress="return isNumberKey(event)" MaxLength="15" ID="ADMINISTRACION_ZONAL_CELULAR" />
    <label>Mail</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" MaxLength="100" ID="ADMINISTRACION_ZONAL_MAIL" />
    <label>Pagina Web</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" MaxLength="100" ID="ADMINISTRACION_ZONAL_PAGINA_WEB" />
    <label>Representante</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" MaxLength="10" ID="ADMINISTRACION_ZONAL_REPRESENTANTE" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="ADMINISTRACION_ZONAL_ESTADO" />
    <asp:UpdatePanel runat="server">
         <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
