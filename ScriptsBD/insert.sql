insert into tipousuario(
    idtipousuario,
    descripcion,
    estatus
)
values
(1,'1',1);

insert into tipoidentificacion(
    idtipoidentificacion,
    codigo,
    descripcion,
    estatus
)
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
    estatus
)
values
(1,1,1,'user1',to_date('11-11-1111','dd-MM-yyyy'),1,'1','1','1',1),
(2,1,1,'user2',to_date('11-11-1111','dd-MM-yyyy'),2,'2','2','2',1);

insert into contrasena(
	idcontrasena,
	idusuario,
	contrasena,
	intentos_fallidos,
	estatus
)
values
(1,1,'1',0,1),
(2,2,'2',0,1);

insert into comercio(
    idusuario,
    razon_social,
    nombre_representante,
    apellido_representante
)
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
    fecha_nacimiento
)
values
(2,1,'1','1',to_date('11-11-1111','dd-MM-yyyy'));

insert into tipocuenta(
	idtipocuenta,
	descripcion,
	estatus
)
values
(1,'1',1);

insert into banco(
	idbanco,
	nombre,
	estatus
)
values
(1,'1',1);

insert into cuenta(
	idcuenta,
	idusuario,
	idtipocuenta,
	idbanco,
	numero
)
values
(1,1,1,1,'1'),
(2,1,1,1,'1');

insert into tipotarjeta(
	idtipotarjeta,
	descripcion,
	estatus
)
values
(1,'1',1);

insert into tarjeta(
	idtarjeta,
	idusuario,
	idtipotarjeta,
	idbanco,
	numero,
	fecha_vencimiento,
	cvc,
	estatus
)
values
(1,2,1,1,1,to_date('11-11-1111','dd-MM-yyyy'),1,1),
(2,2,1,1,1,to_date('11-11-1111','dd-MM-yyyy'),1,1);

insert into operaciontarjeta(
	idoperaciontarjeta,
	idusuarioreceptor,
	idtarjeta,
	fecha,
	hora,
	monto,
	referencia
)
values
(1,1,1,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1'),
(2,1,1,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1'),
(3,1,2,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1');

insert into operacioncuenta(
	idoperacioncuenta,
	idcuenta,
	idusuarioreceptor,
	fecha,
	hora,
	monto,
	referencia
)
values
(1,1,2,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1'),
(2,1,2,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1'),
(3,2,2,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1');