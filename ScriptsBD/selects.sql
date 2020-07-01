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

/*operacionCuenta*/

SELECT
	opc.idoperacioncuenta,
	opc.idcuenta,
	opc.idusuarioreceptor,
	opc.fecha,
	opc.hora,
	opc.monto,
	opc.referencia
FROM operacioncuenta opc
WHERE opc.idoperacioncuenta = 1

/*operacionesCuentas*/

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

/*operacionTarjeta*/

SELECT
	opc.idoperaciontarjeta,
	opc.idusuarioreceptor,
	opc.idtarjeta,
	opc.fecha,
	opc.hora,
	opc.monto,
	opc.referencia
FROM operaciontarjeta opc
WHERE opc.idoperaciontarjeta = 1

/*operacionesTarjetas*/

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

/* infoUsuario */ 

SELECT 
	us.idusuario,
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

/* infoCuenta */ 

SELECT 
    cu.idCuenta,
    cu.idTipoCuenta,
    cu.idBanco,
    cu.numero
FROM Cuenta AS cu
WHERE
	cu.idUsuario = 1

/* operacionesMonederos */
SELECT
	opm.idoperacionesmonedero,
	opm.idusuario,
	opm.idtipooperacion,
	opm.monto,
	opm.fecha,
	opm.hora,
	opm.referencia
FROM operacionesmonedero opm
WHERE opm.idusuario = 1

/* operacionMonedero */

SELECT
	opm.idoperacionesmonedero,
	opm.idusuario,
	opm.idtipooperacion,
	opm.monto,
	opm.fecha,
	opm.hora,
	opm.referencia
FROM operacionesmonedero opm
WHERE opm.idoperacionesmonedero = 1

/*infoReintegro*/

SELECT
	rei.idreintegro,
	rei.idusuario_solicitante,
	rei.idusuario_receptor,
	rei.fecha_solicitud,
	rei.referencia,
	rei.estatus 
FROM reintegro rei
WHERE rei.idreintegro = 1

/*infoReintegros*/

SELECT
	rei.idreintegro,
	rei.idusuario_solicitante,
	rei.idusuario_receptor,
	rei.fecha_solicitud,
	rei.referencia,
	rei.estatus 
FROM reintegro rei
WHERE rei.idusuario_solicitante = 1 
OR rei.idusuario_receptor = 1