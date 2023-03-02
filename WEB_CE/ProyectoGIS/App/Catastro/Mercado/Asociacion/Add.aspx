<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Asociacion.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Codigo Asociación</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="5" runat="server" ID="ASOCIACION_CODIGO" />
    <label>Nombre de la Asociación</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="100" runat="server" ID="ASOCIACION_NOMBRE" />
    <label>Telefono</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="13" onkeypress="return isNumberKey(event)" runat="server" ID="ASOCIACION_TELEFONO" />
    <label>Mail</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="50" runat="server" ID="ASOCIACION_MAIL" />
    <label>Contacto</label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="100" runat="server" ID="ASOCIACION_CONTACTO" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-control mb-3 mt-2" runat="server" ID="ASOCIACION_ESTADO" />
    <label>Observación</label>
    <asp:TextBox CssClass="form-control flex-wrap mb-3 mt-2" TextMode="MultiLine" Rows="4"  runat="server" ID="ASOCIACION_OBSERVACION" /> 
    <asp:UpdatePanel runat="server">
         <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
         </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
