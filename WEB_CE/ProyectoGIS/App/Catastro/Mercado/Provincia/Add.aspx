<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Provincia.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Codigo de la Provincia </label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="2" runat="server" ID="PROVINCIA_CODIGO"  />
    <label>Nombre de la Provincia </label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="50" runat="server" ID="PROVINCIA_NOMBRE" />
    <label>Estado </label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="PROVINCIA_ESTADO" />
    <label>Observaciòn</label>

    <asp:TextBox CssClass="form-control flex-wrap mb-3 mt-2" TextMode="MultiLine" Rows="4"  runat="server" ID="PROVINCIA_OBSERVACION" />
    <asp:UpdatePanel runat="server">
         <ContentTemplate>
            <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
            <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
             </ContentTemplate>
        </asp:UpdatePanel>

</asp:Content>
