<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.EstatusLegal.EstatusLegal.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <table class="table table-sm table-striped table-hover table-bordered table-dark text-center">
                <thead>
                    <tr>
                        <th scope="row">Id</th>
                        <th>Fecha de Ocupación</th>
                        <th>Historial</th>
                        <th>Estado Adjudicado</th>
                        <th>Número de Puesto Adjudicado</th>
                        <th>Condición de Uso</th>
                        <th>Carta de Adjudicación</th>
                        <th>Fecha de Notificación</th>
                        <th>Notificación de Acta de Resolución</th>
                        <th>Notificación de Fecha de Resolución</th>
                        <th>Nombre de Convenio</th>
                        <th>Numero de Convenio</th>
                        <th>Fecha de Convenio</th>
                        <th>Condición</th>
                        <th>Cambio de Giro</th>
                        <th>Numero de oficio del Cambio de Giro</th>
                        <th>Fecha del Cambio de Giro</th>
                        <th>Sanciones</th>
                        <th>Numero de Resolucion de la Sanción</th>
                        <th>Fecha de la Resolucion de la Sanción</th>

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
                Agregar Estatus Legal
            </a>
        </div>
    </div>
</asp:Content>
