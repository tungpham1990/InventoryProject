package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Timestamp;
import java.util.List;


/**
 * The persistent class for the warehouse database table.
 * 
 */
@Entity
@Table(name="warehouse")
@NamedQuery(name="Warehouse.findAll", query="SELECT w FROM Warehouse w")
public class Warehouse extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="warehouse_id")
	private long warehouseId;

	private Object description;

	private boolean enabled;

	@Column(name="warehouse_code")
	private Object warehouseCode;

	@Column(name="warehouse_name")
	private Object warehouseName;

	@Column(name="warehouse_parent_id")
	private long warehouseParentId;

	public List<TransactionMaster> getDeliveredTransactionMasters() {
		return deliveredTransactionMasters;
	}

	public void setDeliveredTransactionMasters(List<TransactionMaster> deliveredTransactionMasters) {
		this.deliveredTransactionMasters = deliveredTransactionMasters;
	}

	//bi-directional many-to-one association to TransactionMaster
	@OneToMany(mappedBy="deliveredWarehouse")
	private List<TransactionMaster> deliveredTransactionMasters;

	//bi-directional many-to-one association to TransactionMaster
	@OneToMany(mappedBy="receivedWarehouse")
	private List<TransactionMaster> receivedTransactionMasters;
		
	public Warehouse() {
	}

	public long getWarehouseId() {
		return this.warehouseId;
	}

	public void setWarehouseId(long warehouseId) {
		this.warehouseId = warehouseId;
	}

	

	public Object getDescription() {
		return this.description;
	}

	public void setDescription(Object description) {
		this.description = description;
	}

	public boolean getEnabled() {
		return this.enabled;
	}

	public void setEnabled(boolean enabled) {
		this.enabled = enabled;
	}


	public Object getWarehouseCode() {
		return this.warehouseCode;
	}

	public void setWarehouseCode(Object warehouseCode) {
		this.warehouseCode = warehouseCode;
	}

	public Object getWarehouseName() {
		return this.warehouseName;
	}

	public void setWarehouseName(Object warehouseName) {
		this.warehouseName = warehouseName;
	}

	public long getWarehouseParentId() {
		return this.warehouseParentId;
	}

	public void setWarehouseParentId(long warehouseParentId) {
		this.warehouseParentId = warehouseParentId;
	}

	public List<TransactionMaster> getTransactionMasters() {
		return this.deliveredTransactionMasters;
	}

	public void setTransactionMasters(List<TransactionMaster> transactionMasters) {
		this.deliveredTransactionMasters = transactionMasters;
	}

	public TransactionMaster addTransactionMaster(TransactionMaster transactionMaster) {
		getTransactionMasters().add(transactionMaster);
		transactionMaster.setDeliveredWarehouse(this);

		return transactionMaster;
	}

	public TransactionMaster removeDeliveredTransactionMaster(TransactionMaster transactionMaster) {
		getDeliveredTransactionMasters().remove(transactionMaster);
		transactionMaster.setDeliveredWarehouse(null);

		return transactionMaster;
	}
	
	public List<TransactionMaster> getReceivedTransactionMasters() {
		return this.receivedTransactionMasters;
	}

	public void setReceivedTransactionMasters(List<TransactionMaster> transactionMasters) {
		this.receivedTransactionMasters = transactionMasters;
	}

	public TransactionMaster addReceivedTransactionMaster(TransactionMaster transactionMaster) {
		getTransactionMasters().add(transactionMaster);
		transactionMaster.setReceivedWarehouse(this);

		return transactionMaster;
	}

	public TransactionMaster removeReceivedTransactionMaster(TransactionMaster transactionMaster) {
		getTransactionMasters().remove(transactionMaster);
		transactionMaster.setReceivedWarehouse(null);

		return transactionMaster;
	}

}