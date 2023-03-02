<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Canton.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>

    <label class="">Provincia </label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="PROVINCIA_ID" />
    <label>Codigo del Cantòn </label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="2" runat="server" ID="CANTON_CODIGO" />
    <label>Nombre del Cantòn </label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="50" runat="server" ID="CANTON_NOMBRE" />
    <label>Estado </label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2"  runat="server" ID="CANTON_ESTADO" />
    <label>Observaciòn</label>

    <asp:TextBox CssClass="form-control flex-wrap mb-3 mt-2" TextMode="MultiLine" Rows="4"  runat="server" ID="CANTON_OBSERVACION" />
    <asp:UpdatePanel runat="server">
         <ContentTemplate>
        <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar"  Text="Guardar" OnClick="btnGuardar_Click"/>
        <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
             </ContentTemplate>
    </asp:UpdatePanel>
    </div>

</asp:Content>
