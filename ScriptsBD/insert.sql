insert into tipousuario(
    idtipousuario,
    descripcion,
    estatus)
values
(1,'1',1);

insert into tipoidentificacion(
    idtipoidentificacion,
    codigo,
    descripcion,
    estatus)
values
(1,1,'1',1);

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
(1,1,1,'user1',to_date('11-11-1111','dd-MM-yyyy'),1,'1','1','1',1),
(2,1,1,'user2',to_date('11-11-1111','dd-MM-yyyy'),2,'2','2','2',2);

insert into contrasena(
	idcontrasena,
	idusuario,
	contrasena,
	intentos_fallidos,
	estatus)
values
(1,1,'1',0,0),
(2,2,'2',0,0);

insert into comercio(
    idusuario,
    razon_social,
    nombre_representante,
    apellido_representante)
values
(1,'1','1','1');

insert into estadocivil(
	idestadocivil,
	descripcion,
	codigo,
	estatus
)
values
(1,'1','1',1);

insert into persona(
    idusuario,
    idestadocivil,
    nombre,
	apellido,
    fecha_nacimiento)
values
(2,1,'1','1',to_date('11-11-1111','dd-MM-yyyy'));