/* LOGIN PERSONA */

CREATE OR REPLACE FUNCTION loginPersona(usu varchar(20), clave varchar(20))
RETURNS TABLE(us_idusuario integer, us_idtipousuario integer, us_idtipoidentificacion integer, us_usuario varchar(20), us_fecha_registro date, us_nro_identificacion integer, us_email varchar(200), us_telefono varchar(12), us_direccion varchar(500), us_estatus integer) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT us.idusuario, us.idtipousuario, us.idtipoidentificacion, us.usuario, us.fecha_registro, us.nro_identificacion, us.email, us.telefono, us.direccion, us.estatus
    FROM usuario us, contrasena co, persona pe WHERE us.idusuario = pe.idusuario AND us.idusuario = co.idusuario AND us.usuario = usu AND co.contrasena = clave LOOP
        us_idusuario := reg.us.idusuario;
        us_idtipousuario:= reg.us.idtipousuario;
        us_idtipoidentificacion:= reg.us.idtipoidentificacion;
        us_usuario:= reg.us.usuario;
        us_fecha_registro:= reg.us.fecha_registro;
        us_nro_identificacion := reg.us.nro_identificacion;
        us_email:= reg.us.email;
        us_telefono:= reg.us.telefono;
        us_direccion:= reg.us.direccion;
        us_estatus:= reg.us.estatus;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'




/* LOGIN COMERCIO */

CREATE OR REPLACE FUNCTION loginComercio(usu varchar(20), clave varchar(20))
RETURNS TABLE(us_idusuario integer, us_idtipousuario integer, us_idtipoidentificacion integer, us_usuario varchar(20), us_fecha_registro date, us_nro_identificacion integer, us_email varchar(200), us_telefono varchar(12), us_direccion varchar(500), us_estatus integer) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT us.idusuario, us.idtipousuario, us.idtipoidentificacion, us.usuario, us.fecha_registro, us.nro_identificacion, us.email, us.telefono, us.direccion, us.estatus
    FROM usuario us, contrasena co, comercio com WHERE us.idusuario = com.idusuario AND us.idusuario = co.idusuario AND us.usuario = usu AND co.contrasena = clave LOOP
        us_idusuario := reg.us.idusuario;
        us_idtipousuario:= reg.us.idtipousuario;
        us_idtipoidentificacion:= reg.us.idtipoidentificacion;
        us_usuario:= reg.us.usuario;
        us_fecha_registro:= reg.us.fecha_registro;
        us_nro_identificacion := reg.us.nro_identificacion;
        us_email:= reg.us.email;
        us_telefono:= reg.us.telefono;
        us_direccion:= reg.us.direccion;
        us_estatus:= reg.us.estatus;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'



/* INFO PERSONA */

CREATE OR REPLACE FUNCTION infoPersona(id integer)
RETURNS TABLE(p_idusuario integer, p_idestadocivil integer, p_nombre varchar(45), p_apellido varchar(45), p_fecha_nacimiento date) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idusuario, idestadocivil, nombre, apellido, fecha_nacimiento 
    FROM persona WHERE idusuario = id LOOP
        p_idusuario := reg.idusuario;
        p_idestadocivil:= reg.idestadocivil;
        p_nombre:= reg.nombre;
        p_apellido:= reg.apellido;
        p_fecha_nacimiento:= reg.fecha_nacimiento;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'




/* INFO COMERCIO */

CREATE OR REPLACE FUNCTION infoComercio(id integer)
RETURNS TABLE(com_idusuario integer, com_razon_social varchar(200), com_nombre_representante varchar(45), com_apellido_representante varchar(45)) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idusuario, razon_social, nombre_representante, apellido_representante 
    FROM comercio WHERE idusuario = id LOOP
        com_idusuario := reg.idusuario;
        com_razon_social:= reg.razon_social;
        com_nombre_representante:= reg.nombre_representante;
        com_apellido_representante := reg.apellido_representante;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'





/* INFO CUENTAS */

CREATE OR REPLACE FUNCTION infoCuentas(id integer)
RETURNS TABLE( id_cuenta integer, id_usuario integer, id_tipocuenta integer, id_banco integer, num varchar(20)) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idcuenta, idusuario, idtipocuenta, idbanco, numero 
    FROM cuenta WHERE idusuario = id LOOP
        id_cuenta := reg.idcuenta;
        id_usuario:= reg.idusuario;
        id_tipocuenta:= reg.idtipocuenta;
        id_banco:= reg.idbanco;
        num:= reg.numero;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'




/* INFO TARJETAS */

CREATE OR REPLACE FUNCTION infoTarjetas(id integer)
RETURNS TABLE(tar_idtarjeta integer, tar_idusuario integer, tar_idtipotarjeta integer, tar_idbanco integer, tar_numero integer, tar_fecha_vencimiento date, tar_cvc integer, tar_estatus integer) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idtarjeta, idusuario, idtipotarjeta, idbanco, numero, fecha_vencimiento, cvc, estatus 
    FROM tarjeta WHERE idusuario = id LOOP
        tar_idtarjeta := reg.idtarjeta;
        tar_idusuario:= reg.idusuario;
        tar_idtipotarjeta:= reg.idtipotarjeta;
        tar_idbanco:= reg.idbanco;
        tar_numero:= reg.numero;
        tar_fecha_vencimiento:= reg.fecha_vencimiento;
        tar_cvc:= reg.cvc;
        tar_estatus:= reg.estatus;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'



