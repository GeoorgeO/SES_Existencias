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