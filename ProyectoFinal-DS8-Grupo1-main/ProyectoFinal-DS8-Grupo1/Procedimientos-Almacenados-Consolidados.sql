--Procedimineto Almacenados de base de datos

--Procedimientos para Login
CREATE PROCEDURE ValidarCliente
    @UserName VARCHAR(25),
    @Password VARCHAR(13)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT c.RolID, r.NombreRol
    FROM Clientes c
    INNER JOIN Roles r ON c.RolID = r.RolID
    WHERE c.UserName = @UserName AND c.Password = @Password;
END;
GO
-- Validacion de Colaborador
CREATE PROCEDURE ValidarColaborador
    @UserName VARCHAR(25),
    @Password VARCHAR(13)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT u.RolID, r.NombreRol
    FROM Colaboradores u
    INNER JOIN Roles r ON u.RolID = r.RolID
    WHERE u.ColabName = @UserName AND u.PasswordColab = @Password;
END;
GO
--Procedimientos De La Tabla De Categorias
CREATE PROCEDURE InsertarCategoria
    @NombreCategoria VARCHAR(50),
	@Mensaje NVARCHAR(50) OUTPUT --Parametro de salida
AS
BEGIN
	IF EXISTS (SELECT 1 FROM Categorias WHERE NombreCategoria = @NombreCategoria)
	BEGIN
		SET @Mensaje = 'La categoria ya existe';
		RETURN;
	END
	
    INSERT INTO Categorias (NombreCategoria)
    VALUES (@NombreCategoria);
	
	SET @Mensaje = 'Categoria registrada exitosamente';
END;
GO

-- Procedimiento para actualizar una categoría existente
CREATE PROCEDURE ActualizarCategoria
    @CategoriaID INT,
    @NombreCategoria VARCHAR(50),
	@Mensaje NVARCHAR(50) OUTPUT --Parametro de salida
AS
BEGIN
	--Verificacion si otra categoria ya tiene el mismo nombre
	IF EXISTS (SELECT 1 FROM Categoria WHERE NombreCategoria = @NombreCategoria AND CategoriaID <> @CategoriaID)
	BEGIN
		SET @Mensaje = 'Ya hay una categoria con el mismo nombre'
		RETURN
	END
	
	--Actualizar categoria si no existe
    UPDATE Categorias
    SET NombreCategoria = @NombreCategoria
    WHERE CategoriaID = @CategoriaID;
	
	SET @Mensaje = 'Categoria Actualizada correctamente'
END;
GO

-- Procedimiento para eliminar una categoría
CREATE PROCEDURE EliminarCategoria
    @CategoriaID INT,
    @Mensaje NVARCHAR(50) OUTPUT -- Parámetro de salida
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Categorias WHERE CategoriaID = @CategoriaID)
    BEGIN
        SET @Mensaje = 'La categoría no existe'
        RETURN
    END

    DELETE FROM Categorias
    WHERE CategoriaID = @CategoriaID;
    
    SET @Mensaje = 'Categoría eliminada correctamente'
END;
GO

-- Procedimiento para seleccionar todas las categorías
CREATE PROCEDURE MostrarCategorias
AS
BEGIN
    SELECT * FROM Categorias;
END;
GO

-- Procedimiento para buscar una categoría específica
CREATE PROCEDURE BuscarCategoriaPorID
    @CategoriaID INT
AS
BEGIN
    SELECT * FROM Categorias
    WHERE CategoriaID = @CategoriaID;
END;
GO
--Procedimientos De La Table De Proveedor
CREATE PROCEDURE InsertarProveedor
    @NombreProveedor VARCHAR(50),
    @Telefono VARCHAR(15),
    @Mensaje NVARCHAR(50) OUTPUT  -- Parámetro de salida
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Proveedores WHERE NombreProveedor = @NombreProveedor OR Telefono = @Telefono)
    BEGIN
        SET @Mensaje = 'El proveedor ya existe con el mismo nombre o teléfono.';
        RETURN;
    END

    INSERT INTO Proveedores (NombreProveedor, Telefono)
    VALUES (@NombreProveedor, @Telefono);

    SET @Mensaje = 'Proveedor insertado correctamente.';
END;
GO
-- Procedimiento para actualizar un Proveedor existente
CREATE PROCEDURE ActualizarProveedor
    @ProveedorID INT,
    @NombreProveedor VARCHAR(50),
    @Telefono VARCHAR(15),
    @Mensaje NVARCHAR(100) OUTPUT  -- Parámetro de salida
