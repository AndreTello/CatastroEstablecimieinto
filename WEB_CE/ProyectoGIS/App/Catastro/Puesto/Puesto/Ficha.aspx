<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Puesto.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <table class="table table-sm table-striped table-hover table-bordered table-dark text-center">
                <thead>
                    <tr>
                        <th scope="row">Id</th>
                        
                        <th>Piso</th>
                        <th>Tipo de Area</th>
                        <th>Comerciante</th>
                        <th>Ayudante</th>
                        <th>Reemplazo</th>
                        <th>Documento del Puesto</th>
                        <th>Predio del Puesto</th>
                        <th>Clave Catastral del Puesto</th>
                        <th>Area del Puesto</th>
                        <th>Frente del Puesto</th>
                        <th>Fondo del Puesto</th>
                        <th>Estado de Conservacion del Puesto</th>
                        <th>Acabados del Puesto</th>
                        <th>Paredes del Puesto</th>
                        <th>Remodelación del Puesto</th>


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
                Agregar Puesto
            </a>
        </div>
    </div>
</asp:Content>
