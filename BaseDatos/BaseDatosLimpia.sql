--
-- File generated with SQLiteStudio v3.0.6 on mié. sep. 28 22:15:30 2016
--
-- Text encoding used: windows-1252
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: TipoPoliza
CREATE TABLE TipoPoliza (PK_TipoPoliza INTEGER PRIMARY KEY NOT NULL, TipoPoliza VARCHAR (100) NOT NULL);
INSERT INTO TipoPoliza (PK_TipoPoliza, TipoPoliza) VALUES (1, 'auto');
INSERT INTO TipoPoliza (PK_TipoPoliza, TipoPoliza) VALUES (2, 'vida');
INSERT INTO TipoPoliza (PK_TipoPoliza, TipoPoliza) VALUES (3, 'gastos medicos');
INSERT INTO TipoPoliza (PK_TipoPoliza, TipoPoliza) VALUES (4, 'danios');

-- Table: Agentes
CREATE TABLE Agentes (PK_agente INTEGER PRIMARY KEY NOT NULL, NumeroAgente INTEGER NOT NULL, Nombre VARCHAR (100) NOT NULL);
INSERT INTO Agentes (PK_agente, NumeroAgente, Nombre) VALUES (1, 1, 'Ignacio Martine Diaz');

-- Table: Polizas
CREATE TABLE Polizas (PK_poliza INTEGER PRIMARY KEY, NumeroPoliza VARCHAR (100), PrimaPoliza REAL NOT NULL, ImporteTotal REAL NOT NULL, FechaExpedicion DATE NOT NULL, InicioVigencia DATE NOT NULL, FK_Agente INTEGER REFERENCES Agentes (PK_agente) NOT NULL, FK_Cliente INTEGER REFERENCES Cliente (PK_Cliente) ON DELETE CASCADE, Nueva BOOLEAN NOT NULL, FK_Compania INTEGER REFERENCES Compania (PK_Compania), Version VARCHAR (200), FK_TipoPoliza INTEGER REFERENCES TipoPoliza (PK_TipoPoliza), Adjunto VARCHAR (999), NumeroRenovacion VARCHAR (255), FrecuanciaDePago INTEGER NOT NULL, IVA REAL NOT NULL, PagoFraccionado REAL);

-- Table: Compania
CREATE TABLE Compania (PK_Compania INTEGER PRIMARY KEY, NombreCompania VARCHAR (100) NOT NULL);
INSERT INTO Compania (PK_Compania, NombreCompania) VALUES (1, 'gnp');
INSERT INTO Compania (PK_Compania, NombreCompania) VALUES (2, 'banorte');
INSERT INTO Compania (PK_Compania, NombreCompania) VALUES (3, 'axxa');
INSERT INTO Compania (PK_Compania, NombreCompania) VALUES (4, 'aba');

-- Table: Cliente
CREATE TABLE Cliente (PK_Cliente INTEGER PRIMARY KEY, Nombre VARCHAR (100) NOT NULL, RFC VARCHAR (16) NOT NULL, FechaNacimiento DATE NOT NULL, Telefono INTEGER (10) NOT NULL, CorreoElectronico VARCHAR (200));
INSERT INTO Cliente (PK_Cliente, Nombre, RFC, FechaNacimiento, Telefono, CorreoElectronico) VALUES (1, 'Fer', 'fey26363', '23/01/1992', 3319638873, 'mfer_briones@hotmail.com');
INSERT INTO Cliente (PK_Cliente, Nombre, RFC, FechaNacimiento, Telefono, CorreoElectronico) VALUES (2, 'paco', 'pac8977', '12/09/1970', 3337829318, 'paco.pinia15@hotmail');

-- Table: DireccionCliente
CREATE TABLE DireccionCliente (PK_DireccionCliente INTEGER PRIMARY KEY, FK_Cliente INTEGER REFERENCES Cliente (PK_Cliente) ON DELETE CASCADE, Calle VARCHAR (100) NOT NULL, NumeroInterior VARCHAR (10) NOT NULL, Colonia VARCHAR (100) NOT NULL, Estado VARCHAR (100) NOT NULL, Municipio VARCHAR (100) NOT NULL, CodigoPostal INTEGER NOT NULL);

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
