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
