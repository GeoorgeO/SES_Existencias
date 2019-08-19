
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


