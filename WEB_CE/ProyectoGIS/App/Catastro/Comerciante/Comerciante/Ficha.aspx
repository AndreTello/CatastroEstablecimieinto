<%@ Page Title="Gestión de Comerciantes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Comerciante.Comerciante.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <table class="table table-sm table-striped table-hover table-bordered table-dark text-center">
                <thead>
                    <tr>
                        <th scope="row">Id</th>
                        <th>Tipo de Identificación</th>
                        <th>Tipo de Ocupante</th>
                        <th>Cedula o Ruc</th>
                        <th>Apellidos o Razón Social</th>
                        <th>Nombres</th>
                        <th>Fecha de Nacimiento</th>
                        <th>Edad</th>
                        <th>Lugar de Origen</th>
                        <th>Telefono Convencional</th>
                        <th>Telefono Celular</th>
                        <th>Dirección de Domicilio</th>
                        <th>Ciudad</th>
                        <th>Provincia</th>
                        <th>Mail</th>
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
                Agregar Comerciante
            </a>
        </div>
    </div>
</asp:Content>
