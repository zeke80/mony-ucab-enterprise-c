
/*********** MONYUCAB BASE DE DATOS ***********/


/********* tablas ************/


CREATE TABLE usuario (
	idusuario            serial PRIMARY KEY,	
	idtipousuario        integer NOT NULL,
	idtipoidentificacion integer NOT NULL,
	usuario              varchar(20) NOT NULL UNIQUE,
	fecha_registro       date NOT NULL,
	nro_identificacion   integer NOT NULL,
	email                varchar(200) NOT NULL,
	telefono             varchar(12) NOT NULL,
	direccion            varchar(500) NOT NULL,
	estatus              integer NOT NULL
);
-- ALTER TABLE usuario
-- ADD CONSTRAINT estatus_check CHECK (estatus IN ('',''));


CREATE TABLE tipoidentificacion (
	idtipoidentificacion  serial PRIMARY KEY,
	codigo                varchar(1) NOT NULL,
	descripcion           varchar(45) NOT NULL,
	estatus               integer NOT NULL
);
-- ALTER TABLE tipoidentificacion
-- ADD CONSTRAINT estatusid_check (estatus IN ('',''));


CREATE TABLE tipousuario (
	idtipousuario  serial PRIMARY KEY,
	descripcion    varchar(45) NOT NULL,
	estatus        integer NOT NULL	
);
-- ALTER TABLE tipousuario
-- ADD CONSTRAINT estatustipo_check (estatus IN ('',''));


CREATE TABLE contrasena (
	idcontrasena      serial PRIMARY KEY,
	idusuario         integer NOT NULL,
	contrasena        varchar(20) NOT NULL,
	intentos_fallidos integer NOT NULL,
	estatus           integer NOT NULL
);
-- ALTER TABLE contrasena
-- ADD CONSTRAINT estatuscontrasena_check (estatus IN ('',''));


CREATE TABLE comercio (
	idusuario              integer,
	razon_social           varchar(200) NOT NULL,
	nombre_representante   varchar(45) NOT NULL,
	apellido_representante varchar(45) NOT NULL
);


CREATE TABLE usuario_opcionmenu (
	idusuario integer,
	idopcionmenu integer,
	estatus integer NOT NULL
);
-- ALTER TABLE usuario_opcionmenu
-- ADD CONSTRAINT estatususeropcion_check (estatus IN ('',''));


CREATE TABLE opcionmenu (
	idopcionmenu serial PRIMARY KEY,
	idaplicacion integer NOT NULL,
	nombre       varchar(45) NOT NULL,
	descripcion  varchar(45) NOT NULL,
	url          varchar(200) NOT NULL,
	posicion     integer NOT NULL,
	estatus      integer NOT NULL
);
-- ALTER TABLE opcionmenu
-- ADD CONSTRAINT estatusopcion_check (estatus IN ('',''));


CREATE TABLE aplicacion (
	idaplicacion serial PRIMARY KEY,
	nombre       varchar(45) NOT NULL,
	descripcion  varchar(45) NOT NULL,
	estatus      varchar(45) NOT NULL
);
-- ALTER TABLE aplicacion
-- ADD CONSTRAINT estatusaplicacion_check (estatus IN ('',''));


CREATE TABLE bitacora (
	idauditoria     serial PRIMARY KEY,
	idevento        integer NOT NULL,
	idusuario       integer NOT NULL,
	fecha           date NOT NULL,
	hora            time NOT NULL,
	datos_operacion varchar(2500) NOT NULL,
	causa_error     varchar(2500)
);


CREATE TABLE evento (
	idevento      serial PRIMARY KEY,
	codigo_evento varchar(4) NOT NULL,
	evento        varchar(45) NOT NULL,
	estatus       integer
);
-- ALTER TABLE bitacora
-- ADD CONSTRAINT estatusevento_check (estatus IN ('',''));


CREATE TABLE pago (
	idpago                serial PRIMARY KEY,
	idusuario_solicitante integer NOT NULL,
	idusuario_receptor    integer NOT NULL,
	fecha_solicitus       varchar(45) NOT NULL,
	monto                 decimal NOT NULL,
	estatus               varchar(45) NOT NULL,
	referencia            serial not null
);
-- ALTER TABLE pago
-- ADD CONSTRAINT estatuspago_check (estatus IN ('',''));


CREATE TABLE reintegro (
	idreintegro           serial PRIMARY KEY,
	idusuario_solicitante integer NOT NULL,
	idusuario_receptor    integer NOT NULL,
	fecha_solicitud       varchar(45) NOT NULL,
	referencia            integer NOT NULL,
	estatus               varchar(45) NOT NULL
);
-- ALTER TABLE reintegro
-- ADD CONSTRAINT estatusreintegro_check (estatus IN ('',''));


