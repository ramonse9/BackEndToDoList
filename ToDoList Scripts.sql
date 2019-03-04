create database dbToDoList

use dbToDoList

create table Usuario
(
	idusuario integer primary key identity,
	nombre varchar(50) not null,
	email varchar(50) not null unique,
	passwordhash varbinary(MAX) not null,
	passwordsalt varbinary(MAX) not null
)

insert into Usuario (nombre,email, passwordhash, passwordsalt) values ('Indra Sarahi', 'desarrollohumano@adsum.com.mx',0xD6511FED1D3735363445C78FE90E9FA43090135F91536FEB42A07A94164C093CA3B37F82299DBBD67E6E7884BE1AECA7AE4F8B7814E85845BF788BE2B50A4804,0xF1ECF1FF4331F7EC96C233CBA45C3C880E27D88ADC66964A239E617AA12E791976FA229769B874CFEBAC1CAB49BF94B8B8F5032217C83D4E69EDA25005B0709BEC2533615689C100E465EFA211945F4364854C123853B56D6EADC5E6268F74EEBF5AAAB1A36A092C77EA965FFA16390B2BC0FF3923591AAE5FD7EBB404536412)

insert into Usuario (nombre,email, passwordhash, passwordsalt ) values ('Ramonb Guzman', 'ramonantoniojr@gmail.com', 0xD6511FED1D3735363445C78FE90E9FA43090135F91536FEB42A07A94164C093CA3B37F82299DBBD67E6E7884BE1AECA7AE4F8B7814E85845BF788BE2B50A4804,0xF1ECF1FF4331F7EC96C233CBA45C3C880E27D88ADC66964A239E617AA12E791976FA229769B874CFEBAC1CAB49BF94B8B8F5032217C83D4E69EDA25005B0709BEC2533615689C100E465EFA211945F4364854C123853B56D6EADC5E6268F74EEBF5AAAB1A36A092C77EA965FFA16390B2BC0FF3923591AAE5FD7EBB404536412)

create table Actividad
(
	idactividad integer primary key identity,
	nombre varchar(50) not null unique,
	descripcion varchar(256) not null,
	idusuario integer not null,
	finalizada bit default(0),
	FOREIGN KEY (idusuario) REFERENCES Usuario(idusuario)
)

insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Buscar programadores', 'Buscar probables candidatos para cubrir la vacante de programador',1,1)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Evaluar a los 10 posibles candidatos', 'Revisar los mejores perfiles para el puesto',1,1)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Hacer una llamada a cada candidato', 'Se le llamara a cada candidato para ver su interes y disponibilidad',1,1)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Llamar a Ramon Antonio Guzman', 'Se le llamara y hara una breve explicacion de lo que se trata el puesto disponible',1,1)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Examen psicometrico', 'Se enviara un examen psicometrico por correo',1,1)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Entrevista personal', 'Se le hara una primer entrevista de manera personal para ver detalles generales',1,1)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Entrevista con gerente de informatica', 'La gerente de informatia evauara de manera general al candidato',1,1)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Enviar examen', 'La gerente le solicitara hacer una aplicacion web para evaluar la manera de trabajar',1,1)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Evaluar examen', 'Se revisara el examen, funcionalidad y codigoo fuente',1,0)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Realizar una mejor propuesta', 'Una vez revisado el examen, se realizara una propuesta',1,0)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Darle la bienvenida', 'Darle la bienvenida a Ramon Antonio Guzman',1,0)

insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Realizar el examen psicometrico', 'Contestar el examen psicometrico',2,1)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Asistir a la entrevista', 'Asitir a la entrevista con Indra',2,1)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Revisar el examen', 'Analizar como se hara el examen solicitado',2,1)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Ver los detalles para enviar el examen', 'Revisar por que medio se enviara la aplicacion',2,0)
insert into Actividad (nombre, descripcion,idusuario,finalizada) values ('Generar el script de la base de datos', 'Se generar el script de la base de datos y se enviara ademas los detalles para ejecutar la aplicacion',2,0)


