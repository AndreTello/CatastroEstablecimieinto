<%@ Page Title="Gestión Rol-Permiso" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionRolPermiso.aspx.cs" Inherits="ProyectoGIS.App.Administracion.GestionRolPermiso.GestionRolPermiso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="rol_permiso_id" HeaderText="Id" />
                    <asp:BoundField DataField="rol_nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="permiso_nombre" HeaderText="Detalle" />
                    <asp:BoundField DataField="rol_permiso_estado" HeaderText="Estado" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" />
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("rol_permiso_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Rol Permiso
            </a>
        </div>
    </div>
</asp:Content>
