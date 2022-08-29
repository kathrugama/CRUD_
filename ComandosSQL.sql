
---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR 
create proc MostrarProductos
as
select *from Detalles_Computadora
go
--------------------------INSERTAR 
create proc InsetarProductos
@Codigo int,
@Tipo_de_Computadora varchar(50),
@Procesador nvarchar(50),
@Memoria_RAM nvarchar(50),
@Tipo_de_disco_duro nvarchar(50),
@Almacenamiento nvarchar(50)
as
insert into Detalles_Computadora values (@Codigo, @Tipo_de_Computadora, @Procesador, @Memoria_RAM, @Tipo_de_disco_duro, @Almacenamiento)
go
------------------------ELIMINAR
create proc EliminarProducto
@Codigo int
as
delete from Detalles_Computadora where Codigo = @Codigo
go
------------------EDITAR
create proc EditarProductos
@Codigo int,
@Tipo_de_Computadora varchar(50),
@Procesador nvarchar(50),
@Memoria_RAM nvarchar(50),
@Tipo_de_disco_duro nvarchar(50),
@Almacenamiento nvarchar(50)
as
update Detalles_Computadora set Tipo_de_Computadora = @Tipo_de_Computadora, Procesador = @Procesador, 
Memoria_RAM = @Memoria_RAM, Tipo_de_disco_duro = @Tipo_de_disco_duro, Almacenamiento = @Almacenamiento where Codigo=@Codigo
go
