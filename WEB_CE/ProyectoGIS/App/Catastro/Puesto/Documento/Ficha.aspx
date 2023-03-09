<%@ Page Title="Gestión de Documento del Puesto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Documento.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="documento_puesto_id" HeaderText="Id" />
                    <asp:BoundField DataField="TipoDocumentoPuesto" HeaderText="Tipo de Documento del Puesto" />
                    <asp:BoundField DataField="tipo_documento_puesto_id" HeaderText="Puesto" />
                    <asp:BoundField DataField="puesto_id" HeaderText="Nombre del Documento del Puesto" />
                    <asp:BoundField DataField="documento_puesto_nombre" HeaderText="Fecha del Documento del Puesto" />
                    <asp:BoundField DataField="documento_puesto_fecha" HeaderText="Archivo del Documento del Puesto" />
                    <asp:BoundField DataField="documento_puesto_detalle" HeaderText="Detalle del Documento del Puesto" />
                    <asp:BoundField DataField="documento_puesto_observacion" HeaderText="Observación del Documento del Puesto" />
                    <asp:BoundField DataField="documento_puesto_estado" HeaderText="Estado" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                             <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" CommandArgument='<%# Eval("documento_puesto_id") %>' />
                             <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("documento_puesto_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Documento del Puesto
            </a>
        </div>
    </div>
</asp:Content>
