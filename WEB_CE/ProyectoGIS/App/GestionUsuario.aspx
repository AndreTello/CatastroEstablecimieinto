<%@ Page Title="Gestión de Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionUsuario.aspx.cs" Inherits="ProyectoGIS.App.GestionUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="usuarios">

    <div id="tabla">
        <div class="table-responsive my-custom-scrollbar table-wrapper-scroll-y">
            <table class="table table-sm table-striped table-hover table-bordered table-dark text-center">
                <thead>
                    <tr>
                        <th scope="row">Id</th>
                        <th>Rol</th>
                        <th>Usuario</th>
                        <th>Cedula</th>
                        <th>Apellidos</th>
                        <th>Nombres</th>
                        <th>Correo</th>
                        <th>Dirección</th>
                        <th>Telefono</th>
                        <th>Estado</th>
                        <th colspan="2">Acciones</th>
                    </tr>
                </thead>
                <tbody id="datos">

                </tbody>
            </table>
        </div>
        <div class="text-end pt-4">
            <button type="button" class="btn btn-success end text-center" data-bs-toggle="modal"
                data-bs-target="#exampleModal">
                Agregar Usuario
            </button>
        </div>
    </div>
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h1 class="modal-title fs-5" id="exampleModalLabel">
                        Agregar  Usuario
                    </h1>
                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                </div>
                <div class="modal-body">
                    <form action="" id="formulario">
                        <div class="mb-3">
                            <label for="rol_id" class="form-label">Rol:
                            </label>
                            <select id="rol_id" class="form-select " name="rol_id" required>
                               
                            </select>
                        </div>
                        <div class="mb-3">
                            <label for="usuario_login" class="form-label">Usuario:
                            </label>
                            <input type="text" class="form-control" id="usuario_login" name="usuario_login" required minlength="4" />
                        </div>
                        <div class="mb-3">
                            <label for="usuario_clave" class="form-label">Clave:
                            </label>
                            <input type="password" class="form-control" id="usuario_clave" name="usuario_clave"  required minlength="4"/>
                        </div>
                        <div class="mb-3">
                            <label for="usuario_cedula" class="form-label">Cedula:
                            </label>
                            <input type="text" class="form-control" id="usuario_cedula" name="usuario_cedula" required minlength="4" />
                        </div>
                        <div class="mb-3">
                            <label for="usuario_apellidos" class="form-label">Apellidos:
                            </label>
                            <input type="text" class="form-control" id="usuario_apellidos" name="usuario_apellidos" required minlength="4"/>
                        </div>
                        <div class="mb-3">
                            <label for="usuario_nombres" class="form-label">Nombres:
                            </label>
                            <input type="text" class="form-control" id="usuario_nombres" name="usuario_nombres"required minlength="4" />
                        </div>
                        <div class="mb-3">
                            <label for="usuario_mail" class="form-label">Correo: </label>
                            <input type="text" class="form-control" id="usuario_mail" name="usuario_mail"required minlength="4" />
                        </div>
                        <div class="mb-3">
                            <label for="usuario_direccion" class="form-label">Dirección:
                            </label>
                            <input type="text" class="form-control" id="usuario_direccion" name="usuario_direccion" required minlength="4"/>
                        </div>
                        <div class="mb-3">
                            <label for="usuario_telefono" class="form-label">Telefono:
                            </label>
                            <input type="text" class="form-control" id="usuario_telefono" name="usuario_telefono" required minlength="4"/>
                        </div>
                        <div class="mb-3">
                            <label for="usuario_estado" class="form-label">Estado:
                            </label>
                            <select id="usuario_estado" class="form-select " name="usuario_estado">
                                <option selected>--Seleccione un estado--</option>
                                <option value="1">ACTIVO</option>
                                <option value="0">INACTIVO</option>
                            </select>
                        </div>


                    </form>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">
                        Cerrar
                    </button>

                    <button type="submit" class="btn btn-primary" data-bs-dismiss="modal" onclick="createUsuario()">Agregar Usuario</button>
                </div>
            </div>
        </div>
    </div>
    </form>
</asp:Content>
