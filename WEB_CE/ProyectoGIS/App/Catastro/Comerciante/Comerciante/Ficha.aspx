<%@ Page Title="Gestión de Comerciantes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ficha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Comerciante.Comerciante.Ficha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <asp:GridView ID="MiTabla" class="table table-sm table-striped table-hover table-bordered table-dark text-center align-middle" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    
                    <asp:BoundField DataField="comerciante_id" HeaderText="Id" SortExpression="Id" />
                    <asp:BoundField DataField="tipo_identificacion_nombre" HeaderText="Tipo de Identificación" SortExpression="TipoIdentificacion" />
                    <asp:BoundField DataField="tipo_ocupante_nombre" HeaderText="Tipo de Ocupante" SortExpression="TipoOcupante" />
                    <asp:BoundField DataField="comerciante_cedula_ruc" HeaderText="Cedula o Ruc" SortExpression="CedulaRuc" />
                    <asp:BoundField DataField="comerciante_apellidos_razon_social" HeaderText="Apellidos o Razón Social" SortExpression="ApellidosRazonSocial" />
                    <asp:BoundField DataField="comerciante_nombres_representante_legal" HeaderText="Nombres" SortExpression="Nombres" />
                    <asp:BoundField DataField="comerciante_fecha_nacimiento" HeaderText="Fecha de Nacimiento" SortExpression="FechaNacimiento" />
                    <asp:BoundField DataField="comerciante_edad" HeaderText="Edad" SortExpression="Edad" />
                    <asp:BoundField DataField="comerciante_lugar_origen" HeaderText="Lugar de Origen" SortExpression="LugarOrigen" />
                    <asp:BoundField DataField="comerciante_telefono_convencional" HeaderText="Telefono Convencional" SortExpression="TelefonoConvencional" />
                    <asp:BoundField DataField="comerciante_telefono_celular" HeaderText="Telefono Celular" SortExpression="TelefonoCelular" />
                    <asp:BoundField DataField="comerciante_direccion_domicilio" HeaderText="Dirección de Domicilio" SortExpression="DireccionDomicilio" />
                    <asp:BoundField DataField="comerciante_ciudad" HeaderText="Ciudad" SortExpression="Ciudad" />
                    <asp:BoundField DataField="comerciante_provincia" HeaderText="Provincia" SortExpression="Provincia" />
                    <asp:BoundField DataField="comerciante_mail" HeaderText="Mail" SortExpression="Mail" />
                    <asp:BoundField DataField="comerciante_estado" HeaderText="Estado" SortExpression="Estado" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                         <asp:Button ID="btnEditar" runat="server" Text="Editar" CommandName="Editar" CssClass="btn btn-primary" CommandArgument='<%# Eval("comerciante_id") %>' />
                        <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Eliminar" CommandArgument='<%# Eval("comerciante_id") %>' OnClientClick="return confirm('¿Está seguro que desea eliminar este cantón?');" OnClick="btnEliminar_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
               
            </asp:GridView>
        </div>
         <div class="text-end pt-4">
            <a class="btn btn-success end text-center" href="./Add"
                data-bs-target="#exampleModal">
                Agregar Comerciante
            </a>
        </div>
    </div>
</asp:Content>
