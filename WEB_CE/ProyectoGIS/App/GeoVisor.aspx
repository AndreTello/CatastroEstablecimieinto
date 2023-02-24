<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GeoVisor.aspx.cs" Inherits="ProyectoGIS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <title>Ingreso de Datos proyecto GIS</title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js"
        integrity="sha384-oBqDVmMz9ATKxIep9tiCxS/Z9fNfEXiDAYTujMAeBAsjFuCZSmKbSSUnQlmh/jp3"
        crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.min.js"
        integrity="sha384-mQ93GR66B00ZXjt0YO5KlohRA5SY2XofN4zfuZxLkoj1gXtW8ANNCe9d5Y3eG5eD"
        crossorigin="anonymous"></script>
    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
        }

        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }

        .b-example-divider {
            height: 3rem;
            background-color: rgba(0, 0, 0, .1);
            border: solid rgba(0, 0, 0, .15);
            border-width: 1px 0;
            box-shadow: inset 0 .5em 1.5em rgba(0, 0, 0, .1), inset 0 .125em .5em rgba(0, 0, 0, .15);
        }

        .b-example-vr {
            flex-shrink: 0;
            width: 1.5rem;
            height: 100vh;
        }

        .bi {
            vertical-align: -.125em;
            fill: currentColor;
        }

        .nav-scroller {
            position: relative;
            z-index: 2;
            height: 2.75rem;
            overflow-y: hidden;
        }

        .nav-scroller .nav {
            display: flex;
            flex-wrap: nowrap;
            padding-bottom: 1rem;
            margin-top: -1px;
            overflow-x: auto;
            text-align: center;
            white-space: nowrap;
            -webkit-overflow-scrolling: touch;
        }
    </style>
