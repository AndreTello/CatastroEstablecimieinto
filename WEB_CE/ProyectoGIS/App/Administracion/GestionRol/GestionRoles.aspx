<%@ Page Title="Gestión Roles" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionRoles.aspx.cs" Inherits="ProyectoGIS.App.GestionRoles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-secondary text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>

                    <asp:BoundField DataField="rol_nombre" HeaderText="NOMBRE" />
                    <asp:BoundField DataField="rol_detalle" HeaderText="DETALLE" />
                    <asp:TemplateField HeaderText="ESTADO">
                       <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("rol_estado").ToString() == "1" ? "Activo" : "Inactivo" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ACCIONES">
                        <ItemTemplate>
                            <a href="./Add?id=<%# Eval("rol_id") %>" class="btn btn-primary">Editar</a>
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger px-2" CommandName="Eliminar" CommandArgument='<%# Eval("rol_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Rol
            </a>
        </div>
    </div>
</asp:Content>
