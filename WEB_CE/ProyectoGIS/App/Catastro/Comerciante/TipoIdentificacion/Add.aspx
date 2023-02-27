﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Forms.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Comerciante.TipoIdentificacion.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <label>Nombre de la Identificación</label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="TIPO_IDENTIFICACION_NOMBRE" />
    <label>Detalle</label>
    <asp:TextBox CssClass="form-control mt-1" runat="server" ID="TIPO_IDENTIFICACION_DETALLE" />
    <label>Estado</label>
    <asp:DropDownList CssClass="form-control mt-1" runat="server" ID="TIPO_IDENTIFICACION_ESTADO" />
    
    <asp:Button CssClass="btn btn-primary mt-3" runat="server" ID="btnGuardar" Text="Guardar"/>
    <a class="btn btn-danger mt-3" href="./Ficha" >Cancelar</a>
</asp:Content>