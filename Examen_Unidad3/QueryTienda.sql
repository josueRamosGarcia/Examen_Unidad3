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
    descripcion NVARCHAR(255),                   -- 3. Descripción del producto
    precio DECIMAL(10,2) NOT NULL,               -- 4. Precio
    stock INT NOT NULL,                          -- 5. Cantidad en inventario
    categoria NVARCHAR(50),                      -- 6. Categoría
    fecha_ingreso DATE DEFAULT GETDATE()         -- 7. Fecha de ingreso al sistema
);
GO

INSERT INTO productos (nombre, descripcion, precio, stock, categoria)
VALUES 
('Laptop HP 15', 'Laptop con procesador Intel i5 y 8GB RAM', 13500.00, 10, 'Tecnología'),
('Mouse Logitech M185', 'Mouse inalámbrico USB', 250.00, 50, 'Accesorios'),
('Teclado mecánico Redragon', 'Teclado con retroiluminación RGB', 890.00, 30, 'Accesorios'),
('Pantalla Samsung 24"', 'Monitor Full HD 24 pulgadas', 2800.00, 15, 'Tecnología'),
('Smartphone Xiaomi Redmi Note 12', 'Teléfono con cámara de 50MP', 5999.00, 20, 'Telefonía'),
('Audífonos JBL Tune 510BT', 'Audífonos inalámbricos Bluetooth', 1200.00, 25, 'Audio'),
('Disco Duro Externo 1TB', 'Almacenamiento portátil USB 3.0', 1100.00, 18, 'Almacenamiento'),
('Impresora Epson L3250', 'Impresora multifuncional con sistema de tinta continua', 4500.00, 12, 'Oficina'),
('Cámara Canon EOS Rebel T7', 'Cámara réflex digital para principiantes', 13500.00, 8, 'Fotografía'),
('Router TP-Link AC1200', 'Router inalámbrico doble banda', 890.00, 40, 'Redes'),
('Memoria USB 64GB', 'Unidad flash USB 3.0', 150.00, 70, 'Almacenamiento'),
('Tablet Lenovo M10', 'Tablet Android de 10 pulgadas', 3499.00, 14, 'Tecnología');
GO
