--Procediminetos Para La Operación De Venta
CREATE PROCEDURE InsertarFactura
    @Folio NVARCHAR(50),
    @NumeroFactura INT,
    @FechaFactura DATETIME,
    @Usuario INT,
    @TotalFactura DECIMAL(18, 2),
    @MetodoPago NVARCHAR(50),
    @FacturaID INT OUTPUT  -- Parámetro de salida para retornar el FacturaID
AS
BEGIN
    -- Inserta la factura en la tabla FACTURAS
    INSERT INTO FACTURAS (Folio, NumeroFactura, Fecha, ClienteID, Total, MetodoPago)
    VALUES (@Folio, @NumeroFactura, @FechaFactura, @Usuario, @TotalFactura, @MetodoPago)

    -- Obtiene el último ID insertado (FacturaID) y asignarlo al parámetro de salida
    SET @FacturaID = SCOPE_IDENTITY();  -- Esto retorna el último ID insertado
END
GO
--
CREATE PROCEDURE MostrarProductos2
AS
BEGIN
    SET NOCOUNT ON;

    SELECT ProductoId, NombreProducto,PrecioUnitario
    FROM PRODUCTOS
END;
GO
--
CREATE PROCEDURE ObtenerPrecioProducto
    @ProductoID INT
AS
BEGIN
    -- Selecciona el precio del producto correspondiente al ProductoID
    SELECT PrecioUnitario
    FROM Productos
    WHERE ProductoID = @ProductoID;
END;
GO
--
CREATE PROCEDURE ObtenerIDdecliente
    @UserName NVARCHAR(100)
AS
BEGIN
    -- Buscar el ClienteID de la tabla Clientes utilizando el UserName
    SELECT ClienteID
    FROM Clientes
    WHERE UserName = @UserName
END
GO
--
CREATE PROCEDURE InsertarDetalleFactura
    @FacturaID INT,
    @ProductoID INT,
    @Cantidad INT,
    @PrecioUnitario decimal(10,2),
	@subtotal decimal(10,2)
AS
BEGIN

    SET NOCOUNT ON;
    INSERT INTO DetalleFactura (FacturaID, ProductoID, Cantidad, PrecioUnitario,Subtotal)
    VALUES (@FacturaID, @ProductoID, @Cantidad, @PrecioUnitario, @subtotal);
END
GO
--
CREATE PROCEDURE ActualizarStock
    @ProductoId INT,
    @CantidadVendida INT,
    @Mensaje NVARCHAR(100) OUTPUT
AS
BEGIN
    DECLARE @StockActual INT

    -- Obtener el stock actual del producto
    SELECT @StockActual = Stock FROM Productos WHERE ProductoId = @ProductoId

    -- Verificar si el stock es suficiente
    IF @StockActual < @CantidadVendida
    BEGIN
        -- Si no hay suficiente stock, asignar un mensaje de error
        SET @Mensaje = 'Stock agotado'
    END
    ELSE
    BEGIN
        -- Restar la cantidad vendida del stock
        UPDATE Productos
        SET Stock = Stock - @CantidadVendida
        WHERE ProductoId = @ProductoId
        
        -- Asignar mensaje de éxito
        SET @Mensaje = 'Stock actualizado'
    END
END
GO
--
CREATE PROCEDURE Mostrardetallefactura
AS
BEGIN
    SELECT FacturaID,Folio,NumeroFactura,Fecha,Total,MetodoPago
    FROM Facturas;
END;
GO
--
CREATE PROCEDURE Obtenerdatosdecliente
    @UserName NVARCHAR(100)
AS
BEGIN
    -- Buscar el ClienteID de la tabla Clientes utilizando el UserName
    SELECT NombreCliente,ApellidoCliente,Correo,Telefono,DireccionCli
    FROM Clientes
    WHERE UserName = @UserName
END
GO
--
CREATE PROCEDURE MostrarFacturaDetalle
    @FacturaId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT P.NombreProducto AS Producto, DF.PrecioUnitario, DF.Cantidad, DF.Subtotal
    FROM DetalleFactura DF
    INNER JOIN Productos P ON DF.ProductoId = P.ProductoId
    WHERE DF.FacturaId = @FacturaId;
END;
GO
CREATE PROCEDURE ObtenerClienteID
    @UserName NVARCHAR(100),
    @ClienteID INT OUTPUT
AS
BEGIN
    -- Buscar el ClienteID de la tabla Clientes utilizando el UserName
    SELECT @ClienteID = ClienteID
    FROM Clientes
    WHERE UserName = @UserName
END
GO