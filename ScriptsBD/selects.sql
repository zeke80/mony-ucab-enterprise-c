/*loginPersona*/
	
SELECT
	us.idusuario,
	us.idtipousuario,
	us.idtipoidentificacion,
	us.usuario,
	us.fecha_registro,
	us.nro_identificacion,
	us.email,
	us.telefono,
	us.direccion,
	us.estatus
FROM usuario us, contrasena co, persona pe
WHERE us.idusuario = pe.idusuario
	AND us.idusuario = co.idusuario
	AND us.usuario = 'user2'
	AND co.contrasena = '2';

/*loginComercio*/

SELECT
	us.idusuario,
	us.idtipousuario,
	us.idtipoidentificacion,
	us.usuario,
	us.fecha_registro,
	us.nro_identificacion,
	us.email,
	us.telefono,
	us.direccion,
	us.estatus
FROM usuario us, contrasena co, comercio com
WHERE us.idusuario = com.idusuario
	AND us.idusuario = co.idusuario
	AND us.usuario = 'user1'
	AND co.contrasena = '1';
	
/*infoPersona*/

SELECT
	per.idusuario,
	per.idestadocivil,
	per.nombre,
	per.apellido,
	per.fecha_nacimiento 
FROM persona per 
WHERE per.idusuario = 2

/*infoComercio*/

SELECT 
	com.idusuario,
	com.razon_social,
	com.nombre_representante,
	com.apellido_representante 
FROM comercio com 
WHERE com.idusuario = 1

/*infoCuentas*/

SELECT 
	idcuenta,
	idusuario,
	idtipocuenta,
	idbanco,
	numero 
FROM cuenta 
WHERE idusuario = 1

/*infoTarjetas*/

SELECT 
	idtarjeta,
	idusuario,
	idtipotarjeta,
	idbanco,
	numero,
	fecha_vencimiento,
	cvc,
	estatus 
FROM tarjeta 
WHERE idusuario = 2

/*operacionesCuenta*/

SELECT
	opc.idoperacioncuenta,
	opc.idcuenta,
	opc.idusuarioreceptor,
	opc.fecha,
	opc.hora,
	opc.monto,
	opc.referencia
FROM cuenta cue, operacioncuenta opc
WHERE cue.idcuenta = opc.idcuenta
AND cue.idusuario = 1
UNION
SELECT
	opc.idoperacioncuenta,
	opc.idcuenta,
	opc.idusuarioreceptor,
	opc.fecha,
	opc.hora,
	opc.monto,
	opc.referencia
FROM operacioncuenta opc
WHERE opc.idusuarioreceptor = 1

/*operacionesTarjeta*/

SELECT
	opc.idoperaciontarjeta,
	opc.idusuarioreceptor,
	opc.idtarjeta,
	opc.fecha,
	opc.hora,
	opc.monto,
	opc.referencia
FROM tarjeta tar, operaciontarjeta opc
WHERE tar.idtarjeta = opc.idtarjeta
AND tar.idusuario = 2
UNION
SELECT
	opc.idoperaciontarjeta,
	opc.idusuarioreceptor,
	opc.idtarjeta,
	opc.fecha,
	opc.hora,
	opc.monto,
	opc.referencia
FROM operaciontarjeta opc
WHERE opc.idusuarioreceptor = 2

/* Información de Usuario */ 

SELECT 
    us.idTipoUsuario, 
	us.idTipoIdentificacion, 
	us.usuario, 
	us.fecha_registro, 
	us.nro_identificacion,
	us.email,
	us.telefono,
	us.direccion,
	us.estatus
FROM Usuario AS us
WHERE
	us.idUsuario = 1

/* Información de Cuenta */ 

SELECT 
    cu.idCuenta,
    cu.idTipoCuenta,
    cu.idBanco,
    cu.numero
FROM Cuenta AS cu
WHERE
	cu.idUsuario = 1