AS
BEGIN
    -- Verificar si OTRO proveedor ya tiene el mismo nombre
    IF EXISTS (SELECT 1 FROM Proveedores 
               WHERE NombreProveedor = @NombreProveedor 
               AND ProveedorID <> @ProveedorID)  -- Excluir el proveedor actual
    BEGIN
        SET @Mensaje = 'Otro proveedor ya existe con el mismo nombre.';
        RETURN;
    END

    -- Verificar si OTRO proveedor ya tiene el mismo teléfono
    IF EXISTS (SELECT 1 FROM Proveedores 
               WHERE Telefono = @Telefono 
               AND ProveedorID <> @ProveedorID)  -- Excluir el proveedor actual
    BEGIN
        SET @Mensaje = 'Otro proveedor ya existe con el mismo teléfono.';
        RETURN;
    END

    -- Si no hay conflictos, actualizar el proveedor
    UPDATE Proveedores
    SET NombreProveedor = @NombreProveedor,
        Telefono = @Telefono
    WHERE ProveedorID = @ProveedorID;

    SET @Mensaje = 'Proveedor actualizado correctamente.';
END;
GO
-- Procedimiento para eliminar una Proveedor
CREATE PROCEDURE EliminarProveedor
    @ProveedorID INT,
    @Mensaje NVARCHAR(50) OUTPUT -- Parámetro de salida
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Proveedores WHERE ProveedorID = @ProveedorID)
    BEGIN
        SET @Mensaje = 'El proveedor no existe'
        RETURN
    END

    DELETE FROM Proveedores
    WHERE ProveedorID = @ProveedorID;
    
    SET @Mensaje = 'Proveedor eliminado correctamente'
END;
GO
-- Procedimiento para listar todos los proveedores
CREATE PROCEDURE MostrarProveedores
AS
BEGIN
    SELECT * FROM Proveedores;
END;
GO
-- Procedimiento para buscar un proveedor específico
CREATE PROCEDURE BuscarProveedoresPorID
    @ProveedorID INT
AS
BEGIN
    SELECT * FROM Proveedores
    WHERE ProveedorID = @ProveedorID;
END;
GO
--Procedimientos Para La Tabla De Clientes
CREATE PROCEDURE CrearCliente
    @UserName VARCHAR(25),
    @Password VARCHAR(13),
    @NombreCliente VARCHAR(50),
    @ApellidoCliente VARCHAR(50),
    @Correo VARCHAR(50),
    @Telefono VARCHAR(15),
    @DireccionCli VARCHAR(50),
    @RolID INT
AS
BEGIN
    INSERT INTO Clientes (UserName, Password, NombreCliente, ApellidoCliente, Correo, Telefono, DireccionCli, RolID)
    VALUES (@UserName, @Password, @NombreCliente, @ApellidoCliente, @Correo, @Telefono, @DireccionCli, @RolID);
END;
GO

-- Leer todos los clientes
CREATE PROCEDURE LeerClientes
AS
BEGIN
    SELECT * FROM Clientes;
END;
GO

-- Leer un cliente por ID
CREATE PROCEDURE LeerClientePorID
    @ClienteID INT
AS
BEGIN
    SELECT * FROM Clientes WHERE ClienteID = @ClienteID;
END;
GO

-- Actualizar un cliente
CREATE PROCEDURE ActualizarCliente
    @ClienteID INT,
    @UserName VARCHAR(25),
    @Password VARCHAR(13),
    @NombreCliente VARCHAR(50),
    @ApellidoCliente VARCHAR(50),
    @Correo VARCHAR(50),
    @Telefono VARCHAR(15),
    @DireccionCli VARCHAR(50),
    @RolID INT
AS
BEGIN
    UPDATE Clientes
    SET UserName = @UserName,
        Password = @Password,
        NombreCliente = @NombreCliente,
        ApellidoCliente = @ApellidoCliente,
        Correo = @Correo,
        Telefono = @Telefono,
        DireccionCli = @DireccionCli,
        RolID = @RolID
    WHERE ClienteID = @ClienteID;
END;
GO

-- Eliminar un cliente
CREATE PROCEDURE EliminarCliente
    @ClienteID INT
AS
BEGIN
    DELETE FROM Clientes WHERE ClienteID = @ClienteID;
END;
GO
--Validar UsarName
CREATE PROCEDURE ValidarUsername
    @UserName VARCHAR(25),
    @Existe BIT OUTPUT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Clientes WHERE UserName = @UserName)
        SET @Existe = 1
    ELSE
        SET @Existe = 0
