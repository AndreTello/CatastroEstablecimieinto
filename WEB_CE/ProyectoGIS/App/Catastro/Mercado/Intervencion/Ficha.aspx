<%@ Page Title="Gestión de Técnica de Intervención de Establecimiento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Intervencion.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover text-nowrap table-bordered table-secondary text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="tipo_intervencion_tecnica_establecimiento_nombre" HeaderText="TIPO DE INTERVENCIÓN" />
                    <asp:BoundField DataField="intervencion_tecnica_establecimiento_nombre" HeaderText="NOMBRE" />
                    <asp:BoundField DataField="intervencion_tecnica_establecimiento_fecha_inicio" HeaderText="FECHA DE INICIO" />
                    <asp:BoundField DataField="intervencion_tecnica_establecimiento_fecha_fin" HeaderText="FECHA DE FIN" />
                    <asp:TemplateField HeaderText="ESTADO">
                       <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("intervencion_tecnica_establecimiento_estado").ToString() == "1" ? "Activo" : "Inactivo" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ACCIONES">
                        <ItemTemplate>
                            <a href="./Add?id=<%# Eval("intervencion_tecnica_establecimiento_id") %>" class="btn btn-primary">Editar</a>
                            <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("intervencion_tecnica_establecimiento_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click"  />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                
            </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Intervencion
            </a>
        </div>
    </div>
</asp:Content>