</head>
<body  style="background-color: #F7F2E0;">
    <header class="navbar navbar-dark sticky-top bg-primary flex-md-nowrap p-0 shadow pb-2">
        <a class="navbar-brand col-md-3 col-lg-2 me-0 px-3 fs-6" href="./home"><img src="../publics/imgs/QH_HORIZONTAL-01.png"
                class="  rounded shadow-xl img-fluid" style="width: 160px; filter: brightness(1.30);" alt=""></a>
        <button class="navbar-toggler position-absolute d-md-none collapsed" type="button" data-bs-toggle="collapse"
            data-bs-target="#sidebarMenu" aria-controls="sidebarMenu" aria-expanded="false"
            aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="navbar-nav">
            <div class="nav-item text-nowrap">
                <a href="/App/Home" class="btn btn-danger p-3" >Regresar</a>
            </div>
        </div>
    </header>
     <nav id="sidebarMenu" class="col-md-3 col-lg-2 d-md-block bg-light sidebar collapse">
                <div class="position-sticky pt-3 sidebar-sticky">
                    <ul class="nav flex-column">
                        <div id="rol-admin">
                            <h6
                                class="sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted text-uppercase">
                                <span>Administración</span>
                                
                            </h6>

                            <li class="nav-item">
                                
                                <a class="nav-link" aria-current="page" href="./GestionUsuario">
                                <span data-feather="home" class="align-text-bottom">Gestionar Usuarios</span>
                                 
                                </a>
                            </li>
                            <li class="nav-item">
                            <a class="nav-link" href="./roles">
                            <span data-feather="file" class="align-text-bottom"></span>
                                Gestión de Roles
                            </a>
                            </li>
                            <li class="nav-item">
                            <a class="nav-link" href="./permisos">
                            <span data-feather="shopping-cart" class="align-text-bottom"></span>
                                Gestión de Permisos
                            </a>
                            </li>
                            <li class="nav-item">
                            <a class="nav-link" href="./rolPermiso">
                            <span data-feather="shopping-cart" class="align-text-bottom"></span>
                                Gestión de Rol y Permisos
                            </a>
                            </li>

                        </div>
                        <div id="rol-mod">
                            <h6 class="sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted text-uppercase">
                        <span>Consultas</span>

                        </h6>
                        <li class="nav-item">
                            <a class="nav-link" href="./consultas">
                                <span data-feather="users" class="align-text-bottom"></span>
                                Busqueda
                            </a>
                        </li>
                        <h6
                            class="sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted text-uppercase">
                            <span>Reportes</span>

                        </h6>
                        <li class="nav-item">
                            <a class="nav-link" href="./reportes">
                                <span data-feather="bar-chart-2" class="align-text-bottom"></span>
                                Reportes
                            </a>
                        </li>
                        </div>
                        <h6
                            class="sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted text-uppercase">
                            <span>Geovisualización</span>

                        </h6>
                        <li class="nav-item">
                            <a class="nav-link" href="./visor">
                                <span data-feather="layers" class="align-text-bottom"></span>
                                Visor
                            </a>
                        </li>
                       
                        <h6
                            class="sidebar-heading d-flex justify-content-between align-items-center px-3 mt-4 mb-1 text-muted text-uppercase">
                            <span>GeoPortal</span>

                        </h6>
                        <li class="nav-item">
                            <a class="nav-link" href="./GeoVisor">
                                <span data-feather="layers" class="align-text-bottom"></span>
                                GeoVisor
                            </a>
                        </li>
                        <li class="nav-item mt-4">
                            <footer class="">
                                <p> <a href="#" class="nav-link text-dark">Sefaks Solutions&copy;</a>
                            </footer>
                        </li>
                        
                    </ul>


                    
                </div>
            </nav>
    <div class="container">
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="True">
            </asp:ScriptManager>

            <div class="row">
               <!-- <div class="col-md-12">
                    <div class="alert alert-success">
                        <h2><strong>CRUD</strong> sobre Base de Datos Postgis/Postgresql</h2>
                        <h4><strong>IDE:</strong> Visual Studio C#<br />
                            <strong>Libreria:</strong> Gmaps Subgurim de Google Maps V3.0
                        </h4>
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" Width="100px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True" Visible="False">
                            <asp:ListItem Selected="True">Punto</asp:ListItem>
                            <asp:ListItem>Linea</asp:ListItem>
                            <asp:ListItem>Poligono</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>-->
                <div class="col-md-8">
                    <div style="width: 100%; height: 100%;">
                        <gmaps:GMap ID="GMap1" runat="server" enableServerEvents="true" serverEventsType="AspNetPostBack"
                            OnMarkerClick="GMap1_MarkerClick"
                            OnClick="GMap1_Click"
                            Height="-100" Width="-100" Language="es" />
                    </div>
                    <br />
                </div>
                <!--parte de edición-->
                <div class="col-md-4">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div class="panel panel-success">
                                <div class="panel-heading">
                                    <center><b><asp:Label ID="lblTitulo" runat="server" Text="Gasolineras Cercanas"></asp:Label></b></center>
                                    <asp:Label ID="lblMensaje" CssClass="alert-danger" runat="server" Text=""></asp:Label>
                                </div>
                                <div class="panel-body" style="background-color: #E6E6E6;">
                                    <asp:Label ID="lblResultado" runat="server" CssClass="alert-danger"></asp:Label>
                                    <div class="col-md-12">
                                        <div id="punto" class="form-group col-md-12" runat="server">
                                            <asp:Label ID="lblNombre" runat="server" Text="Nombre Gasolinera"></asp:Label>
                                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" AutoPostBack="True"></asp:TextBox>
                                            
                                        </div>
                                        <div id="linea" class="form-group col-md-3" runat="server">
                                            <asp:Label ID="lblRuta" runat="server" Text="Nombre Ruta"></asp:Label>
                                            <asp:TextBox ID="txtRuta" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div id="poligono" class="form-group col-md-3" runat="server">
                                            <asp:Label ID="lblZona" runat="server" Text="Nombre Zona"></asp:Label>
                                            <asp:TextBox ID="txtZona" runat="server" CssClass="form-control"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-6">
                                            <asp:Label ID="lblLongitud" runat="server" Text="Longitud 1"></asp:Label>
                                            <asp:TextBox ID="txtLongitud" runat="server" CssClass="form-control" Enabled="False" AutoPostBack="True"></asp:TextBox>
                                        </div>
                                        <div class="form-group col-md-6">
                                            <asp:Label ID="lblLatitud" runat="server" Text="Latitud 1"></asp:Label>
                                            <asp:TextBox ID="txtLatitud" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                                        </div>
                                            <div class="form-group col-md-12">
                                            <asp:Label ID="lblObservacion" runat="server" Text="Observaciones"></asp:Label>
                                            <asp:TextBox ID="txtObservacion" runat="server" CssClass="form-control" Height="169px" TextMode="MultiLine"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="panel-footer">
                                    <br />
                                    <div class="form-group">
                                        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" CssClass="btn btn-success " OnClick="btnInsertar_Click" Enabled="False" />
                                        <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-info " Enabled="False" OnClick="btnEditar_Click" />
                                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger " Enabled="False" OnClick="btnEliminar_Click" />
                                        <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar " CssClass="btn btn-default " Enabled="False" OnClick="btnLimpiar_Click" />
                                    </div>
                                </div>
                            </div>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="DropDownList1"  EventName="SelectedIndexChanged" />
                        </Triggers>
                    </asp:UpdatePanel>
                </div>
            </div>
        </form>
    </div>
    <!-- /.container -->
    <br />
    <br />
    <footer id="footer">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="alert alert-info" role="alert">
                        Copyright &copy; <%: DateTime.Now.Year %>
                        
                    </div>
                </div>
            </div>
        </div>

    </footer>

</body>
</html>
