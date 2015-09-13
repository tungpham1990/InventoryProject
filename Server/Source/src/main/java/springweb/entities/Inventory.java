package springweb.entities;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.IdClass;

@Entity
@IdClass(InventoryId.class)
public class Inventory  implements Serializable{
	@Id
	@Column(name="item_id")
	private Long itemId;
	
	@Id
	@Column(name="warehouse_id")
	private Long warehouseId;
	
	@Column(name="receipted_quantity")
	private Long receiptedQuantity;
	
	@Column(name="issued_quantity")
	private Long issuedQuantity;
	
	@Column(name="remain_quantity")
	private Long remainQuantity;

	public Long getItemId() {
		return itemId;
	}

	public void setItemId(Long itemId) {
		this.itemId = itemId;
	}

	public Long getWarehouseId() {
		return warehouseId;
	}

	public void setWarehouseId(Long warehouseId) {
		this.warehouseId = warehouseId;
	}

	public Long getReceiptedQuantity() {
		return receiptedQuantity;
	}

	public void setReceiptedQuantity(Long receiptedQuantity) {
		this.receiptedQuantity = receiptedQuantity;
	}

	public Long getIssuedQuantity() {
		return issuedQuantity;
	}

	public void setIssuedQuantity(Long issuedQuantity) {
		this.issuedQuantity = issuedQuantity;
	}

	public Long getRemainQuantity() {
		return remainQuantity;
	}

	public void setRemainQuantity(Long remainQuantity) {
		this.remainQuantity = remainQuantity;
	}
}


class InventoryId implements Serializable{
	Long itemId;
	Long warehouseId;
}
