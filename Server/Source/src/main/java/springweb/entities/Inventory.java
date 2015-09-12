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
	long itemId;
	
	@Id
	@Column(name="warehouse_id")
	long warehouseId;
	
	@Column(name="receipted_quantity")
	long receiptedQuantity;
	
	@Column(name="issued_quantity")
	long issuedQuantity;
	
	@Column(name="remain_quantity")
	long remainQuantity;

	public long getItemId() {
		return itemId;
	}

	public void setItemId(long itemId) {
		this.itemId = itemId;
	}

	public long getWarehouseId() {
		return warehouseId;
	}

	public void setWarehouseId(long warehouseId) {
		this.warehouseId = warehouseId;
	}

	public long getReceiptedQuantity() {
		return receiptedQuantity;
	}

	public void setReceiptedQuantity(long receiptedQuantity) {
		this.receiptedQuantity = receiptedQuantity;
	}

	public long getIssuedQuantity() {
		return issuedQuantity;
	}

	public void setIssuedQuantity(long issuedQuantity) {
		this.issuedQuantity = issuedQuantity;
	}

	public long getRemainQuantity() {
		return remainQuantity;
	}

	public void setRemainQuantity(long remainQuantity) {
		this.remainQuantity = remainQuantity;
	}
}


class InventoryId implements Serializable{
	long itemId;
	long warehouseId;
}