CREATE TABLE persona (
	idusuario        integer,
	idestadocivil    integer NOT NULL,
	nombre           varchar(45) NOT NULL,
	apellido         varchar(45) NOT NULL,
	fecha_nacimiento date NOT NULL 
);


CREATE TABLE estadocivil (
	idestadocivil serial PRIMARY KEY,
	descripcion varchar(45) NOT NULL,
	codigo char(1) NOT NULL,
	estatus integer NOT NULL
);
-- ALTER TABLE estadocivil
-- ADD CONSTRAINT estatuscivil_check (estatus IN ('',''));


CREATE TABLE operacionesmonedero (
	idoperacionesmonedero serial PRIMARY KEY,
	idusuario             integer NOT NULL,
	idtipooperacion       integer NOT NULL,
	monto                 decimal NOT NULL,
	fecha                 date NOT NULL,
	hora                  time NOT NULL,
	referencia            integer NOT NULL
);


CREATE TABLE tipooperacion (
	idtipooperacion serial PRIMARY KEY,
	descripcion     varchar(45) NOT NULL,
	estatus         integer NOT NULL
);
-- ALTER TABLE tipooperacion
-- ADD CONSTRAINT estatustipooperacion_check (estatus IN ('',''));


CREATE TABLE parametro (
	idparametro     serial PRIMARY KEY,
	idtipoparametro integer NOT NULL,
	idfrecuencia    integer NOT NULL,
	nombre          varchar(45) NOT NULL,
	estatus         integer NOT NULL
);
-- ALTER TABLE parametro
-- ADD CONSTRAINT estatustparametro_check (estatus IN ('',''));


CREATE TABLE usuario_parametro (
	usuario_idusuario       integer,
	parametros_idparametros integer,
	validacion              varchar(45) NOT NULL,
	estatus                 integer NOT NULL
);
-- ALTER TABLE usuario_parametro
-- ADD CONSTRAINT estatustusuarioparametro_check (estatus IN ('',''));


CREATE TABLE frecuencia (
	idfrecuencia serial PRIMARY KEY,
	codigo       varchar(1) NOT NULL,
	descripcion  varchar(45) NOT NULL,
	estatus      integer NOT NULL
);
-- ALTER TABLE frecuencia
-- ADD CONSTRAINT estatusfrecuencia_check (estatus IN ('',''));


CREATE TABLE tipoparametro (
	idtipoparametro serial PRIMARY KEY,
	descripcion     varchar(45) NOT NULL,
	estatus         integer NOT NULL
);
-- ALTER TABLE tipoparametro
-- ADD CONSTRAINT estatustipoparametro_check (estatus IN ('',''));


CREATE TABLE cuenta (
	idcuenta     serial PRIMARY KEY,
	idusuario    integer NOT NULL,
	idtipocuenta integer NOT NULL,
	idbanco      integer NOT NULL,
	numero       varchar(20) NOT NULL
);


CREATE TABLE banco (
	idbanco serial PRIMARY KEY,
	nombre  varchar(45) NOT NULL,
	estatus integer NOT NULL
);
-- ALTER TABLE banco
-- ADD CONSTRAINT estatusbanco_check (estatus IN ('',''));


CREATE TABLE tipocuenta (
	idtipocuenta serial PRIMARY KEY,
	descripcion varchar(45) NOT NULL,
	estatus integer NOT NULL
);
-- ALTER TABLE tipocuenta
-- ADD CONSTRAINT estatustipocuenta_check (estatus IN ('',''));


CREATE TABLE operacioncuenta (
	idoperacioncuenta serial PRIMARY KEY,
	idcuenta          integer NOT NULL,
	idusuarioreceptor integer NOT NULL,
	fecha             date NOT NULL,
	hora              time NOT NULL,
	monto             decimal NOT NULL,
	referencia        integer NOT NULL
);


CREATE TABLE tarjeta (
	idtarjeta         serial PRIMARY KEY,
	idusuario         integer NOT NULL,
	idtipotarjeta     integer NOT NULL,
	idbanco           integer NOT NULL,
	numero            integer NOT NULL,
	fecha_vencimiento date NOT NULL,
	cvc               integer NOT NULL,
	estatus           integer NOT NULL
);
-- ALTER TABLE tarjeta
-- ADD CONSTRAINT estatustarjeta_check (estatus IN ('',''));


CREATE TABLE operaciontarjeta (
	idoperaciontarjeta serial PRIMARY KEY,
	idusuarioreceptor  integer NOT NULL,
	idtarjeta          integer NOT NULL,
	fecha              date NOT NULL,
	hora               time NOT NULL,
	monto              decimal NOT NULL,
	referencia         integer NOT NULL
);


