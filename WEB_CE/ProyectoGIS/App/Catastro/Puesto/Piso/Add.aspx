﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Piso.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Piso</label>
    <asp:DropDownList CssClass="form-control mb-4 mt-2" runat="server" ID="BLOQUE_ID" />
    <label>Codigo del Bloque</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="PISO_CODIGO" />
    <label>Nombre del Bloque</label>
    <asp:TextBox CssClass="form-control mb-4 mt-2" runat="server" ID="PISO_NOMBRE" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-control mb-4 mt-2" runat="server" ID="PISO_ESTADO" />
    <label>Observacion</label>
    <asp:TextBox CssClass="form-control flex-wrap mt-2" TextMode="MultiLine" Rows="4"  runat="server" ID="OBSERVACION_OBSERVACION" /> 
   
    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>
