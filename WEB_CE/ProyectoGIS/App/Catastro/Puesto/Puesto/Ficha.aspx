<%@ Page Title="Gestión de Puesto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.Puesto.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="puesto_id" HeaderText="Id" />
                    <asp:BoundField DataField="piso_nombre" HeaderText="Piso" />
                    <asp:BoundField DataField="tipo_area_nombre" HeaderText="Tipo de Area" />
                    <asp:BoundField DataField="comerciante_nombres_representante_legal" HeaderText="Comerciante" />
                    <asp:BoundField DataField="ayudante_nombres" HeaderText="Ayudante" />
                    <asp:BoundField DataField="reemplazo_nombres" HeaderText="Reemplazo" />
                    <asp:BoundField DataField="documento_puesto_nombre" HeaderText="Documento del Puesto" />
                    <asp:BoundField DataField="puesto_predio" HeaderText="Predio del Puesto" />
                    <asp:BoundField DataField="puesto_clave_catastral" HeaderText="Clave Catastral del Puesto" />
                    <asp:BoundField DataField="puesto_estado_conservacion" HeaderText="Estado de Conservacion del Puesto" />
                    <asp:BoundField DataField="puesto_acabados" HeaderText="Acabados del Puesto" />
                    <asp:BoundField DataField="puesto_paredes" HeaderText="Paredes del Puesto" />
                    <asp:BoundField DataField="puesto_remodelacion" HeaderText="Remodelación del Puesto" />
                    <asp:BoundField DataField="puesto_estado" HeaderText="Estado" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                             <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" />
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("puesto_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>    
                
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Puesto
            </a>
        </div>
    </div>
</asp:Content>
