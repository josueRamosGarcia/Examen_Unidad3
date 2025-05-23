-- Crear la base de datos
CREATE DATABASE tienda;
GO

-- Usar la base de datos
USE tienda;
GO

-- Crear la tabla productos con 7 atributos
CREATE TABLE productos (
    id_producto INT PRIMARY KEY IDENTITY(1,1),    -- 1. ID autoincremental
    nombre NVARCHAR(100) NOT NULL,               -- 2. Nombre del producto
    descripcion NVARCHAR(255),                   -- 3. Descripci�n del producto
    precio DECIMAL(10,2) NOT NULL,               -- 4. Precio
    stock INT NOT NULL,                          -- 5. Cantidad en inventario
    categoria NVARCHAR(50),                      -- 6. Categor�a
    fecha_ingreso DATE DEFAULT GETDATE()         -- 7. Fecha de ingreso al sistema
);
GO

INSERT INTO productos (nombre, descripcion, precio, stock, categoria)
VALUES 
('Laptop HP 15', 'Laptop con procesador Intel i5 y 8GB RAM', 13500.00, 10, 'Tecnolog�a'),
('Mouse Logitech M185', 'Mouse inal�mbrico USB', 250.00, 50, 'Accesorios'),
('Teclado mec�nico Redragon', 'Teclado con retroiluminaci�n RGB', 890.00, 30, 'Accesorios'),
('Pantalla Samsung 24"', 'Monitor Full HD 24 pulgadas', 2800.00, 15, 'Tecnolog�a'),
('Smartphone Xiaomi Redmi Note 12', 'Tel�fono con c�mara de 50MP', 5999.00, 20, 'Telefon�a'),
('Aud�fonos JBL Tune 510BT', 'Aud�fonos inal�mbricos Bluetooth', 1200.00, 25, 'Audio'),
('Disco Duro Externo 1TB', 'Almacenamiento port�til USB 3.0', 1100.00, 18, 'Almacenamiento'),
('Impresora Epson L3250', 'Impresora multifuncional con sistema de tinta continua', 4500.00, 12, 'Oficina'),
('C�mara Canon EOS Rebel T7', 'C�mara r�flex digital para principiantes', 13500.00, 8, 'Fotograf�a'),
('Router TP-Link AC1200', 'Router inal�mbrico doble banda', 890.00, 40, 'Redes'),
('Memoria USB 64GB', 'Unidad flash USB 3.0', 150.00, 70, 'Almacenamiento'),
('Tablet Lenovo M10', 'Tablet Android de 10 pulgadas', 3499.00, 14, 'Tecnolog�a');
GO
