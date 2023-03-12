<%@ Page Title="Codigo del Bloque" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Bloque.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="bloque_id" HeaderText="Id" />
                    <asp:BoundField DataField="establecimiento_clave_catastral" HeaderText="Establecimiento" />
                    <asp:BoundField DataField="bloque_codigo" HeaderText="Codigo del Bloque" />
                    <asp:BoundField DataField="bloque_nombre" HeaderText="Nombre del Bloque" />
                    <asp:BoundField DataField="bloque_estado" HeaderText="Estado" />
                    <asp:BoundField DataField="bloque_observacion" HeaderText="Observación" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                             <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" CommandArgument='<%# Eval("bloque_id") %>' />
                             <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("bloque_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Bloque
            </a>
        </div>
    </div>
</asp:Content>