END;
GO
--Validar insercion de Cliente
CREATE PROCEDURE ValidarInsercionCliente
    @NombreCliente VARCHAR(50),
    @ApellidoCliente VARCHAR(50),
    @Correo VARCHAR(50),
    @Telefono VARCHAR(15),
    @Existe BIT OUTPUT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM Clientes
        WHERE NombreCliente = @NombreCliente
        AND ApellidoCliente = @ApellidoCliente
        AND Correo = @Correo
        AND Telefono = @Telefono
    )
        SET @Existe = 1
    ELSE
        SET @Existe = 0
END;
GO
--Procedimientos Para La Tabla De Productos
CREATE PROCEDURE InsertarProducto
    @NombreProducto NVARCHAR(50),
    @Descripcion VARCHAR(200),
    @PrecioUnitario DECIMAL(10, 2),
    @Stock INT,
    @FechaIngreso DATE,
    @CategoriaID INT,
    @ProveedorID INT
AS
BEGIN
    INSERT INTO Productos (NombreProducto, Descripcion, PrecioUnitario, Stock, FechaIngreso, CategoriaID, ProveedorID)
    VALUES (@NombreProducto, @Descripcion, @PrecioUnitario, @Stock, @FechaIngreso, @CategoriaID, @ProveedorID);
END;
GO
--
CREATE PROCEDURE ModificarProducto
    @ProductoID INT,
    @NombreProducto NVARCHAR(50),
    @Descripcion VARCHAR(200),
    @Precio DECIMAL(10, 2),
    @Stock INT,
    @FechaIngreso DATE,
    @CategoriaID INT,
    @ProveedorID INT
AS
BEGIN
    UPDATE Productos
    SET
        NombreProducto = @NombreProducto,
        Descripcion = @Descripcion,
        PrecioUnitario = @Precio,
        Stock = @Stock,
        FechaIngreso = @FechaIngreso,
        CategoriaID = @CategoriaID,
        ProveedorID = @ProveedorID
    WHERE ProductoID = @ProductoID;
END;
GO
--
CREATE PROCEDURE EliminarProducto
    @ProductoID INT
AS
BEGIN
    DELETE FROM Productos
    WHERE ProductoID = @ProductoID;
END;
GO
--
CREATE PROCEDURE MostrarProductos
AS
BEGIN
    SELECT ProductoID, NombreProducto, Descripcion, PrecioUnitario, Stock, FechaIngreso, CategoriaID, ProveedorID
    FROM Productos;
END;
GO
--
CREATE PROCEDURE ValidarProductosActualizacion
    @ProductoID INT,
    @NombreProducto NVARCHAR(50),
    @Precio DECIMAL(10, 2)
AS
BEGIN
    DECLARE @TotalProductos INT;

    -- Contar los productos que coinciden con el nombre y precio, excluyendo el ProductoID actual
    SELECT @TotalProductos = COUNT(*)
    FROM Productos
    WHERE NombreProducto = @NombreProducto
    AND PrecioUnitario = @Precio
    AND ProductoID <> @ProductoID;

    -- Retornar el total de productos encontrados (mayor que 0 significa duplicado)
    SELECT @TotalProductos;
END;
GO
--
CREATE PROCEDURE ValidarProductosInsercion
    @NombreProducto NVARCHAR(50),
    @Precio DECIMAL(10, 2)
AS
BEGIN
    DECLARE @TotalProductos INT;

    -- Contar los productos que coinciden con el nombre y precio
    SELECT @TotalProductos = COUNT(*)
    FROM Productos
    WHERE NombreProducto = @NombreProducto
    AND PrecioUnitario = @Precio;

    -- Retornar el total de productos encontrados (mayor que 0 significa duplicado)
    SELECT @TotalProductos;
END;
GO
--Procedimiento Para Generar Los Diferentes reportes
CREATE PROCEDURE ListarRolesYColaboradores
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        r.NombreRol AS Rol, 
        c.Nombre + ' ' + c.Apellido AS Usuario, 
        c.Correo AS Correo
    FROM 
        Roles r
    INNER JOIN 
        Colaboradores c ON r.RolID = c.RolID;
END;
GO


CREATE PROCEDURE ObtenerProductos
AS
BEGIN
    SELECT NombreProducto, Stock, FechaIngreso, PrecioUnitario
    FROM Productos;
END;

GO
CREATE PROCEDURE ObtenerPedidosConProveedores
AS
BEGIN
    SELECT 
        p.PedidoID, 
        pr.NombreProveedor, 
        p.FechaPedido, 
        p.EstadoPedido, 
        p.TotalPedido
    FROM 
        Pedidos p
    INNER JOIN 
        Proveedores pr 
    ON 
        p.ProveedorID = pr.ProveedorID;
