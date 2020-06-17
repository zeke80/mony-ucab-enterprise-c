insert into tipousuario(
    descripcion,
    estatus
)
values
('1',1);

insert into tipoidentificacion(
    codigo,
    descripcion,
    estatus
)
values
(1,'1',1);

insert into usuario(
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
(1,1,'user1',to_date('11-11-1111','dd-MM-yyyy'),1,'1','1','1',1),
(1,1,'user2',to_date('11-11-1111','dd-MM-yyyy'),2,'2','2','2',1);

insert into contrasena(
	idusuario,
	contrasena,
	intentos_fallidos,
	estatus
)
values
(1,'1',0,1),
(2,'2',0,1);

insert into comercio(
    razon_social,
    nombre_representante,
    apellido_representante
)
values
('1','1','1');

insert into estadocivil(
	descripcion,
	codigo,
	estatus
)
values
('1','1',1);

insert into persona(
    idestadocivil,
    nombre,
	apellido,
    fecha_nacimiento
)
values
(1,'1','1',to_date('11-11-1111','dd-MM-yyyy'));

insert into tipocuenta(
	descripcion,
	estatus
)
values
('1',1);

insert into banco(
	nombre,
	estatus
)
values
('1',1);

insert into cuenta(
	idusuario,
	idtipocuenta,
	idbanco,
	numero
)
values
(1,1,1,'1'),
(1,1,1,'1');

insert into tipotarjeta(
	descripcion,
	estatus
)
values
('1',1);

insert into tarjeta(
	idusuario,
	idtipotarjeta,
	idbanco,
	numero,
	fecha_vencimiento,
	cvc,
	estatus
)
values
(2,1,1,1,to_date('11-11-1111','dd-MM-yyyy'),1,1),
(2,1,1,1,to_date('11-11-1111','dd-MM-yyyy'),1,1);

insert into operaciontarjeta(
	idusuarioreceptor,
	idtarjeta,
	fecha,
	hora,
	monto,
	referencia
)
values
(1,1,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1'),
(1,1,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1'),
(1,2,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1');

insert into operacioncuenta(
	idcuenta,
	idusuarioreceptor,
	fecha,
	hora,
	monto,
	referencia
)
values
(1,2,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1'),
(1,2,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1'),
(2,2,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),1.11,'1');

insert into tipooperacion(
	descripcion,
	estatus
)
values
('1',1);

insert into operacionesmonedero(
	idusuario,
	idtipooperacion,
	monto,
	fecha,
	hora,
	referencia
)
values
(1,1,1.11,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),'1'),
(1,1,1.11,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),'1'),
(2,1,1.11,to_date('11-11-1111','dd-MM-yyyy'),TO_TIMESTAMP('11-11-1111','dd-MM-yyyy'),'1');

insert into reintegro(
	idusuario_solicitante,
	idusuario_receptor,
	fecha_solicitud,
	referencia,
	estatus
)
values
(2,1,'11-11-1111','1',1),
(2,1,'11-11-1111','1',1);


insert into pago(
	idpago,
	idusuario_solicitante,
	idusuario_receptor,
	fecha_solicitus,
	monto,
	estatus,
	referencia
)
values 
(1,1,2,to_date('11-11-1111','dd-MM-yyyy'),111,'SOLICITADO',null);
