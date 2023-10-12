-- evaluar si existe bd de ser asi eliminarla--
Drop database if exists CalmMind;

-- Crear la base de datos--
Create database CalmMind;
use CalmMind;

-- Evaluar
Drop table if exists imagenes;
CREATE table imagenes(
id_imagen int not null auto_increment,
imagen blob not null,
primary key(id_imagen)
);

Drop table if exists juego;
create table juego(
id_juego int not null auto_increment,
nombre_juego varchar(50) not null,
descripcion_juego text not null,
limite_tiempo char(5),
primary key(id_juego)
);

Drop table if exists usuario;
create table usuario(
id_usuario int not null auto_increment,
nombre_usuario varchar(50) not null,
contraseña_usuario varchar(20) not null,
primary key(id_usuario)
);

Drop table if exists profesional;
create table profesional(
id_profesional int not null auto_increment,
nombre_profesional varchar(100) not null,
apellido_profesional varchar(100) not null,
primary key(id_profesional)
);

Drop table if exists paciente;
create table paciente(
id_paciente int not null auto_increment,
nombre_paciente varchar(50) not null,
primary key(id_paciente)
);

Drop table if exists visita;
Create table visita(
id_visita int not null auto_increment,
fecha date not null,
proxi_visita date not null,
id_paciente int not null,
observacion text not null,
primary key(id_visita),
foreign key(id_paciente) references paciente(id_paciente)
);

Drop table if exists detalle_visita;
Create table detalle_visita(
id_detallevisita int not null auto_increment,
id_visita int not null,
id_juego int not null,
tiempo char(5) not null,
primary key(id_detallevisita),
foreign key(id_juego) references juego(id_juego),
foreign key(id_visita) references visita(id_visita)
);