/* OPERACION CUENTA */

CREATE OR REPLACE FUNCTION operacionCuenta(id integer)
RETURNS TABLE(opc_idoperacioncuenta integer, opc_idcuenta integer, opc_idusuarioreceptor integer, opc_fecha date, opc_hora time, opc_monto decimal, opc_referencia varchar(45)) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idoperacioncuenta, idcuenta, idusuarioreceptor, fecha, hora, monto, referencia 
    FROM operacioncuenta WHERE idoperacioncuenta = id LOOP
        opc_idoperacioncuenta := reg.idoperacioncuenta;
        opc_idcuenta:= reg.idcuenta;
        opc_idusuarioreceptor:= reg.idusuarioreceptor;
        opc_fecha:= reg.fecha;
        opc_hora:= reg.hora;
        opc_monto:= reg.monto;
        opc_referencia:= reg.referencia;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'



/* OPERACION CUENTAS */

CREATE OR REPLACE FUNCTION operacionesCuentas(id integer)
RETURNS TABLE(opc_idoperacioncuenta integer, opc_idcuenta integer, opc_idusuarioreceptor integer, opc_fecha date, opc_hora time, opc_monto decimal, opc_referencia varchar(45)) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT opc.idoperacioncuenta, opc.idcuenta, opc.idusuarioreceptor, opc.fecha, opc.hora, opc.monto, opc.referencia
    FROM cuenta cue, operacioncuenta opc WHERE cue.idcuenta = opc.idcuenta AND cue.idusuario = id
    UNION SELECT opc.idoperacioncuenta, opc.idcuenta, opc.idusuarioreceptor, opc.fecha, opc.hora, opc.monto, opc.referencia 
    FROM operacioncuenta opc WHERE opc.idusuarioreceptor = id LOOP
    
        opc_idoperacioncuenta := reg.idoperacioncuenta;
        opc_idcuenta:= reg.idcuenta;
        opc_idusuarioreceptor:= reg.idusuarioreceptor;
        opc_fecha:= reg.fecha;
        opc_hora:= reg.hora;
        opc_monto := reg.monto;
        opc_referencia:= reg.referencia;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'




/* OPERACIONES TARJETAS */

CREATE OR REPLACE FUNCTION operacionesTarjetas(id integer)
RETURNS TABLE(opc_idoperaciontarjeta integer, opc_idusuarioreceptor integer, opc_idtarjeta integer, opc_fecha date, opc_hora time, opc_monto decimal, opc_referencia varchar(45)) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT opc.idoperaciontarjeta, opc.idusuarioreceptor, opc.idtarjeta, opc.fecha, opc.hora, opc.monto, opc.referencia
    FROM tarjeta tar, operaciontarjeta opc WHERE tar.idtarjeta = opc.idtarjeta AND tar.idusuario = id
    UNION SELECT opc.idoperaciontarjeta, opc.idusuarioreceptor, opc.idtarjeta, opc.fecha, opc.hora, opc.monto, opc.referencia 
    FROM operaciontarjeta opc WHERE opc.idusuarioreceptor = id LOOP
    
        opc_idoperaciontarjeta := reg.idoperaciontarjeta;
        opc_idusuarioreceptor:= reg.idusuarioreceptor;
        opc_idtarjeta:= reg.idtarjeta;
        opc_fecha:= reg.fecha;
        opc_hora:= reg.hora;
        opc_monto := reg.monto;
        opc_referencia:= reg.referencia;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'




/* OPERACION TARJETA */

CREATE OR REPLACE FUNCTION operacionTarjeta(id integer)
RETURNS TABLE(opt_idoperaciontarjeta integer, opt_idusuarioreceptor integer, opt_idtarjeta integer, opt_fecha date, opt_hora time, opt_monto decimal, opt_referencia  varchar(45)) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idoperaciontarjeta, idusuarioreceptor, idtarjeta, fecha, hora, monto, referencia
    FROM operaciontarjeta WHERE idoperaciontarjeta = id LOOP
        opt_idoperaciontarjeta := reg.idoperaciontarjeta;
        opt_idusuarioreceptor:= reg.idusuarioreceptor;
        opt_idtarjeta:= reg.idtarjeta;
        opt_fecha:= reg.fecha;
        opt_hora:= reg.hora;
        opt_monto:= reg.monto;
        opt_referencia:= reg.referencia;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'



/* INFO USUARIO */ 

