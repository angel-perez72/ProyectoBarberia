
CREATE DATABASE ElMejorCorteBarbershop;
GO

USE ElMejorCorteBarbershop;
GO

CREATE TABLE Clientes
(
    Id INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Telefono VARCHAR(20) NOT NULL
);

CREATE TABLE Barberos
(
    Id INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL
);

CREATE TABLE Citas
(
    Id INT PRIMARY KEY,
    IdCliente INT NOT NULL,
    IdBarbero INT NOT NULL,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL,
    Estado VARCHAR(20) NOT NULL,

    FOREIGN KEY (IdCliente) REFERENCES Clientes(Id),
    FOREIGN KEY (IdBarbero) REFERENCES Barberos(Id)
);

CREATE TABLE ServiciosRealizados
(
    Id INT PRIMARY KEY,
    IdCita INT NOT NULL UNIQUE,
    Monto DECIMAL(10,2) NOT NULL,

    FOREIGN KEY (IdCita) REFERENCES Citas(Id)
);
