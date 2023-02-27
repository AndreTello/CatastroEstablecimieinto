﻿<%@ Page Title="Gestión Asociación" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Asociacion.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <table class="table table-sm table-striped table-hover table-bordered table-dark text-center">
                <thead>
                    <tr>
                        <th scope="row">Id</th>
                        <th>Codigo de Asociación</th>
                        <th>Nombre</th>
                        <th>Telefono</th>
                        <th>Mail</th>
                        <th>Contacto</th>
                        <th>Estado</th>
                        <th colspan="3">Observación</th>
                        <th colspan="2">Acciones</th>
                    </tr>
                </thead>
                <tbody id="datos">

                </tbody>
            </table>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Asociación
            </a>
        </div>
    </div>
</asp:Content>