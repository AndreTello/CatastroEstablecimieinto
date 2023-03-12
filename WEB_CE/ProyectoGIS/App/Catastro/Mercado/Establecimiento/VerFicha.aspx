<%@ Page Title="Identificación General del Mercado" Language="C#" MasterPageFile="~/Ficha.Master" AutoEventWireup="true" CodeBehind="VerFicha.aspx.cs" Inherits="ProyectoGIS.App.Catastro.Mercado.Establecimiento.VerFicha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Panel ID="miPanel" runat="server">

    <div id="Cas" runat="server" class="row row-cols-3">
        <div class="col">
            <div class="row row-cols-2">
                <div class="col">1. No predio</div>
                <asp:Label ID="E_PREDIO" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col">2. Clave Catastral</div>
                <asp:Label ID="E_CLAVE_C" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col">3. Nomenclatura vial</div>
                <asp:Label ID="E_NOMENCLATURA" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col">4. Administración zonal</div>
                <asp:Label ID="E_ADMINISTRACION_Z" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col">5. Parroquia o sector</div>
                <asp:Label ID="E_PARROQUIA" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col">6. Identificación</div>
                <asp:Label ID="E_IDENTIFICACION" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col">7. Nombre del M_F_P,CC</div>
                <asp:Label ID="E_NOMBRE_IDENTIFICACION" Text="text" CssClass="text-end"  runat="server" />
                
                <div class="col">8. Nombre de la Asociación </div>
                <asp:Label ID="E_NOMBRE_ASOCIACION" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col">9. Parqueadero</div>
                <asp:Label ID="E_PARQUEADERO" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col">10. Días de Apertura</div>
                <asp:Label ID="E_DIAS_APERTURA" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col">11. Remodelación </div>
                <asp:Label ID="E_REMODELACION" Text="text" CssClass="text-end" runat="server" />
                
            </div>
        </div>
        <div class="col">
            <div class="row row-cols-2">
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col">3.1 Calle Principal</div>
                <asp:Label ID="E_CALLE_P" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col">9.1 No de Parqueaderos</div>
                <asp:Label ID="E_N_PARQUEADERO" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col">10.1 Horarios de Atención</div>
                <asp:Label ID="E_HORA_AT" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col">11.1 Tipo de Intervención </div>
                <asp:Label ID="E_TIPO_I" Text="text" CssClass="text-end" runat="server" />
                
            </div>
        </div>
        <div class="col">
            <div class="row row-cols-2">
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col">3.2 Calle Secundaria</div>
                <asp:Label ID="E_CALLE_S" Text="text" CssClass="text-end" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col"> </div>
                <asp:Label Text="&nbsp" runat="server" />
                
                <div class="col">11.2 Año de la Intervención Técnica</div>
                <asp:Label ID="E_ANO_INTER" Text="text" CssClass="text-end" runat="server" />
            </div>
        </div>
    </div>

        </asp:Panel>
     <asp:LinkButton ID="btnGenerar" runat="server" Text="Generar PDF" CssClass="btn btn-success"  OnClick="btnGenerar_Click"  />

</asp:Content>