END;
GO
--Procedimientos Para La Tabla De Colaboradores
CREATE PROCEDURE CrearColaborador
    @ColabName VARCHAR(25),
    @PasswordColab VARCHAR(13),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Correo VARCHAR(50),
    @DireccionColab VARCHAR(50),
    @TelefonoColab VARCHAR(15),
    @RolID INT
AS
BEGIN
    -- Verificar si ya existe un colaborador con el mismo nombre de usuario o correo electrónico
    IF EXISTS (SELECT 1 FROM Colaboradores WHERE ColabName = @ColabName OR Correo = @Correo)
    BEGIN
        RAISERROR ('Ya existe un colaborador con el mismo nombre de usuario o correo electrónico.', 16, 1)
        RETURN
    END

    INSERT INTO Colaboradores (ColabName, PasswordColab, Nombre, Apellido, Correo, DireccionColab, TelefonoColab, RolID)
    VALUES (@ColabName, @PasswordColab, @Nombre, @Apellido, @Correo, @DireccionColab, @TelefonoColab, @RolID);
END;
GO

-- Actualizar un colaborador
CREATE PROCEDURE ActualizarColaborador
    @ColabID INT,
    @ColabName VARCHAR(25),
    @PasswordColab VARCHAR(13),
    @Nombre VARCHAR(50),
    @Apellido VARCHAR(50),
    @Correo VARCHAR(50),
    @DireccionColab VARCHAR(50),
    @TelefonoColab VARCHAR(15),
    @RolID INT
AS
BEGIN
    -- Verificar si el colaborador existe
    IF NOT EXISTS (SELECT 1 FROM Colaboradores WHERE ColabID = @ColabID)
    BEGIN
        RAISERROR ('El colaborador no existe.', 16, 1)
        RETURN
    END

    -- Verificar si ya existe otro colaborador con el mismo nombre de usuario o correo electrónico
    IF EXISTS (SELECT 1 FROM Colaboradores WHERE (ColabName = @ColabName OR Correo = @Correo) AND ColabID != @ColabID)
    BEGIN
        RAISERROR ('Ya existe otro colaborador con el mismo nombre de usuario o correo electrónico.', 16, 1)
        RETURN
    END

    UPDATE Colaboradores
    SET ColabName = @ColabName,
        PasswordColab = @PasswordColab,
        Nombre = @Nombre,
        Apellido = @Apellido,
        Correo = @Correo,
        DireccionColab = @DireccionColab,
        TelefonoColab = @TelefonoColab,
        RolID = @RolID
    WHERE ColabID = @ColabID;
END;
GO
-- Eliminar un colaborador
CREATE PROCEDURE EliminarColaborador
    @ColabID INT
AS
BEGIN
    -- Verificar si el colaborador existe
    IF NOT EXISTS (SELECT 1 FROM Colaboradores WHERE ColabID = @ColabID)
    BEGIN
        RAISERROR ('El colaborador no existe.', 16, 1)
        RETURN
    END

    DELETE FROM Colaboradores WHERE ColabID = @ColabID;
END;
GO
-- Leer todos los colaboradores
CREATE PROCEDURE LeerColaboradores
AS
BEGIN
    SELECT * FROM Colaboradores;
END;
GO
--Procedimientos Para La Tabla De Roles
-- Crear un nuevo rol
CREATE PROCEDURE CrearRol
    @NombreRol VARCHAR(50),
    @Mensaje NVARCHAR(MAX) OUTPUT
AS
BEGIN
    -- Verificar si ya existe un rol con el mismo nombre
    IF EXISTS (SELECT 1 FROM Roles WHERE NombreRol = @NombreRol)
    BEGIN
        SET @Mensaje = 'Ya existe un rol con el mismo nombre.'
        RETURN
    END

    INSERT INTO Roles (NombreRol)
    VALUES (@NombreRol);

    SET @Mensaje = 'Rol creado correctamente.'
END;
GO

-- Leer los roles
CREATE PROCEDURE LeerRoles
AS
BEGIN
    SELECT * FROM Roles;
END;
GO

-- Actualizar un rol
CREATE PROCEDURE ActualizarRol
    @RolID INT,
    @NombreRol VARCHAR(50),
    @Mensaje NVARCHAR(MAX) OUTPUT
AS
BEGIN
    -- Verificar si el rol existe
    IF NOT EXISTS (SELECT 1 FROM Roles WHERE RolID = @RolID)
    BEGIN
        SET @Mensaje = 'El rol no existe.'
        RETURN
    END

    -- Verificar si ya existe otro rol con el mismo nombre
    IF EXISTS (SELECT 1 FROM Roles WHERE NombreRol = @NombreRol AND RolID != @RolID)
    BEGIN
        SET @Mensaje = 'Ya existe otro rol con el mismo nombre.'
        RETURN
    END

    UPDATE Roles
    SET NombreRol = @NombreRol
    WHERE RolID = @RolID;

    SET @Mensaje = 'Rol actualizado correctamente.'
