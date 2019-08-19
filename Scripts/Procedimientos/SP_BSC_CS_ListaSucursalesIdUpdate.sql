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

