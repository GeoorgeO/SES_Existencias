
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