CREATE OR REPLACE FUNCTION infoUsuario(id integer)
RETURNS TABLE(us_idusuario integer, us_idtipousuario integer, us_idtipoidentificacion integer, us_usuario varchar(20), us_fecha_registro date, us_nro_identificacion integer, us_email varchar(200), us_telefono varchar(12), us_direccion varchar(500), us_estatus integer) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idusuario, idTipoUsuario, idTipoIdentificacion, usuario, fecha_registro, nro_identificacion, email, telefono, direccion, estatus
    FROM Usuario WHERE idUsuario = id LOOP
        us_idusuario := reg.idusuario;
        us_idtipousuario:= reg.idTipoUsuario;
        us_idtipoidentificacion:= reg.idTipoIdentificacion;
        us_usuario:= reg.usuario;
        us_fecha_registro:= reg.fecha_registro;
        us_nro_identificacion:= reg.nro_identificacion;
        us_email:= reg.email;
        us_telefono:= reg.telefono;
        us_direccion:= reg.direccion;
        us_estatus:= reg.estatus;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'



/* INFO CUENTA */

CREATE OR REPLACE FUNCTION infoCuenta(id integer)
RETURNS TABLE(cu_idcuenta integer, cu_idtipocuenta integer, cu_idbanco integer, cu_numero varchar(20)) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idCuenta, idTipoCuenta, idBanco, numero
    FROM Cuenta WHERE idUsuario = id LOOP
        cu_idcuenta := reg.idCuenta;
        cu_idtipocuenta:= reg.idTipoCuenta;
        cu_idbanco:= reg.idBanco;
        cu_numero:= reg.numero;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'


/* OPERACIONES MONEDEROS */

CREATE OR REPLACE FUNCTION operacionesMonederos(id integer)
RETURNS TABLE(opm_idoperacionesmonedero integer, opm_idusuario integer, opm_idtipooperacion integer, opm_monto decimal, opm_fecha date, opm_hora time, opm_referencia varchar(45)) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idoperacionesmonedero, idusuario, idtipooperacion, monto, fecha, hora, referencia
    FROM operacionesmonedero WHERE idUsuario = id LOOP
        opm_idoperacionesmonedero := reg.idoperacionesmonedero;
        opm_idusuario:= reg.idusuario;
        opm_idtipooperacion:= reg.idtipooperacion;
        opm_monto:= reg.monto;
        opm_fecha:= reg.fecha;
        opm_hora:= reg.hora;
        opm_referencia:= reg.referencia;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'



/* OPERACION MONEDERO */

CREATE OR REPLACE FUNCTION operacionMonedero(id integer)
RETURNS TABLE(opm_idoperacionesmonedero integer, opm_idusuario integer, opm_idtipooperacion integer, opm_monto decimal, opm_fecha date, opm_hora time, opm_referencia varchar(45)) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idoperacionesmonedero, idusuario, idtipooperacion, monto, fecha, hora, referencia
    FROM operacionesmonedero WHERE idoperacionesmonedero = id LOOP
        opm_idoperacionesmonedero := reg.idoperacionesmonedero;
        opm_idusuario:= reg.idusuario;
        opm_idtipooperacion:= reg.idtipooperacion;
        opm_monto:= reg.monto;
        opm_fecha:= reg.fecha;
        opm_hora:= reg.hora;
        opm_referencia:= reg.referencia;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'



/* INFO REINTEGRO */

CREATE OR REPLACE FUNCTION infoReintegro(id integer)
RETURNS TABLE(rei_idreintegro integer, rei_idusuario_solicitante integer, rei_idusuario_receptor integer, rei_fecha_solicitud varchar(45), rei_referencia varchar(45), rei_estatus varchar(45)) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idreintegro, idusuario_solicitante, idusuario_receptor, fecha_solicitud, referencia, estatus
    FROM reintegro WHERE idreintegro = id LOOP
        rei_idreintegro := reg.idreintegro;
        rei_idusuario_solicitante:= reg.idusuario_solicitante;
        rei_idusuario_receptor:= reg.idusuario_receptor;
        rei_fecha_solicitud:= reg.fecha_solicitud;
        rei_referencia:= reg.referencia;
        rei_estatus:= reg.estatus;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'



/* INFO REINTEGROS */

CREATE OR REPLACE FUNCTION infoReintegros(id integer)
RETURNS TABLE(rei_idreintegro integer, rei_idusuario_solicitante integer, rei_idusuario_receptor integer, rei_fecha_solicitud varchar(45), rei_referencia varchar(45), rei_estatus varchar(45)) AS
$BODY$
DECLARE
    reg RECORD;
BEGIN
    FOR REG IN SELECT idreintegro, idusuario_solicitante, idusuario_receptor, fecha_solicitud, referencia, estatus
    FROM reintegro WHERE idusuario_solicitante = id OR idusuario_receptor = id LOOP
        rei_idreintegro := reg.idreintegro;
        rei_idusuario_solicitante:= reg.idusuario_solicitante;
        rei_idusuario_receptor:= reg.idusuario_receptor;
        rei_fecha_solicitud:= reg.fecha_solicitud;
        rei_referencia:= reg.referencia;
        rei_estatus:= reg.estatus;
        RETURN NEXT;
    END LOOP;
    RETURN;
END
$BODY$ LANGUAGE 'plpgsql'