<%@ Page Title="Gestión Tipo de Documento del Puesto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.TipoDocumento.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <table class="table table-sm table-striped table-hover table-bordered table-dark text-center">
                <thead>
                    <tr>
                        <th scope="row">Id</th>
                        
                        <th>Nombre de Tipo de Documento del Puesto</th>
                        <th>Estado</th>

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
                Agregar Tipo de Documento del Puesto
            </a>
        </div>
    </div>
</asp:Content>
