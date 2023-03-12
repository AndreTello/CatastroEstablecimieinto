<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Manzana.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Parroquia</label>
    <asp:DropDownList CssClass="form-select mb-3 mt-2" runat="server" ID="PARROQUIA_ID" />
    <label>Codigo de la Manzana </label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="4" runat="server" ID="MANZANA_CODIGO"  />
    <label>Nombre de la Manzana </label>
    <asp:TextBox CssClass="form-control mb-3 mt-2" MaxLength="50" runat="server" ID="MANZANA_NOMBRE" />
    <label>Estado </label>
    <asp:DropDownList CssClass="form-select" runat="server" ID="MANZANA_ESTADO"  >
        <asp:ListItem Text="-- Selecciona un Estado --" Value="" />
        <asp:ListItem Value="1">Activo</asp:ListItem>
        <asp:ListItem Value="0">Inactivo</asp:ListItem>
    </asp:DropDownList>
    <label>Observaciòn</label>

    <asp:TextBox CssClass="form-control flex-wrap mb-3 mt-2" TextMode="MultiLine" Rows="4"  runat="server" ID="MANZANA_OBSERVACION" />
   
    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" OnClick="btnGuardar_Click" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
    
</asp:Content>
