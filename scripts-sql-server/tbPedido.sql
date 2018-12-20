SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbPedido](
	[ped_numero] [int] IDENTITY(1,1) NOT NULL,
	[ped_dataEntrega] [date] NOT NULL,
	[cli_codigo] [uniqueidentifier] NOT NULL,
	[ped_valorTotal] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.tbPedido] PRIMARY KEY CLUSTERED 
(
	[ped_numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


