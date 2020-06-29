insert into tipousuario(descripcion,estatus)
values
('COMERCIO',1),
('PERSONA',2);

insert into tipoidentificacion(codigo,descripcion,estatus)
values
(1,'1',1),
(2,'2',2),
(3,'3',3),
(4,'4',4);

insert into usuario(idtipousuario,idtipoidentificacion,usuario,fecha_registro,nro_identificacion,email,telefono,direccion,estatus)
values
(1,1,'JUANPABLOF',to_date('06-02-2018','dd-MM-yyyy'),1,'JUANPABLOFER@GMAIL.COM','04143255886','DE SANTO TOMAS A PALO BLANCO, SAN JOSE, VENEZUELA',1),
(1,2,'BRAYANDS',to_date('30-11-2018','dd-MM-yyyy'),2,'BRAYANDESOUSA@GMAIL.COM','04243698514','AV FERNANDO PENALVERT, SAN BERNARDINO, VENEZUELA',1),
(2,3,'ANAPACHECO',to_date('16-12-2019','dd-MM-yyyy'),3,'ANAPACHECO92@GMAIL.COM','04161478523','DE TORO A CARDONE, LA PASTORA, VENEZUELA',1),
(2,4,'ADRAIANAJACO',to_date('31-07-2019','dd-MM-yyyy'),4,'JACOMEADRIANA@GMAIL.COM','04122581436','AV MICHELENA, SAN BERNARDINO, VENEZUELA',1);

insert into contrasena(idusuario,contrasena,intentos_fallidos,estatus)
values
(1,'Juanpa1',0,1),
(1,'Ferreira0236',0,0),
(2,'Ds1234',0,1),
(2,'DS965231',0,0),
(3,'Ana0102',0,1),
(3,'PACHECO9036',0,0),
(4,'Jacome12',0,1),
(4,'AdrianA0136',0,0);

insert into estadocivil(descripcion,codigo,estatus)
values
('SOLTERO','1',1),
('CASADO','2',1);

insert into persona(idusuario,idestadocivil,nombre,apellido,fecha_nacimiento)
values
(1,1,'JUAN','FERREIRA',to_date('08-02-1997','dd-MM-yyyy')),
(2,2,'BRAYAN','DE SOUSA',to_date('10-11-1996','dd-MM-yyyy'));

insert into comercio(idusuario,razon_social,nombre_representante,apellido_representante)
VALUES
(3,'PACHECO Y ASOCIADOS S.R.L','ANA','PACHECO'),
(4,'INVERSIONES 1996 C.A','ADRIANA','JACOME');

insert into tipocuenta(descripcion,estatus)
values
('AHORRO',1),
('CORRIENTE',1);

insert into banco(nombre,estatus)
values
('MERCANTIL',1),
('BOD',1),
('BANCO DE VENEZUELA',1),
('BANCARIBE',1),
('BANCO PLAZA',1),
('BANCO BICENTENARIO',1);

insert into cuenta(idusuario,idtipocuenta,idbanco,numero)
values
(1,1,1,'5018782000003652'),
(1,2,2,'1424662365639532'),
(2,1,3,'1255896365422665'),
(2,2,3,'7852366236652236'),
(3,2,4,'8962236222265123'),
(4,1,6,'1221221122100224');

insert into tipotarjeta(descripcion,estatus)
values
('DEBITO',1),
('CREDITO',2);

insert into tarjeta(idusuario,idtipotarjeta,idbanco,numero,fecha_vencimiento,cvc,estatus)
values
(1,1,1,'5015500236655898',to_date('15-07-2020','dd-MM-yyyy'),114,1),
(1,2,4,'1236589652321457',to_date('02-02-2021','dd-MM-yyyy'),889,1),
(2,2,1,'1478536985022561',to_date('12-08-2026','dd-MM-yyyy'),036,1),
(2,2,1,'1258935550033665',to_date('12-08-2020','dd-MM-yyyy'),991,1),
(3,2,1,'3202563694422554',to_date('24-08-2023','dd-MM-yyyy'),361,1),
(3,1,1,'1033265897400069',to_date('18-02-2024','dd-MM-yyyy'),032,1),
(4,1,1,'1256955426652366',to_date('02-09-2028','dd-MM-yyyy'),785,1),
(4,1,1,'1188568422336655',to_date('20-01-2022','dd-MM-yyyy'),742,1);

insert into tipooperacion(descripcion,estatus)
values
('DEBITO', 1),
('CREDITO', 1);
