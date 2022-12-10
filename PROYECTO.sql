--Creando la Base de Datos--
USE master
GO
IF object_id('PROYECTO13') is not null
DELETE PROYECTO13;
GO
CREATE DATABASE PROYECTO13
ON
(NAME = PROYECTO13,
    FILENAME = 'C:\ProyectoSistemaAsistenciap1\Chris\PROYECTO13.mdf',
SIZE = 10,
MAXSIZE = 50,
FILEGROWTH = 5 )
LOG ON
(NAME = PROYECTO13_LOG,
    FILENAME = 'C:\ProyectoSistemaAsistenciap1\Chris\PROYECTO13_Log.ldf',
SIZE = 5MB,
MAXSIZE = 25MB,
FILEGROWTH = 5MB );
GO
--___________________________________________________TABLA ALUMNOS___________________________________________________________________--
USE PROYECTO13
GO
IF object_id('ALUMNOS') is not null
DROP TABLE ALUMNOS;
GO
CREATE TABLE ALUMNOS(
BOLETA INT PRIMARY KEY IDENTITY (2021130000,362) NOT NULL,
PrimerA NVARCHAR(25) NOT NULL,
SegundoA NVARCHAR(25)NOT NULL,
NOMBRE NVARCHAR(25)NOT NULL,
EDAD INT NOT NULL,
FECHAN DATE NOT NULL,
CORREO NVARCHAR(50) NOT NULL,
TELEFONO NVARCHAR(10) NOT NULL
)
GO

INSERT INTO ALUMNOS
VALUES
('GOMEZ','SOTO', 'DIEGO',17,'2005/06/06','diegogsxd@gmail.com','5566566928'),
('Angelina','Sánchez','Ricardo',17,'2005/04/26','angelina.sanchez.ricard.ipn@gmail.com','5546392863'),
('Arellano','Morales','Irais',17,'2004/11/06','arellanoirais295@gmail.com','5525289301'),
('Belmontes','Bueno','Emiliano',16,'2005/11/15','beltemontes.bueno.emiliano.ipn@gmail.com','4778510887'),
('Bravo','Valdés','Miguel Angel',18,'2004/04/16','miguel.angel.valdes.bravo@gmail.com','5521840125'),
('Cosio','de la Cruz','Alan',16,'2005/09/06','alan.cosio.cruz.ipn@gmail.com','2721750849'),
('Cruz','Buchán','Laura Alexandría',16,'2005/05/09','laura.cruz.buchan.ipn@gmail.com','5568536384'),
('Cruz','Soberanes','Daniel',17,'2005/07/25','danaiel.cruz.soberanes.ipn@gmail.com','5588366361'),
('Escalona','Mejía','Arturo Uriel',17,'2005/11/20','arturo.uriel.escalona.mejia.ipn@gmail.com','5610827237'),
('Garcia','Oliva','Dafne Vianney',17,'2006/11/15','dafne.garciua.oliva.ipn@gmail.com','5574385760'),
('Gonzalez','García','Benjamín Azael',17,'2005/04/02','benjamín.gonzaua.garcía.ipn@gmail.com','5571415840'),
('Jiménez','Lara','Patricia Daniela',17,'2005/03/29','patricia.jiménua.lara.ipn@gmail.com','5584287948'),
('Martine','Lozano','Jose Edgar',17,'2005/09/10','jose.martiua.lozano.ipn@gmail.com','5621414741'),
('Mendoza','Santoyo','Fernando',16,'2007/04/26','mendoza.santoyo.fernando.ipn@gmail.com','5632969925'),
('Ortega','Rios','Emilio',18,'2004/06/14','ortega.emilio.cecyt.ipn@gmail.com','514369874'),
('Ortigoza','Santiago','Claudia Ismerai',17,'2004/11/15','claudia.ortigua.santiago.ipn@gmail.com','5549622530'),
('Palacios','Cuéllar','Christian Elohim',19,'2003/04/18','PalaciosCuellarChrisEloV13IPN@gmail.com','5517024935'),
('Ramirez','Pacheco','Emmanuel',17,'2005/12/17','ramirez.pacheco.emmanuel.ipn@gmail.com','5561379754'),
('Rangel','Granados','Giovanny',18,'2004/04/16','giovanny.granadoss.rangel.ipn@gamil.com','5511945915'),
('Salazar','Martinez','Vicente Axel',17, '2005/03/08','salazar.martinez.vicente axel.ipn@gmail.com','5565155170')
GO

