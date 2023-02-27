<%@ Page Title="Gestión del Ayudante" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Ayudante.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <table class="table table-sm table-striped table-hover table-bordered table-dark text-center">
                <thead>
                    <tr>
                        <th scope="row">Id</th>
                        
                        <th>Cedula del Ayudante</th>
                        <th>Apellidos del Ayudante</th>
                        <th>Nombres del Ayudante</th>
                        <th>Parentezco del Ayudante</th>
                        <th>Autorización del Ayudante</th>
                        <th>Numero de Oficio del Ayudante</th>
                        <th>Fecha de Oficio</th>
                        
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
                Agregar Ayudante
            </a>
        </div>
    </div>
</asp:Content>
