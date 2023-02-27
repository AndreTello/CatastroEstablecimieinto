<%@ Page Title="Gestión del Reemplazo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Reemplazo.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <table class="table table-sm table-striped table-hover table-bordered table-dark text-center">
                <thead>
                    <tr>
                        <th scope="row">Id</th>
                        
                        <th>Cedula del Reemplazo</th>
                        <th>Apellidos del Reemplazo</th>
                        <th>Nombres del Reemplazo</th>
                        <th>Autorización del Reemplazo</th>
                        <th>Numero de Oficio del Reemplazo</th>
                        <th>Oficio del Reemplazo</th>
                        <th>Fecha de Inicio</th>
                        <th>Fecha Fin</th>
                        
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
                Agregar Reemplazo
            </a>
        </div>
    </div>
</asp:Content>
