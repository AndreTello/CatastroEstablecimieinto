<%@ Page Title="Gestión de Parroquias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Parroquia.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                 <Columns> 
                     <asp:BoundField DataField="parroquia_id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="zona_nombre" HeaderText="Zona" SortExpression="Zona" />
                    <asp:BoundField DataField="parroquia_codigo" HeaderText="Codigo Parroquia" SortExpression="CodigoParroquia" />
                    <asp:BoundField DataField="parroquia_nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="parroquia_estado" HeaderText="Estado" SortExpression="Estado" />
                    <asp:BoundField DataField="parroquia_observacion" HeaderText="Observaciones" SortExpression="Observaciones" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" />
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("parroquia_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>

        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Parroquia
            </a>
        </div>
    </div>
</asp:Content>
