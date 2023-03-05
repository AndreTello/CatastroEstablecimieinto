<%@ Page Title="Gestión del Reemplazo" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Reemplazo.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="reemplazo_id" HeaderText="Id" />
                    <asp:BoundField DataField="reemplazo_cedula" HeaderText="Cedula" />
                    <asp:BoundField DataField="reemplazo_apellidos" HeaderText="Apellidos" />
                    <asp:BoundField DataField="reemplazo_nombres" HeaderText="Nombres" />
                    <asp:BoundField DataField="reemplazo_autorizacion" HeaderText="Autorización" />
                    <asp:BoundField DataField="reemplazo_numero_oficio" HeaderText="Número de Oficio" />
                    <asp:BoundField DataField="reemplazo_fecha_inicio" HeaderText="Fecha de Inicio" />
                    <asp:BoundField DataField="reemplazo_fecha_fin" HeaderText="Fecha Fin" />
                    <asp:BoundField DataField="reemplazo_estado" HeaderText="Estado" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                             <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" CommandArgument='<%# Eval("reemplazo_id") %>' />
                             <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("reemplazo_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
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