SELECT*FROM ALUMNOS
GO
--___________________________________________________TABLA PROFESORES________________________________________________________________--
USE PROYECTO13
GO
IF object_id('PROFESORES') is not null
DROP TABLE PROFESORES;
GO
CREATE TABLE PROFESORES(
CVEPROFESOR INT PRIMARY KEY IDENTITY (20049,215) NOT NULL,
PrimerA NVARCHAR(25) NOT NULL,
SegundoA NVARCHAR(25)NOT NULL,
NOMBRE NVARCHAR(25)NOT NULL,
CORREO NVARCHAR(50) NOT NULL,
TELEFONO NVARCHAR(10) NOT NULL,
IDUSUARIOProf INT  NOT NULL,
CONSTRAINT FK_OPERACIONES_NoUsuario FOREIGN KEY (IDUSUARIOProf) REFERENCES USUARIO(IDUSUARIO)
)
GO

INSERT INTO PROFESORES
VALUES
('GOMEZ','SOTO', 'DIEGO','diegogsxd@gmail.com','5566566928'),
('Angelina','Sánchez','Ricardo','angelina.sanchez.ricard.ipn@gmail.com','5546392863'),
('Arellano','Morales','Irais','arellanoirais295@gmail.com','5525289301'),
('Belmontes','Bueno','Emiliano','beltemontes.bueno.emiliano.ipn@gmail.com','4778510887'),
('Bravo','Valdés','Miguel Angel','miguel.angel.valdes.bravo@gmail.com','5521840125'),
('Cosio','de la Cruz','Alan','alan.cosio.cruz.ipn@gmail.com','2721750849'),
('Cruz','Buchán','Laura Alexandría','laura.cruz.buchan.ipn@gmail.com','5568536384'),
('Cruz','Soberanes','Daniel','danaiel.cruz.soberanes.ipn@gmail.com','5588366361'),
('Escalona','Mejía','Arturo Uriel','arturo.uriel.escalona.mejia.ipn@gmail.com','5610827237'),
('Garcia','Oliva','Dafne Vianney','dafne.garciua.oliva.ipn@gmail.com','5574385760'),
('Gonzalez','García','Benjamín Azael','benjamín.gonzaua.garcía.ipn@gmail.com','5571415840'),
('Jiménez','Lara','Patricia Daniela','patricia.jiménua.lara.ipn@gmail.com','5584287948'),
('Martine','Lozano','Jose Edgar','jose.martiua.lozano.ipn@gmail.com','5621414741'),
('Mendoza','Santoyo','Fernando','mendoza.santoyo.fernando.ipn@gmail.com','5632969925'),
('Ortega','Rios','Emilio','ortega.emilio.cecyt.ipn@gmail.com','514369874'),
('Ortigoza','Santiago','Claudia Ismerai','claudia.ortigua.santiago.ipn@gmail.com','5549622530'),
('Palacios','Cuéllar','Christian Elohim','PalaciosCuellarChrisEloV13IPN@gmail.com','5517024935'),
('Ramirez','Pacheco','Emmanuel','ramirez.pacheco.emmanuel.ipn@gmail.com','5561379754'),
('Rangel','Granados','Giovanny','giovanny.granadoss.rangel.ipn@gamil.com','5511945915'),
('Salazar','Martinez','Vicente Axel','salazar.martinez.vicente axel.ipn@gmail.com','5565155170')
GO

SELECT*FROM PROFESORES
GO
--___________________________________________________TABLA MATERIACOD_______________________________________________________________--
Use PROYECTO13;
IF object_id('MATERIACOD') is not null
DROP TABLE MATERIACOD;
GO
CREATE TABLE MATERIACOD(
IDMATERIA INT PRIMARY KEY IDENTITY (20049,215) NOT NULL,
MATERIA NVARCHAR(20) NOT NULL
)
GO

