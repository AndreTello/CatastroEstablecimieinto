<%@ Page Title="Gestión de Razón Social" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.RazonSocioEconomicaDelComerciante.RazonSocial.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="identificacion_socio_economica_id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="comerciante_nombres_representante_legal" HeaderText="Comerciante" SortExpression="Comerciante" />
                    <asp:BoundField DataField="etnia_nombre" HeaderText="Etnia" SortExpression="Etnia" />
                    <asp:BoundField DataField="genero_nombre" HeaderText="Genero" SortExpression="Genero" />
                    <asp:BoundField DataField="estado_civil_nombre" HeaderText="Estado Civil" SortExpression="EstadoCivil" />
                    <asp:BoundField DataField="nacionalidad_nombre" HeaderText="Nacionalidad" SortExpression="Nacionalidad" />
                    <asp:BoundField DataField="nivel_educacion_nombre" HeaderText="Nivel de Educación" SortExpression="NivelDeEducacion" />
                    <asp:BoundField DataField="discapacidad_nombre" HeaderText="Discapacidad" SortExpression="Discapacidad" />
                    <asp:BoundField DataField="identificacion_socio_economica_jefe_familia" HeaderText="Identificación Jefe de Familia" SortExpression="IdentificacionJefeDeFamilia" />
                    <asp:BoundField DataField="identificacion_socio_economica_dependientes" HeaderText="Identificación de los Dependientes" SortExpression="IdentificacionDeLosDependientes" />
                    <asp:BoundField DataField="identificacion_socio_economica_numero_dependientes" HeaderText="Cantidad de dependientes" SortExpression="CantidadDeDependientes" />
                    <asp:BoundField DataField="identificacion_socio_economica_parentesco" HeaderText="Parentesco" SortExpression="Parentesco" />
                    <asp:BoundField DataField="identificacion_socio_economica_estado" HeaderText="Estado" SortExpression="Estado" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                         <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" CommandArgument='<%# Eval("identificacion_socio_economica_id") %>' />
                        <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("identificacion_socio_economica_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
               
            </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Razón Social
            </a>
        </div>
    </div>
</asp:Content>
