<%@ Page Title="Gestión Establecimiento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Establecimiento.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table  text-nowrap table-sm table-striped table-hover table-bordered table-secondary text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="lote_nombre" HeaderText="LOTE" />
                    <asp:BoundField DataField="administracion_zonal_nombre" HeaderText="ADMINISTRACIÓN ZONAL" />
                    <asp:BoundField DataField="tipo_establecimiento_nombre" HeaderText="TIPO DE ESTABLECIMIENTO" />
                    <asp:BoundField DataField="asociacion_nombre" HeaderText="ASOCIACIÓN" />
                    <asp:BoundField DataField="intervencion_tecnica_establecimiento_nombre" HeaderText="INTERVENCIO TÉCNICA DEL ESTABLECIMIENTO" />
                    <asp:BoundField DataField="establecimiento_predio" HeaderText="PREDIO" />
                    <asp:BoundField DataField="establecimiento_clave_catastral" HeaderText="CLAVE CATASTRAL" />
                    <asp:BoundField DataField="establecimiento_nomenclatura_vial" HeaderText="NOMENCLATURA Vial" />
                    <asp:BoundField DataField="establecimiento_calle_principal" HeaderText="CALLE PRINCIPAL" />
                    <asp:BoundField DataField="establecimiento_calle_secundaria" HeaderText="CALLE SECUNDARIA" />
                    <asp:BoundField DataField="establecimiento_paqueadero" HeaderText="PARQUEADERO" />
                    <asp:BoundField DataField="establecimiento_numero_parqueadero" HeaderText="NÚMERO DE PARQUEADERO" />
                    <asp:BoundField DataField="establecimiento_dias_apertura"  HeaderText="DÍAS DE APERTURA" />
                    <asp:BoundField DataField="establecimiento_horario_atencion" HeaderText="HORARIO DE ATENCIÓN" />
                     <asp:TemplateField HeaderText="ESTADO">
                       <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("establecimiento_estado").ToString() == "1" ? "Activo" : "Inactivo" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="FICHA">
                        <ItemTemplate>
                            <a href="./VerFicha?id=<%# Eval("establecimiento_id") %>" class="btn btn-warning">Ver</a>                        
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="ACCIONES">
                        <ItemTemplate>
                            <a href="./Add?id=<%# Eval("establecimiento_id") %>" class="btn btn-primary">Editar</a>
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
