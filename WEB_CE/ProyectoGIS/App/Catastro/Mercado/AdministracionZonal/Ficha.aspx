<%@ Page Title="Administración Zonal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover text-nowrap table-bordered table-secondary text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="administracion_zonal_nombre" HeaderText="NOMBRE" />
                    <asp:BoundField DataField="administracion_zonal_detalle" HeaderText="DETALLE" />
                    <asp:BoundField DataField="administracion_zonal_telefono" HeaderText="TELÉFONO" />
                    <asp:BoundField DataField="administracion_zonal_celular" HeaderText="CELULAR" />
                    <asp:BoundField DataField="administracion_zonal_mail" HeaderText="MAIL" />
                    <asp:BoundField DataField="administracion_zonal_pagina_web" HeaderText="PÁGINA WEB" />
                    <asp:BoundField DataField="administracion_zonal_representante" HeaderText="REPRESENTANTE" />
                    <asp:TemplateField HeaderText="ESTADO">
                       <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("administracion_zonal_estado").ToString() == "1" ? "Activo" : "Inactivo" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ACCIONES">
                        <ItemTemplate>
                            <div class=" d-flex ">
                                <div class="col mx-2">
                                    <a href="./Add?id=<%# Eval("administracion_zonal_id") %>" class="btn btn-primary">Editar</a>
                                </div>
                                <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("administracion_zonal_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />    
                            </div>
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
