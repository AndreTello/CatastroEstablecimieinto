﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Zona.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Canton</label>
    <asp:DropDownList CssClass="form-select mt-1" runat="server" ID="CANTON_ID" />
    <label>Codigo de la Zona </label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="ZONA_CODIGO"  />
    <label>Nombre de la Zona </label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="ZONA_NOMBRE" />
    <label>Estado </label>
    <asp:DropDownList CssClass="form-select mt-1" runat="server" ID="ZONA_ESTADO" />
    <label>Observaciòn</label>

    <asp:TextBox CssClass="form-control flex-wrap mt-1" TextMode="MultiLine" Rows="4"  runat="server" ID="ZONA_OBSERVACION" />
    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar"   onClick="btnGuardar_Click" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
