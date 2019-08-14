USE [SES_AlmacenV4]
GO

/****** Object:  StoredProcedure [dbo].[Inventarios_Config_SucursalesSelect]    Script Date: 13/08/2019 12:11:24 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
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

