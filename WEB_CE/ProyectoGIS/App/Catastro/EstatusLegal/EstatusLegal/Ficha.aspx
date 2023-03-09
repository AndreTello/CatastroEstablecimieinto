<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.EstatusLegal.EstatusLegal.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="estatus_legal_id" HeaderText="Id" />
                    <asp:BoundField DataField="puesto_clave_catastral" HeaderText="Clave Catastral" />
                    <asp:BoundField DataField="giro_negocio_nombre" HeaderText="Giro de Negocio" />
                    <asp:BoundField DataField="estatus_legal_fecha_ocupacion" HeaderText="Fecha de Ocupación" />
                    <asp:BoundField DataField="estatus_legal_historial" HeaderText="Historial" />
                    <asp:BoundField DataField="estatus_legal_estado_adjudicado" HeaderText="Estado Adjudicado" />
                    <asp:BoundField DataField="estatus_legal_numero_puesto_adjudicado" HeaderText="Número de Puesto Adjudicado" />
                    <asp:BoundField DataField="estatus_legal_condicion_uso" HeaderText="Condición de Uso" />
                    <asp:BoundField DataField="estatus_legal_notificacion" HeaderText="Notificación" />
                    <asp:BoundField DataField="estatus_legal_fecha_resolucion_notificacion" HeaderText="Notificación de Fecha de Resolución" />
                    <asp:BoundField DataField="estatus_legal_convenio_nombre" HeaderText="Nombre de Convenio" />
                    <asp:BoundField DataField="estatus_legal_convenio_numero" HeaderText="Numero de Convenio" />
                    <asp:BoundField DataField="estatus_legal_convenio_fecha" HeaderText="Fecha de Convenio" />
                    <asp:BoundField DataField="estatus_legal_condicion" HeaderText="Condición" />
                    <asp:BoundField DataField="estatus_legal_cambio_giro" HeaderText="Cambio de Giro" />
                    <asp:BoundField DataField="estatus_legal_numero_oficio_cambio_giro" HeaderText="Numero de oficio del Cambio de Giro" />
                    <asp:BoundField DataField="estatus_legal_fecha_cambio_giro" HeaderText="Fecha del Cambio de Giro" />
                    <asp:BoundField DataField="estatus_legal_sanciones" HeaderText="Sanciones" />
                    <asp:BoundField DataField="estatus_legal_numero_resolucion_sancion" HeaderText="Numero de Resolucion de la Sanción" />
                    <asp:BoundField DataField="estatus_legal_fecha_resolucion_sancion" HeaderText="Fecha de la Resolucion de la Sanción" />
                    <asp:BoundField DataField="estatus_legal_estado" HeaderText="Estado" />
                     <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                             <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" />
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("estatus_legal_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>   
               
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Estatus Legal
            </a>
        </div>
    </div>
</asp:Content>