CREATE TABLE tipotarjeta (
	idtipotarjeta serial PRIMARY KEY,
	descripcion   varchar(20) NOT NULL,
	estatus       integer NOT NULL
);
-- ALTER TABLE tipotarjeta
-- ADD CONSTRAINT estatustipotarjeta_check (estatus IN ('',''));



/********** claves foraneas **************/

ALTER TABLE usuario ADD CONSTRAINT id_tipousuario FOREIGN KEY (idtipousuario) REFERENCES tipousuario (idtipousuario);
ALTER TABLE usuario ADD CONSTRAINT id_tipoidentificacion FOREIGN KEY (idtipoidentificacion) REFERENCES tipoidentificacion (idtipoidentificacion);
ALTER TABLE contrasena ADD CONSTRAINT id_usuario FOREIGN KEY (idusuario) REFERENCES usuario (idusuario);
ALTER TABLE opcionmenu ADD CONSTRAINT id_aplicacion FOREIGN KEY (idaplicacion) REFERENCES aplicacion (idaplicacion);
ALTER TABLE bitacora ADD CONSTRAINT id_usuariobit FOREIGN KEY (idusuario) REFERENCES usuario (idusuario);
ALTER TABLE bitacora ADD CONSTRAINT id_evento FOREIGN KEY (idevento) REFERENCES evento (idevento);
-- ALTER TABLE pago ADD CONSTRAINT id_solicitante FOREIGN KEY (idusuario_solicitante) REFERENCES usuario_opcionmenu (idusuario);
-- ALTER TABLE pago ADD CONSTRAINT id_receptor FOREIGN KEY (idusuario_receptor) REFERENCES usuario_opcionmenu (idusuario);
ALTER TABLE reintegro ADD CONSTRAINT id_solicitantereintegro FOREIGN KEY (idusuario_solicitante) REFERENCES usuario (idusuario);
ALTER TABLE reintegro ADD CONSTRAINT id_receptorreintegro FOREIGN KEY (idusuario_receptor) REFERENCES usuario (idusuario);
ALTER TABLE persona ADD CONSTRAINT id_estadocivil FOREIGN KEY (idestadocivil) REFERENCES estadocivil (idestadocivil);
ALTER TABLE operacionesmonedero ADD CONSTRAINT id_usuarioom FOREIGN KEY (idusuario) REFERENCES usuario (idusuario);
ALTER TABLE operacionesmonedero ADD CONSTRAINT id_tipooperacion FOREIGN KEY (idtipooperacion) REFERENCES tipooperacion (idtipooperacion);
ALTER TABLE parametro ADD CONSTRAINT id_tipoparametro FOREIGN KEY (idtipoparametro) REFERENCES tipoparametro (idtipoparametro);
ALTER TABLE parametro ADD CONSTRAINT id_frecuencia FOREIGN KEY (idfrecuencia) REFERENCES frecuencia (idfrecuencia);
ALTER TABLE cuenta ADD CONSTRAINT id_usuario FOREIGN KEY (idusuario) REFERENCES usuario (idusuario);
ALTER TABLE cuenta ADD CONSTRAINT id_banco FOREIGN KEY (idbanco) REFERENCES banco (idbanco);
ALTER TABLE cuenta ADD CONSTRAINT id_tipocuenta FOREIGN KEY (idtipocuenta) REFERENCES tipocuenta (idtipocuenta);
ALTER TABLE operacioncuenta ADD CONSTRAINT id_cuenta FOREIGN KEY (idcuenta) REFERENCES cuenta (idcuenta);
ALTER TABLE operacioncuenta ADD CONSTRAINT id_usuarioreceptor FOREIGN KEY (idusuarioreceptor) REFERENCES usuario (idusuario);
ALTER TABLE tarjeta ADD CONSTRAINT id_usuariotarjeta FOREIGN KEY (idusuario) REFERENCES usuario (idusuario);
ALTER TABLE tarjeta ADD CONSTRAINT id_bancotarjeta FOREIGN KEY (idbanco) REFERENCES banco (idbanco);
ALTER TABLE tarjeta ADD CONSTRAINT id_tipotarjeta FOREIGN KEY (idtipotarjeta) REFERENCES tipotarjeta (idtipotarjeta);
ALTER TABLE operaciontarjeta ADD CONSTRAINT id_usuarioreceptort FOREIGN KEY (idusuarioreceptor) REFERENCES usuario (idusuario);
ALTER TABLE operaciontarjeta ADD CONSTRAINT id_tarjetatarjeta FOREIGN KEY (idtarjeta) REFERENCES tarjeta (idtarjeta);



/*************** FIN ******************/