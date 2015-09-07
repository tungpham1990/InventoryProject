package springweb.entities;

public class Inventory {
	String itemCode;
	String warehouseId;
	int quantityRemain;
	public String getItemCode() {
		return itemCode;
	}
	public void setItemCode(String itemCode) {
		this.itemCode = itemCode;
	}
	public String getWarehouseId() {
		return warehouseId;
	}
	public void setWarehouseId(String warehouseId) {
		this.warehouseId = warehouseId;
	}
	public int getQuantityRemain() {
		return quantityRemain;
	}
	public void setQuantityRemain(int quantityRemain) {
		this.quantityRemain = quantityRemain;
	}
	public int getQuantityDelivered() {
		return quantityDelivered;
	}
	public void setQuantityDelivered(int quantityDelivered) {
		this.quantityDelivered = quantityDelivered;
	}
	public int getQuantityReceived() {
		return quantityReceived;
	}
	public void setQuantityReceived(int quantityReceived) {
		this.quantityReceived = quantityReceived;
	}
	int quantityDelivered;
	int quantityReceived;
}