INSERT INTO MATERIACOD
VALUES
('CALCULO INTEGRAL'),
('CALCULO DIFERENCIAL'),
('CONTABILIDAD II'),
('HISTORIA DE MEXICO'),
('GEOMETRIA ANALITICA'),
('BASE DE DATOS'),
('PROGRAMACION'),
('DERECHO'),
('REALIDAD VIRTUAL'),
('INGLES'),
('MICROECONOMIA'),
('CONTABILIDAD I'),
('CONTABILIDAD III'),
('ORIENTACION I'),
('ORIENTACION II'),
('MODELADO DE SISTEMAS'),
('PROGRAMACION BASICA'),
('PROGEAMACAION AVANZADA'),
('ENSAMBLADO'),
('INGLES II')
GO

SELECT*FROM MATERIACOD
GO
--___________________________________________________TABLA MATERIAprof_______________________________________________________________--
USE PROYECTO13;
IF object_id('ALUMNOS') is not null
DROP TABLE ALUMNOS;
GO
CREATE TABLE MATERIAprof(
CVEMATERIA INT NOT NULL,
NOPROFESOR INT NOT NULL,
CONSTRAINT FK_OPERACIONES_Nomat FOREIGN KEY (CVEMATERIA) REFERENCES MATERIACOD(IDMATERIA),
CONSTRAINT FK_OPERACIONES_NoPROF FOREIGN KEY (NOPROFESOR) REFERENCES PROFESORES(CVEPROFESOR))
GO
--___________________________________________________TABLA MATERIAalumn______________________________________________________________--
USE PROYECTO13;
IF object_id('MATERIAalumn') is not null
DROP TABLE MATERIAalumn;
GO
create table MATERIAalum(
CVEMATERIA INT NOT NULL,
NOALUMNO INT NOT NULL,
CONSTRAINT FK_OPERACIONES_NoMATi FOREIGN KEY (CVEMATERIA) REFERENCES MATERIACOD(IDMATERIA),
CONSTRAINT FK_OPERACIONES_NoALUM FOREIGN KEY (NOALUMNO) REFERENCES ALUMNOS(BOLETA)

)
GO
--___________________________________________________TABLA ASISTENCIAS______________________________________________________________--
CREATE TABLE ASISTENCIAS(
CVEASISTENCIAS INT PRIMARY KEY IDENTITY (209,35) NOT NULL,
NOALUMNO INT NOT NULL,
FECHA DATE NOT NULL,
HORA TIME NOT NULL,
IPMATERIA INT NOT NULL,
NOPROFESOR INT NOT NULL,

CONSTRAINT FK_OPERACIONES_NoPROFi FOREIGN KEY (NOPROFESOR) REFERENCES PROFESORES(CVEPROFESOR),
CONSTRAINT FK_OPERACIONES_NoMETRIA FOREIGN KEY (IPMATERIA) REFERENCES MATERIACOD(IDMATERIA),
CONSTRAINT FK_OPERACIONES_NoALUMI FOREIGN KEY (NOALUMNO) REFERENCES ALUMNOS(BOLETA)
)
GO
SELECT*FROM ASISTENCIAS;
select*from ALUMNOS
GO
--___________________________________________________TABLA USUARIO___________________________________________________________________--
USE PROYECTO13;
IF object_id('USUARIO') is not null
DROP TABLE USUARIO;
GO
CREATE TABLE USUARIO 
(
IDUSUARIO INT PRIMARY KEY IDENTITY (2021130000,362) NOT NULL,
NOMBREUsuario NVARCHAR (30) NOT NULL,
CONTRASEÑAUsuario NVARCHAR (15) NOT NULL
)
GO
SELECT BOLETA,PrimerA,SegundoA,NOMBRE FROM ALUMNOS WHERE BOLETA LIKE 2021137240
go
Select*from Alumnos;