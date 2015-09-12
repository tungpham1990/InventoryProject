USE [Inventory]
GO

/****** Object:  StoredProcedure [dbo].[sp_calculate_inventory]    Script Date: 9/12/2015 10:20:47 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_calculate_inventory](
	-- Add the parameters for the stored procedure here
	@item_id int = NULL, 
	@warehouse_id INT = NULL
	)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT  
		ep.item_id,
		ep.warehouse_id,
		receipted_quantity = ISNULL(ep.receipted_quantity,0),
		issued_quantity = ISNULL(ep.issued_quantity,0),
		remain_quantity = ISNULL(ep.receipted_quantity, 0.000)
						  - ISNULL(ep.issued_quantity, 0.000) 
    FROM  (
		SELECT  ep1.item_id ,
                ep1.warehouse_id ,
                receipted_quantity = SUM(ep1.receipted_quantity) ,
                issued_quantity = SUM(ep1.issued_quantity)
        FROM   (
				--Lay thong tin nhap  (Receipt) 
                SELECT
                        TSD.item_id ,
                        W.warehouse_id ,
                        receipted_quantity = SUM(TSD.quantity) ,
						issued_quantity = 0
                FROM    transaction_master TS ( NOLOCK )
                        INNER JOIN transaction_detail TSD ( NOLOCK ) ON TS.transaction_master_id = TSD.transaction_master_id
                        INNER JOIN warehouse W ( NOLOCK ) ON TS.received_warehouse_id = W.warehouse_id
				WHERE (@warehouse_id IS NULL OR TS.received_warehouse_id = @warehouse_id)
					AND (@item_id IS NULL OR TSD.item_id = @item_id)
                GROUP BY TSD.item_id ,
                        W.warehouse_id

				UNION ALL
				----Lay thong tin xuat  (Issue)
				SELECT    
						TSD.item_id ,
						W.warehouse_id ,
						receipted_quantity = 0 ,
						issued_quantity = SUM(TSD.quantity) 
				FROM    transaction_master TS ( NOLOCK )
						INNER JOIN transaction_detail TSD ( NOLOCK ) ON TS.transaction_master_id = TSD.transaction_master_id
						INNER JOIN warehouse W ( NOLOCK ) ON TS.delivered_warehosuse_id = W.warehouse_id     
				WHERE (@warehouse_id IS NULL OR TS.delivered_warehosuse_id = @warehouse_id)  
					AND (@item_id IS NULL OR TSD.item_id = @item_id)         
				GROUP BY TSD.item_id ,
						W.warehouse_id
			) ep1
        GROUP BY  ep1.item_id,
                ep1.warehouse_id
    ) ep

END

GO

