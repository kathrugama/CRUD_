USE [Computadora]
GO

/****** Object:  Table [dbo].[Detalles_Computadora]    Script Date: 25/8/2022 14:06:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Detalles_Computadora](
	[Codigo] [int] NOT NULL,
	[Tipo_de_Computadora] [varchar](50) NULL,
	[Procesador] [nvarchar](50) NULL,
	[Memoria_RAM] [nvarchar](50) NULL,
	[Tipo_de_disco_duro] [nvarchar](50) NULL,
	[Almacenamiento] [nvarchar](50) NULL,
 CONSTRAINT [PK_Detalles_Computadora] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

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

------------------BUSCAR
create proc BuscarProductos
@Codigo int
as
select *from Detalles_Computadora where Codigo = @Codigo
go