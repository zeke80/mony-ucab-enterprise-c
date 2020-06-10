insert into tipousuario(
    idtipousuario,
    descripcion,
    estatus)
values
(0,'',0);

insert into tipoidentificacion(
    idtipoidentificacion,
    codigo,
    descripcion,
    estatus)
values
(0,0,'',0);

insert into usuario(
    idusuario,
    idtipousuario,
    idtipoidentificacion,
    usuario,
    fecha_registro,
    nro_identificacion,
    email,
    telefono,
    direccion,
    estatus)
values
(0,0,0,'',to_date('00-00-0000','dd-MM-yyyy'),0,'','','',0);

insert into contrasena(
	idcontrasena,
	idusuario,
	contrasena,
	intentos_fallidos,
	estatus)
values
(0,0,'',0,0);

insert into comercio(
    idusuario,
    razon_social,
    nombre_representante,
    apellido_representante)
values
(0,'','','');

insert into estadocivil(
	idestadocivil,
	descripcion,
	codigo,
	estatus
)
values
(0,0,'',0);

insert into persona(
    idusuario,
    idestadocivil,
    nombre,
	apellido,
    fecha_nacimiento)
values
(0,'','','',to_date('00-00-0000','dd-MM-yyyy'));