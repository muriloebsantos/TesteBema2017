SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbPedidoItem](
	[item_id] [int] IDENTITY(1,1) NOT NULL,
	[ped_numero] [int] NOT NULL,
	[pro_codigo] [uniqueidentifier] NOT NULL,
	[item_quantidade] [decimal](5, 2) NOT NULL,
	[item_valor] [decimal](18, 2) NOT NULL,
	[item_total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.tbPedidoItem] PRIMARY KEY CLUSTERED 
(
	[item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbPedidoItem]  WITH CHECK ADD  CONSTRAINT [FK_dbo.tbPedidoItem_dbo.tbPedido_ped_numero] FOREIGN KEY([ped_numero])
REFERENCES [dbo].[tbPedido] ([ped_numero])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[tbPedidoItem] CHECK CONSTRAINT [FK_dbo.tbPedidoItem_dbo.tbPedido_ped_numero]
GO


