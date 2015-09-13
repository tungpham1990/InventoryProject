package springweb.entities;

import java.io.Serializable;
import java.sql.Timestamp;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQuery;
import javax.persistence.Table;

@Entity
@Table(name="transaction_master")
@NamedQuery(name="TransactionMaster.findAll", query="SELECT c FROM TransactionMaster c")
public class TransactionMaster extends BaseEntity implements Serializable {



	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;


	@Id
	@Column(name="transaction_master_id")
	private Long transactionMasterId;
	
	
	@Column(name="transaction_code")
	private String transactionCode;
	
	
	@Column(name="transaction_type_id")
	private String transaction_type_id;
	
	
	@Column(name="transaction_date")
	private Timestamp transactionDate;
	
	@ManyToOne
	@JoinColumn(name = "received_warehouse_id", nullable = true)
	private Warehouse receivedWarehouse;
	
	@ManyToOne
	@JoinColumn(name = "delivered_warehosuse_id", nullable = true)
	private Warehouse deliveredWarehouse;
	
	
	@Column(name="receiver")
	private String receiver;
	
	
	
	@Column(name="deliver")
	private String deliver;
	
	@ManyToOne
	@JoinColumn(name = "customer_id", nullable = true)
	private Customer customer;
	
	
	@ManyToOne
	@JoinColumn(name = "supplier_id", nullable = true)
	private Supplier supplier;
	
	
	@Column(name="total_price")
	private float totalPrice;
	
	
	@Column(name="percent_charges")
	private float percentCharges;
	
	
	@Column(name="total_charges")
	private float totalCharges;
	
	
	public Long getTransactionMasterId() {
		return transactionMasterId;
	}


	public void setTransactionMasterId(Long transactionMasterId) {
		this.transactionMasterId = transactionMasterId;
	}


	public String getTransactionCode() {
		return transactionCode;
	}


	public void setTransactionCode(String transactionCode) {
		this.transactionCode = transactionCode;
	}


	public String getTransaction_type_id() {
		return transaction_type_id;
	}


	public void setTransaction_type_id(String transaction_type_id) {
		this.transaction_type_id = transaction_type_id;
	}


	public Timestamp getTransactionDate() {
		return transactionDate;
	}


	public void setTransactionDate(Timestamp transactionDate) {
		this.transactionDate = transactionDate;
	}


	public Warehouse getReceivedWarehouse() {
		return receivedWarehouse;
	}


	public void setReceivedWarehouse(Warehouse receivedWarehouse) {
		this.receivedWarehouse = receivedWarehouse;
	}


	public Warehouse getDeliveredWarehouse() {
		return deliveredWarehouse;
	}


	public void setDeliveredWarehouse(Warehouse deliveredWarehosuse) {
		this.deliveredWarehouse = deliveredWarehosuse;
	}


	public String getReceiver() {
		return receiver;
	}


	public void setReceiver(String receiver) {
		this.receiver = receiver;
	}


	public String getDeliver() {
		return deliver;
	}


	public void setDeliver(String deliver) {
		this.deliver = deliver;
	}


	public Customer getCustomer() {
		return customer;
	}


	public void setCustomer(Customer customer) {
		this.customer = customer;
	}


	public Supplier getSupplier() {
		return supplier;
	}


	public void setSupplier(Supplier supplier) {
		this.supplier = supplier;
	}


	public float getTotalPrice() {
		return totalPrice;
	}


	public void setTotalPrice(float totalPrice) {
		this.totalPrice = totalPrice;
	}


	public float getPercentCharges() {
		return percentCharges;
	}


	public void setPercentCharges(float percentCharges) {
		this.percentCharges = percentCharges;
	}


	public float getTotalCharges() {
		return totalCharges;
	}


	public void setTotalCharges(float totalCharges) {
		this.totalCharges = totalCharges;
	}


	public float getTotalAmount() {
		return totalAmount;
	}


	public void setTotalAmount(float totalAmount) {
		this.totalAmount = totalAmount;
	}


	public Boolean isEnabled() {
		return enabled;
	}


	public void setEnabled(Boolean enabled) {
		this.enabled = enabled;
	}


	public String getDescription() {
		return Description;
	}


	public void setDescription(String description) {
		Description = description;
	}


	@Column(name="total_amount")
	private float totalAmount;
	
	
	@Column(name="enabled")
	private Boolean enabled;
	
	
	@Column(name="Description")
	private String Description;
	
}
