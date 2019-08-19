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
