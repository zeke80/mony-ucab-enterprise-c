SELECT
	us.idusuario,
	us.idtipousuario,
	us.idtipoidentificacion,
	us.usuario,
	us.fecha_registro,
	us.nro_identificacion,
	us.email,
	us.telefono,direccion,
	us.estatus
	FROM usuario us, contrasena co, comercio com
	WHERE us.idusuario = com.idusuario
	AND us.idusuario = co.idusuario
	AND us.usuario = 'user1'
	AND co.contrasena = '1';
	
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