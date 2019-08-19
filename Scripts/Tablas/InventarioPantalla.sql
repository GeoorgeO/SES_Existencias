

/****** Object:  Table [dbo].[InventarioPantalla]    Script Date: 16/08/2019 05:02:43 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

IF OBJECT_ID('InventarioPantalla') IS NOT NULL
	begin
		select 0
	end
ELSE
	begin

CREATE TABLE [dbo].[InventarioPantalla](
	[InventarioPantallaId] [decimal](11, 0) NOT NULL,
	[InventarioPantallaNombre] [varchar](200) NOT NULL,
 CONSTRAINT [PK_InventarioPantalla_1] PRIMARY KEY CLUSTERED 
(
	[InventarioPantallaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

end

GO

SET ANSI_PADDING OFF
GO


