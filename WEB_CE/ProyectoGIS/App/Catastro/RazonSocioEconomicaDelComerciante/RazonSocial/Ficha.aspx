<%@ Page Title="Gestión de Razón Social" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.RazonSocial.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <table class="table table-sm table-striped table-hover table-bordered table-dark text-center">
                <thead>
                    <tr>
                        <th scope="row">Id</th>
                        <th>Comerciante</th>
                        <th>Etnia</th>
                        <th>Genero</th>
                        <th>Estado Civil</th>
                        <th>Nacionalidad</th>
                        <th>Nivel de Educación</th>
                        <th>Discapacidad</th>
                        <th>Identificación Jefe de Familia</th>
                        <th>Identificación de los Dependientes</th>
                        <th>Cantidad de dependientes</th>
                        <th>Parentesco</th>
                        
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
                Agregar Razón Social
            </a>
        </div>
    </div>
</asp:Content>
