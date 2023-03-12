<%@ Page Title="Gestión Documento del Comerciante" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Comerciante.Documento.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
                  <!--  <asp:BoundField DataField="documento_comerciante_archivo" HeaderText="Archivo" /> -->
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="documento_comerciante_id" HeaderText="Id" />
                    <asp:BoundField DataField="tipo_documento_comerciante_nombre" HeaderText="Tipo de Documento" />
                    <asp:BoundField DataField="comerciante_nombres_representante_legal" HeaderText="Nombre del Comerciante" />
                    <asp:BoundField DataField="documento_comerciante_nombre" HeaderText="Nombre del Documento" />
                    <asp:BoundField DataField="documento_comerciante_fecha" HeaderText="Fecha" />
                    <asp:BoundField DataField="documento_comerciante_detalle" HeaderText="Detalle" />
                    <asp:BoundField DataField="documento_comerciante_observacion" HeaderText="Observación" />
                    <asp:BoundField DataField="documento_comerciante_estado" HeaderText="Estado" />
                    <asp:TemplateField HeaderText="ACCIONES">
                        <ItemTemplate>  
                            <a href="./Add?id=<%# Eval("documento_comerciante_id") %>" class="btn btn-primary">Editar</a>
                        <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("documento_comerciante_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Documento del Comerciante
            </a>
        </div>
    </div>
</asp:Content>
