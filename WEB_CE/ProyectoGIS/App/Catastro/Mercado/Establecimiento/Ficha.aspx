<%@ Page Title="Gestión Establecimiento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Establecimiento.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="establecimiento_id" HeaderText="Id" />
                    <asp:BoundField DataField="lote_nombre" HeaderText="Lote" />
                    <asp:BoundField DataField="administracion_zonal_nombre" HeaderText="Administración Zonal" />
                    <asp:BoundField DataField="tipo_establecimiento_nombre" HeaderText="Tipo de Establecimiento" />
                    <asp:BoundField DataField="asociacion_nombre" HeaderText="Asociación" />
                    <asp:BoundField DataField="intervencion_tecnica_establecimiento_nombre" HeaderText="Intervención técnica del Establecimiento" />
                    <asp:BoundField DataField="establecimiento_predio" HeaderText="Predio" />
                    <asp:BoundField DataField="establecimiento_clave_catastral" HeaderText="Clave Catastral" />
                    <asp:BoundField DataField="establecimiento_nomenclatura_vial" HeaderText="Nomenclatura Vial" />
                    <asp:BoundField DataField="establecimiento_calle_principal" HeaderText="Calle Principal" />
                    <asp:BoundField DataField="establecimiento_calle_secundaria" HeaderText="Calle Secundaria" />
                    <asp:BoundField DataField="establecimiento_paqueadero" HeaderText="Parqueadero" />
                    <asp:BoundField DataField="establecimiento_numero_parqueadero" HeaderText="Numero de Parqueadero" />
                    <asp:BoundField DataField="establecimiento_dias_apertura"  HeaderText="Días de Apertura" />
                    <asp:BoundField DataField="establecimiento_horario_atencion" HeaderText="Horario de Atencion" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                             <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" />
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("establecimiento_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
               
            </asp:GridView>

                
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Establecimiento
            </a>
        </div>
    </div>
</asp:Content>
