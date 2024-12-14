-- 1. Crear la base de datos
CREATE DATABASE SistemaPedidos;
GO
USE SistemaPedidos;

GO
-- 2. Tabla de Roles
CREATE TABLE Roles (
    RolID INT PRIMARY KEY IDENTITY(1,1),
    NombreRol VARCHAR(50) NOT NULL
);

GO
-- 3. Tabla de Colaboradores
CREATE TABLE Colaboradores (
    ColabID INT PRIMARY KEY IDENTITY(1,1),
	ColabName VARCHAR(25) NOT NULL,
	PasswordColab VARCHAR(13) NOT NULL,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Correo VARCHAR(50) NOT NULL,
	DireccionColab VARCHAR(50) NOT NULL,
	TelefonoColab VARCHAR(15) NOT NULL,
    RolID INT FOREIGN KEY REFERENCES Roles(RolID)
);
GO
-- 4. Tabla de Clientes
CREATE TABLE Clientes (
    ClienteID INT PRIMARY KEY IDENTITY(1,1),
	UserName VARCHAR(25) NOT NULL,
	Password VARCHAR(13)NOT NULL,
    NombreCliente VARCHAR(50) NOT NULL,
    ApellidoCliente VARCHAR(50) NOT NULL,
    Correo VARCHAR(50) NOT NULL,
    Telefono VARCHAR(15) NOT NULL,
	DireccionCli VARCHAR(50) NOT NULL,
    RolID INT FOREIGN KEY REFERENCES Roles(RolID)  -- Relación con Roles
);
GO
--5. Tabla de Ventas
CREATE TABLE Ventas (
    VentaID INT PRIMARY KEY IDENTITY(1,1),
    FechaVenta DATE NOT NULL,
    TotalVenta DECIMAL(10, 2) NOT NULL,
	ClienteID INT FOREIGN KEY REFERENCES Clientes(ClienteID) -- Relacion con Clientes
);
GO
-- 6. Tabla de Facturas
CREATE TABLE Facturas (
    FacturaID INT IDENTITY(1,1) PRIMARY KEY,  -- Clave primaria
    Folio VARCHAR(20) NOT NULL UNIQUE,        -- Folio adicional (único)
    NumeroFactura VARCHAR(50) NOT NULL UNIQUE, -- Número de factura único
    Fecha DATETIME NOT NULL,
    ClienteID INT NOT NULL,
    Total DECIMAL(10,2) NOT NULL,
    MetodoPago VARCHAR(50),
    FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID)
);
GO
-- 7. Tabla DE Detalles de Facturas
CREATE TABLE DetalleFactura (
    DetalleID INT IDENTITY(1,1) PRIMARY KEY,
    FacturaID INT NOT NULL,
    ProductoID INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (FacturaID) REFERENCES Facturas(FacturaID),
    FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
);
GO
-- 8. Tabla de Pedidos
CREATE TABLE Pedidos (
    PedidoID INT IDENTITY(1,1) PRIMARY KEY,
    FechaPedido DATETIME NOT NULL,
    ProveedorID INT NOT NULL,
    EstadoPedido VARCHAR(50) NOT NULL,
    TotalPedido DECIMAL(10,2) NOT NULL,
    Observaciones VARCHAR(200),
    FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID)
);
GO
-- 9. Tabla de Datalles de Pedidos
CREATE TABLE DetallePedido (
    DetallePedidoID INT IDENTITY(1,1) PRIMARY KEY,
    PedidoID INT NOT NULL,
    ProductoID INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (PedidoID) REFERENCES Pedidos(PedidoID),
    FOREIGN KEY (ProductoID) REFERENCES Productos(ProductoID)
);
GO
-- 10. Tabla de Provvedores
CREATE TABLE Proveedores(
	ProveedorID INT IDENTITY(1,1) PRIMARY KEY,
	NombreProveedor VARCHAR(50) NOT NULL,
	Telefono VARCHAR(15) NOT NULL
);
GO
-- 11. Tabla de Categorias
CREATE TABLE Categorias(
	CategoriaID INT IDENTITY(1,1) PRIMARY KEY,
	NombreCategoria VARCHAR (50) NOT NULL
);
GO
-- 12. Tabla de Productos
CREATE TABLE Productos(
	ProductoID INT IDENTITY(1,1) PRIMARY KEY,
	NombreProducto nvarchar(50) NOT NULL,
	Descripcion VARCHAR(200),
	PrecioUnitario decimal (10,2) NOT NULL,
	Stock INT NOT NULL,
	FechaIngreso DATE NOT NULL,
	CategoriaID INT,
	ProveedorID INT,
	FOREIGN KEY (CategoriaID) REFERENCES CATEGORIAS(CategoriaID),
	FOREIGN KEY (ProveedorID) REFERENCES PROVEEDORES(ProveedorID)
);