<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Comerciante.Comerciante.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Tipo de Identificación</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="TIPO_IDENTIFICACION_ID" />
    <label>Tipo de Ocupante</label> 
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="TIPO_OCUPANTE_ID" />
    <label>Cedula o Ruc</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="13" runat="server" ID="COMERCIANTE_CEDULA_RUC" />
    <label>Apellidos o Razón Social</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="100" runat="server" ID="COMERCIANTE_APELLIDOS_RAZON_SOCIAL" /> 
    <label>Nombres del Representante legal</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="100" runat="server" ID="COMERCIANTE_NOMBRES_REPRESENTANTE_LEGAL" />
    <label>Fecha de Nacimiento</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="50" runat="server" ID="COMERCIANTE_FECHA_NACIMIENTO" />
    <label>Edad</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="3" runat="server" ID="COMERCIANTE_EDAD" />
    <label>Lugar de Origen</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="100" runat="server" ID="COMERCIANTE_LUGAR_ORIGEN" />
    <label>Telefono convencional</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="13" runat="server" ID="COMERCIANTE_TELEFONO_CONVENCIONAL" />
    <label>Telefono Celular</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="13" runat="server" ID="COMERCIANTE_TELEFONO_CELULAR" />
    <label>Dirección Domicilio</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="100" runat="server" ID="COMERCIANTE_DIRECCION_DOMICILIO" />
    <label>Ciudad</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="100" runat="server" ID="COMERCIANTE_CIUDAD" />
    <label>Provincia</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="100" runat="server" ID="COMERCIANTE_PROVINCIA" />
    <label>Correo Electrónico</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="100" runat="server" ID="COMERCIANTE_MAIL" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="COMERCIANTE_ESTADO" />

    <asp:UpdatePanel runat="server">
         <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
