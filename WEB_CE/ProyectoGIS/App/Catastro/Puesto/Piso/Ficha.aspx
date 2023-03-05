<%@ Page Title="Gestión de Piso" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Piso.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="piso_id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="bloque_nombre" HeaderText="Bloque" SortExpression="Bloque" />
                    <asp:BoundField DataField="piso_codigo" HeaderText="Codigo del Piso" SortExpression="CodigoPiso" />
                    <asp:BoundField DataField="piso_nombre" HeaderText="Nombre del Piso" SortExpression="NombrePiso" />
                    <asp:BoundField DataField="piso_estado" HeaderText="Estado" SortExpression="Estado" />
                    <asp:BoundField DataField="piso_observacion" HeaderText="Observación" SortExpression="Observacion" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                             <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" CommandArgument='<%# Eval("piso_id") %>' />
                             <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("piso_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                
            </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Piso
            </a>
        </div>
    </div>
</asp:Content>
