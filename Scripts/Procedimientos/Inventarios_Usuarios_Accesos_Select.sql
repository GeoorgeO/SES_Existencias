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
