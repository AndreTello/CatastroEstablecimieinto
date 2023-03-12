﻿<%@ Page Title="Gestión Asociación" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Asociacion.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-secondary text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="asociacion_codigo" HeaderText="CÓDIGO DE ASOCIACIÓN" />
                    <asp:BoundField DataField="asociacion_nombre" HeaderText="NOMBRE" />
                    <asp:BoundField DataField="asociacion_telefono" HeaderText="TELÉFONO" />
                    <asp:BoundField DataField="asociacion_mail" HeaderText="MAIL" />
                    <asp:BoundField DataField="asociacion_contacto" HeaderText="CONTACTO" />
                    <asp:TemplateField HeaderText="ESTADO">
                       <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("asociacion_estado").ToString() == "1" ? "Activo" : "Inactivo" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="OBSERVACIONES">
                        <ItemTemplate>
                            <asp:Label ID="lblObservacion" Text='<%# Eval("ASOCIACION_OBSERVACION").ToString() == "" ? "SIN OBSERVACIONES" : Eval("ASOCIACION_OBSERVACION").ToString() %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="ACCIONES">
                        <ItemTemplate>
                            <div class=" d-flex ">
                                <div class="col mx-2">
                                    <a href="./Add?id=<%# Eval("asociacion_id") %>" class="btn btn-primary">Editar</a>
                                </div>
                                <div class="col">
                                <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger px-2" CommandName="Eliminar" CommandArgument='<%# Eval("asociacion_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                                 </div>
                             </div>

                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>

        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Asociación
            </a>
        </div>
    </div>
</asp:Content>
