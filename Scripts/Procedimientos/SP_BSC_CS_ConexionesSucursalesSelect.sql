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
