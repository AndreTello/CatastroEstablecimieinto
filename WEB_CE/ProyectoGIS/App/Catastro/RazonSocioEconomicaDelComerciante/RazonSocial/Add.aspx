<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.RazonSocial.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Comerciante</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="COMERCIANTE_ID" />
    <label>Etnia</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="ETNIA_ID" />
    <label>Genero</label>
     <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="GENERO_ID" />
    <label>Estado Civil</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="ESTADO_CIVIL_ID" />
    <label>Nacionalidad</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="NACIONALIDAD_ID" />
    <label>Nivel de Educación</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="NIVEL_EDUCACION_ID" />
    <label>Discapacidad</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="DISCAPACIDAD_ID" />
    <label>Identificación del Jefe de Familia</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" ID="IDENTIFICACION_SOCIO_ECONOMICA_JEFE_FAMILIA" />
    <label>Identificación de Dependientes</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" ID="IDENTIFICACION_SOCIO_ECONOMICA_DEPENDIENTES" />
    <label>Numero de Dependientes</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" ID="IDENTIFICACION_SOCIO_ECONOMICA_NUMERO_DEPENDIENTES" />
    <label>Parentesco</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" runat="server" ID="IDENTIFICACION_SOCIO_ECONOMICA_PARENTESCO" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="IDENTIFICACION_SOCIO_ECONOMICA_ESTADO" />
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
