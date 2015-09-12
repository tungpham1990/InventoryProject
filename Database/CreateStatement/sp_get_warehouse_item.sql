USE [Inventory]
GO

/****** Object:  StoredProcedure [dbo].[sp_get_warehouse_item]    Script Date: 9/12/2015 4:43:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_get_warehouse_item](
	@warehouse_id INT = NULL
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT DISTINCT I.*
    FROM    transaction_master TS ( NOLOCK )
            INNER JOIN transaction_detail TSD ( NOLOCK ) ON TS.transaction_master_id = TSD.transaction_master_id
            INNER JOIN warehouse W ( NOLOCK ) ON TS.received_warehouse_id = W.warehouse_id
			INNER JOIN item I (NOLOCK) ON TSD.item_id = I.item_id
	WHERE (@warehouse_id IS NULL OR TS.received_warehouse_id = @warehouse_id)

END

GO

