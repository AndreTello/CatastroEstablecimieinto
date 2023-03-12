<%@ Page Title="Gestión Tipo Área" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Puesto.TipoArea.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-secondary text-center align-middle" runat="server" AutoGenerateColumns="false" >
               <Columns>
                    <asp:BoundField DataField="tipo_area_identificacion" HeaderText="IDENTIFICACIÓN" SortExpression="IDENTIFICACIÓN" />
                    <asp:BoundField DataField="tipo_area_nombre" HeaderText="NOMBRE" SortExpression="NOMBRE" />
                    <asp:TemplateField HeaderText="OBSERVACIONES">
                        <ItemTemplate>
                            <asp:Label ID="lblObservacion" Text='<%# Eval("TIPO_AREA_OBSERVACION").ToString() == "" ? "SIN OBSERVACIONES" : Eval("TIPO_AREA_OBSERVACION").ToString() %>' runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="ESTADO">
                       <ItemTemplate>
                            <asp:Label ID="lblEstado" runat="server" Text='<%# Eval("TIPO_AREA_estado").ToString() == "1" ? "Activo" : "Inactivo" %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ACCIONES">
                    <ItemTemplate>
                            <a href="./Add?id=<%# Eval("tipo_area_id") %>" class="btn btn-primary">Editar</a>
                        <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("tipo_area_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
               </Columns>
                
            </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Tipo Área
            </a>
        </div>
    </div>
</asp:Content>
