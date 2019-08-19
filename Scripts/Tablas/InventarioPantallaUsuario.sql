
/****** Object:  Table [dbo].[InventarioPantallaUsuario]    Script Date: 16/08/2019 05:07:22 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID('InventarioPantallaUsuario') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin

CREATE TABLE [dbo].[InventarioPantallaUsuario](
	[UsuariosId] [decimal](11, 0) NOT NULL,
	[InventarioPantallaId] [decimal](11, 0) NOT NULL,
 CONSTRAINT [PK_InventarioPantallaUsuario] PRIMARY KEY CLUSTERED 
(
	[UsuariosId] ASC,
	[InventarioPantallaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

end

GO

ALTER TABLE [dbo].[InventarioPantallaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_InventarioPantallaUsuario_InventarioPantalla] FOREIGN KEY([InventarioPantallaId])
REFERENCES [dbo].[InventarioPantalla] ([InventarioPantallaId])
GO

ALTER TABLE [dbo].[InventarioPantallaUsuario] CHECK CONSTRAINT [FK_InventarioPantallaUsuario_InventarioPantalla]
GO

ALTER TABLE [dbo].[InventarioPantallaUsuario]  WITH CHECK ADD  CONSTRAINT [FK_InventarioPantallaUsuarios_Usuarios] FOREIGN KEY([UsuariosId])
REFERENCES [dbo].[Usuarios] ([UsuariosId])
GO

ALTER TABLE [dbo].[InventarioPantallaUsuario] CHECK CONSTRAINT [FK_InventarioPantallaUsuarios_Usuarios]
GO


