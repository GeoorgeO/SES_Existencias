

/****** Object:  Table [dbo].[InventarioPantalla]    Script Date: 16/08/2019 05:02:43 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

IF OBJECT_ID('InventarioPantalla') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin

CREATE TABLE [dbo].[InventarioPantalla](
	[InventarioPantallaId] [decimal](11, 0) NOT NULL,
	[InventarioPantallaNombre] [varchar](200) NOT NULL,
 CONSTRAINT [PK_InventarioPantalla_1] PRIMARY KEY CLUSTERED 
(
	[InventarioPantallaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

end

GO

SET ANSI_PADDING OFF
GO



GO

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



GO
if (select count(InventarioPantallaId) from InventarioPantalla where InventarioPantallaId=8 and rtrim(ltrim(InventarioPantallaNombre))='Conf de conexion')=0
begin
	INSERT [dbo].[InventarioPantalla] ([InventarioPantallaId], [InventarioPantallaNombre]) VALUES (CAST(8 AS Decimal(11, 0)), N'Conf de conexion')
end
if (select count(InventarioPantallaId) from InventarioPantalla where InventarioPantallaId=9 and rtrim(ltrim(InventarioPantallaNombre))='Conf de conexiones Remotas')=0
begin
	INSERT [dbo].[InventarioPantalla] ([InventarioPantallaId], [InventarioPantallaNombre]) VALUES (CAST(9 AS Decimal(11, 0)), N'Conf de conexiones Remotas')
end
if (select count(UsuariosId) from InventarioPantallaUsuario where UsuariosId=2 and InventarioPantallaId=8)=0
begin
	INSERT [dbo].[InventarioPantallaUsuario] ([UsuariosId], [InventarioPantallaId]) VALUES (CAST(2 AS Decimal(11, 0)), CAST(8 AS Decimal(11, 0)))
end
if (select count(UsuariosId) from InventarioPantallaUsuario where UsuariosId=2 and InventarioPantallaId=9)=0
begin
	INSERT [dbo].[InventarioPantallaUsuario] ([UsuariosId], [InventarioPantallaId]) VALUES (CAST(2 AS Decimal(11, 0)), CAST(9 AS Decimal(11, 0)))
end

GO
delete from ConexionesRemotas


INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(1 AS Decimal(11, 0)), N'ukcwczzTJyrwJv78Q0RXPhhnMj5qXLWZ', N'3a0vCA//KDIScDMytkPBmw==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(2 AS Decimal(11, 0)), N'FLe0oTkIVSKbp7RG81KsLqIdTjHuFafo', N'EDiDL/P0JcLeIhCtpjD1PA==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(3 AS Decimal(11, 0)), N'QDrHhuRqw+t3/HTtyQD9F5FKBAJ97aRK', N'muZ3dg0N7vioTZ4/u6Wpnjmcr3YLlzp7', N'lMxfS1DsDwY=', N'T3KgVf+3ye2xL7e0OX+A9g==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(4 AS Decimal(11, 0)), N'Qhc482+EBazQ9Ts9VfLXNk2A+gQSzJ2I', N'q7D9LQ2H/a0KlMcS9dskOA==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(6 AS Decimal(11, 0)), N'9cig4QPqdsE6wZcVcCbLh2jJSH3Eimyf', N'JepY6+kYkhFtEUdH4QmaPg==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(7 AS Decimal(11, 0)), N'7k099zBpyM02WEUnVTaTBkcbnKy9qTPv', N'MpgrPxlGu4WiAdcZ5Di0tzmcr3YLlzp7', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(8 AS Decimal(11, 0)), N'0exV1vO5yelTyu30cGwMvQ==', N'mWyU0/eecfmpUN8aQHsl7Q==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(9 AS Decimal(11, 0)), N'lx9d6HLOB2u2xtW66sMyDw==', N'YyRyxSWQhbCaXzGABgNGrA==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(10 AS Decimal(11, 0)), N'4pypFo7SA76jJLAozLTYbiX27pbx/0id', N'Y87G8x3LaVg2qgQUQxMa4A==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(11 AS Decimal(11, 0)), N'EEA9d2TSedlDjLxl9o/aY0R6Nh7P/hqx', N'/eEe9GN8wJAqoj8AgSfQsA==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(12 AS Decimal(11, 0)), N'UlWOH9debFVgv+gpjCN78tFaRF1OWfm1', N'KLZjoM6wlV/9VhQnnOe9gA==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(14 AS Decimal(11, 0)), N'9JsiLCUj8/YzEi6+ireiyzdeut5uymbW', N'WEs2jlH6Mei5eX80WDot8A==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(15 AS Decimal(11, 0)), N'GkBdxMxcB8wYZHZOf+R6zN/GeWXY73BG', N'TqI0HQyBfGlx0t+ki/sejw==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO
INSERT [dbo].[ConexionesRemotas] ([SucursalesId], [ServerID], [DataBaseID], [UserID], [PassID]) VALUES (CAST(16 AS Decimal(11, 0)), N'8g9qTYlWqHpQF42u3GGNEObUwnxSO6HC', N'0KsjhdSeC6egwrkat9DMeA==', N'lMxfS1DsDwY=', N'P1AFQFoid+8xakE9uvRhfA==')
GO

GO

if (select count(SucursalesNombre) from Sucursales where RTRIM(LTRIM(SucursalesNombre))='TANCITARO')=0
begin
INSERT INTO [dbo].[Sucursales]
           ([SucursalesNombre]
           ,[SucursalesFecha]
           ,[SucursalesActivo]
           ,[SucursalesCalle]
           ,[SucursalesNInterior]
           ,[SucursalesnNExterior]
           ,[SucursalesColonia]
           ,[LocalidadId]
           ,[SucursalesCiudad])
     VALUES
           ('TANCITARO                                                   '
           ,GETDATE()
           ,'A'
           ,'CONOCIDO                                                                                            '
           ,'                                        '
           ,'S/N                                     '
           ,'CONOCIDO                                                                                            '
           ,'59372'
           ,NULL)
END 



GO

/****** Object:  StoredProcedure [dbo].[Inventarios_Config_CajasSelect]    Script Date: 13/08/2019 12:11:49 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'Inventarios_Config_CajasSelect')
DROP PROCEDURE Inventarios_Config_CajasSelect
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Inventarios_Config_CajasSelect]
	@SucursalesId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        CajaId, CajaDescripcion
	FROM            Caja
	where SucursalesId=@SucursalesId
END

GO


GO

/****** Object:  StoredProcedure [dbo].[Inventarios_Config_SucursalesSelect]    Script Date: 13/08/2019 12:11:24 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'Inventarios_Config_SucursalesSelect')
DROP PROCEDURE Inventarios_Config_SucursalesSelect
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Inventarios_Config_SucursalesSelect]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        SucursalesId, rtrim(SucursalesNombre) as SucursalesNombre
	FROM            Sucursales
	order by SucursalesId
END


GO


GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'Inventarios_Usuarios_Accesos_Select')
DROP PROCEDURE Inventarios_Usuarios_Accesos_Select
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Inventarios_Usuarios_Accesos_Select
	-- Add the parameters for the stored procedure here
	@UsuariosLogin varchar(60),
	@InventarioPantallaId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        Usuarios.UsuariosLogin, InventarioPantallaUsuario.InventarioPantallaId
	FROM            InventarioPantallaUsuario INNER JOIN
							 Usuarios ON InventarioPantallaUsuario.UsuariosId = Usuarios.UsuariosId
	WHERE        (Usuarios.UsuariosLogin = @UsuariosLogin) AND (InventarioPantallaUsuario.InventarioPantallaId = @InventarioPantallaId)
END
GO

GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_BSC_CS_ConexionesSucursalesSelect')
DROP PROCEDURE SP_BSC_CS_ConexionesSucursalesSelect
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_BSC_CS_ConexionesSucursalesSelect
	-- Add the parameters for the stored procedure here
	@exepcion numeric(4,0)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select cr.SucursalesId,
	suc.SucursalesNombre,
	cr.ServerID,
	cr.DataBaseID,
	cr.UserID,
	cr.PassID,
	0 as existencia,
	'                   ' as Estatus,
	'                                                                                                                                                                     ' as Observaciones
  from ConexionesRemotas as cr
  inner join Sucursales as suc on cr.SucursalesId=suc.SucursalesId
  where suc.SucursalesId>0 and suc.SucursalesId<>@exepcion
END
GO

GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_BSC_CS_ListaSucursales')
DROP PROCEDURE SP_BSC_CS_ListaSucursales
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_BSC_CS_ListaSucursales 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        SucursalesId,rtrim( suc.SucursalesNombre) as SucursalesNombre
    FROM          Sucursales as suc order by 1
END
GO

GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_BSC_CS_ListaSucursalesId')
DROP PROCEDURE SP_BSC_CS_ListaSucursalesId
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_BSC_CS_ListaSucursalesId 
	-- Add the parameters for the stored procedure here
	@SucursalesId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        ConexionesSucursales.SucursalesId, RTRIM(Sucursales.SucursalesNombre) AS SucursalesNombre, ConexionesSucursales.ServerID, ConexionesSucursales.DataBaseID, ConexionesSucursales.UserID, 
                         ConexionesSucursales.PassID
FROM            ConexionesSucursales INNER JOIN
                         Sucursales ON ConexionesSucursales.SucursalesId = Sucursales.SucursalesId
WHERE        (ConexionesSucursales.SucursalesId = @SucursalesId)
END
GO

GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_BSC_CS_ListaSucursalesIdUpdate')
DROP PROCEDURE SP_BSC_CS_ListaSucursalesIdUpdate
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_BSC_CS_ListaSucursalesIdUpdate 
	-- Add the parameters for the stored procedure here
	@SucursalesId	decimal(11, 0),
	@ServerID	varchar(MAX),
	@DataBaseID	varchar(MAX),
	@UserID	varchar(MAX),
	@PassID	varchar(MAX)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	declare @Existe int
	
	
	select @Existe = count(SucursalesId) from ConexionesRemotas a where (a.SucursalesId=@SucursalesId )
	if @Existe>0
			UPDATE       ConexionesRemotas
			SET                ServerID = @ServerID, DataBaseID = @DataBaseID, UserID = @UserID, PassID = @PassID
			WHERE        (SucursalesId = @SucursalesId)
		else
			INSERT ConexionesRemotas (SucursalesId, ServerID, DataBaseID, UserID, PassID) values ( @SucursalesId,@ServerID,@DataBaseID,@UserID,@PassID)
		
		
END


GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_BSC_CS_selectBusqArticulo')
DROP PROCEDURE SP_BSC_CS_selectBusqArticulo
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_BSC_CS_selectBusqArticulo
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select rtrim(ArticuloCodigo) as ArticuloCodigo,
		rtrim(ArticuloDescripcion) as ArticuloDescripcion,
		ArticuloCantidad,
		rtrim(fam.FamiliaNombre) as FamiliaNombre
	from Articulo as art 
	inner join Familia as fam on fam.FamiliaId=art.FamiliaId 
	where art.ArticuloActivo='A'
END
GO

GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'SP_BSC_CS_selectBusqArticuloId')
DROP PROCEDURE SP_BSC_CS_selectBusqArticuloId
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_BSC_CS_selectBusqArticuloId
	-- Add the parameters for the stored procedure here
	@Codigo varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select rtrim(ArticuloCodigo) as ArticuloCodigo,
		rtrim(ArticuloDescripcion) as ArticuloDescripcion,
		ArticuloCantidad,
		rtrim(fam.FamiliaNombre) as FamiliaNombre
	from Articulo as art 
	inner join Familia as fam on fam.FamiliaId=art.FamiliaId 
	where art.ArticuloActivo='A'
	and ArticuloCodigo=@Codigo
END
GO

GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF  EXISTS (SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND NAME = 'usp_UsuarioAccesosSelect')
DROP PROCEDURE usp_UsuarioAccesosSelect
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE usp_UsuarioAccesosSelect
	-- Add the parameters for the stored procedure here
	@c_codigo_usu varchar(20),
	@v_passwo_usu varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT        Usuarios.UsuariosId, RTRIM(Usuarios.UsuariosNombre) AS UsuariosNombre, RTRIM(Usuarios.UsuariosLogin) AS UsuariosLogin, RTRIM(Usuarios.UsuariosPassword) AS UsuariosPassword,UsuariosActivo, 
                         RTRIM(Roles.RolesNombre) AS RolesNombre
FROM            Usuarios INNER JOIN
                         Roles ON Usuarios.RolesId = Roles.RolesId
						 where UsuariosLogin=@c_codigo_usu and UsuariosPassword=@v_passwo_usu
END
GO

GO
