<%@ Page Title="Administración Zonal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="administracion_zonal_id" HeaderText="Id" />
                    <asp:BoundField DataField="administracion_zonal_nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="administracion_zonal_detalle" HeaderText="Detalle" />
                    <asp:BoundField DataField="administracion_zonal_telefono" HeaderText="Telefono" />
                    <asp:BoundField DataField="administracion_zonal_celular" HeaderText="Celular" />
                    <asp:BoundField DataField="administracion_zonal_mail" HeaderText="Mail" />
                    <asp:BoundField DataField="administracion_zonal_pagina_web" HeaderText="Pagina Web" />
                    <asp:BoundField DataField="administracion_zonal_representante" HeaderText="Representante" />
                    <asp:BoundField DataField="administracion_zonal_estado" HeaderText="Estado" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                             <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" />
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("administracion_zonal_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Administración Zonal
            </a>
        </div>
    </div>
</asp:Content>
