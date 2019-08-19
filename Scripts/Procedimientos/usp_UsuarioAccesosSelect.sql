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