END;
GO
-- Eliminar un rol
CREATE PROCEDURE EliminarRol
    @RolID INT,
    @Mensaje NVARCHAR(MAX) OUTPUT
AS
BEGIN
    -- Verificar si el rol existe
    IF NOT EXISTS (SELECT 1 FROM Roles WHERE RolID = @RolID)
    BEGIN
        SET @Mensaje = 'El rol no existe.'
        RETURN
    END

    DELETE FROM Roles WHERE RolID = @RolID;

    SET @Mensaje = 'Rol eliminado correctamente.'
END;
GO
--Procedimientos de la tabla de Ventas
CREATE PROCEDURE InsertarVenta
    @FechaVenta DATE,
    @TotalVenta DECIMAL(10, 2),
    @ClienteID INT,
    @Mensaje NVARCHAR(50) OUTPUT
AS
BEGIN
    -- Verificar que la FechaVenta no sea futura
    IF @FechaVenta > GETDATE()
    BEGIN
        SET @Mensaje = 'La fecha de la venta no puede ser una fecha futura.'
        RETURN
    END

    -- Verificar que el TotalVenta sea mayor que 0
    IF @TotalVenta <= 0
    BEGIN
        SET @Mensaje = 'El total de la venta debe ser mayor que cero.'
        RETURN
    END

    -- Verificar que el ClienteID existe en la tabla Clientes
    IF NOT EXISTS (SELECT 1 FROM Clientes WHERE ClienteID = @ClienteID)
    BEGIN
        SET @Mensaje = 'El ClienteID no existe.'
        RETURN
    END

    -- Insertar una nueva venta en la tabla Ventas
    INSERT INTO Ventas (FechaVenta, TotalVenta, ClienteID)
    VALUES (@FechaVenta, @TotalVenta, @ClienteID);

    SET @Mensaje = 'Venta insertada correctamente.'
END;
GO
--
CREATE PROCEDURE ActualizarVenta
    @VentaID INT,
    @FechaVenta DATE,
    @TotalVenta DECIMAL(10, 2),
    @ClienteID INT,
    @Mensaje NVARCHAR(50) OUTPUT
AS
BEGIN
    -- Verificar que el VentaID existe en la tabla Ventas
    IF NOT EXISTS (SELECT 1 FROM Ventas WHERE VentaID = @VentaID)
    BEGIN
        SET @Mensaje = 'El VentaID no existe.'
        RETURN
    END

    -- Verificar que la FechaVenta no sea futura
    IF @FechaVenta > GETDATE()
    BEGIN
        SET @Mensaje = 'La fecha de la venta no puede ser una fecha futura.'
        RETURN
    END

    -- Verificar que el TotalVenta sea mayor que 0
    IF @TotalVenta <= 0
    BEGIN
        SET @Mensaje = 'El total de la venta debe ser mayor que cero.'
        RETURN
    END

    -- Verificar que el ClienteID existe en la tabla Clientes
    IF NOT EXISTS (SELECT 1 FROM Clientes WHERE ClienteID = @ClienteID)
    BEGIN
        SET @Mensaje = 'El ClienteID no existe.'
        RETURN
    END

    -- Actualizar la venta en la tabla Ventas
    UPDATE Ventas
    SET FechaVenta = @FechaVenta, TotalVenta = @TotalVenta, ClienteID = @ClienteID
    WHERE VentaID = @VentaID;

    SET @Mensaje = 'Venta actualizada correctamente.'
END;
GO
--
CREATE PROCEDURE EliminarVenta
    @VentaID INT,
    @Mensaje NVARCHAR(50) OUTPUT
AS
BEGIN
    -- Verificar que el VentaID existe en la tabla Ventas
    IF NOT EXISTS (SELECT 1 FROM Ventas WHERE VentaID = @VentaID)
    BEGIN
        SET @Mensaje = 'El VentaID no existe.'
        RETURN
    END

    -- Eliminar una venta por su ID
    DELETE FROM Ventas
    WHERE VentaID = @VentaID;

    SET @Mensaje = 'Venta eliminada correctamente.'
END;

GO
--
CREATE PROCEDURE MostrarVentas
AS
BEGIN
    -- Seleccionar todas las ventas
    SELECT *
    FROM Ventas;
END;