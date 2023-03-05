<%@ Page Title="Gestión Tipo Area" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.TipoArea.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
               <Columns>
                    <asp:BoundField DataField="tipo_area_id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="tipo_area_identificacion" HeaderText="Identificacion" SortExpression="Identificacion" />
                    <asp:BoundField DataField="tipo_area_nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="tipo_area_observacion" HeaderText="Observacion" SortExpression="Observacion" />
                    <asp:BoundField DataField="tipo_area_estado" HeaderText="Estado" SortExpression="Estado" />
                    
               </Columns>
                
            </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Reemplazo
            </a>
        </div>
    </div>
</asp:Content>
