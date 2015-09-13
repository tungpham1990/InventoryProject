package springweb.entities;

import java.io.Serializable;
import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.OneToOne;
import javax.persistence.Table;


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
	private Long warehouseId;

	private String description;

	private Boolean enabled;

	@Column(name="warehouse_code")
	private String warehouseCode;

	@Column(name="warehouse_name")
	private String warehouseName;

	@OneToOne
	@JoinColumn(name = "warehouse_parent_id", nullable = true)
	private Warehouse warehouseParent;

	

	//bi-directional many-to-one association to TransactionMaster
	@OneToMany(mappedBy="deliveredWarehouse", fetch=FetchType.LAZY)
	//@JsonIgnore
	private List<TransactionMaster> deliveredTransactionMasters;

	//bi-directional many-to-one association to TransactionMaster
	@OneToMany(mappedBy="receivedWarehouse", fetch=FetchType.LAZY)
	//@JsonIgnore
	private List<TransactionMaster> receivedTransactionMasters;
	
	public Warehouse() {
	}

	public Warehouse getWarehouseParent() {
		return warehouseParent;
	}

	public void setWarehouseParent(Warehouse warehouseParent) {
		this.warehouseParent = warehouseParent;
	}

	//@JsonIgnore
	public List<TransactionMaster> getDeliveredTransactionMasters() {
		return deliveredTransactionMasters;
	}

	public void setDeliveredTransactionMasters(List<TransactionMaster> deliveredTransactionMasters) {
		this.deliveredTransactionMasters = deliveredTransactionMasters;
	}
	
	public Long getWarehouseId() {
		return this.warehouseId;
	}

	public void setWarehouseId(Long warehouseId) {
		this.warehouseId = warehouseId;
	}
	
	public String getDescription() {
		return this.description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public Boolean getEnabled() {
		return this.enabled;
	}

	public void setEnabled(Boolean enabled) {
		this.enabled = enabled;
	}


	public String getWarehouseCode() {
		return this.warehouseCode;
	}

	public void setWarehouseCode(String warehouseCode) {
		this.warehouseCode = warehouseCode;
	}

	public String getWarehouseName() {
		return this.warehouseName;
	}

	public void setWarehouseName(String warehouseName) {
		this.warehouseName = warehouseName;
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
	
	//@JsonIgnore
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