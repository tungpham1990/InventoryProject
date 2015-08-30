package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.math.BigDecimal;


/**
 * The persistent class for the transactionmaster database table.
 * 
 */
@Entity
@Table(name="transactionmaster")
@NamedQuery(name="Transactionmaster.findAll", query="SELECT t FROM Transactionmaster t")
public class Transactionmaster extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="TransactionMasterId")
	private long transactionMasterId;

	@Column(name="CreatedDate")
	private Object createdDate;

	@Column(name="CreateUser")
	private Object createUser;

	@Column(name="CustomerId")
	private long customerId;

	@Column(name="Deliver")
	private Object deliver;

	@Column(name="DeliveredWarehosuseId")
	private long deliveredWarehosuseId;

	@Column(name="PercentCharges")
	private BigDecimal percentCharges;

	@Column(name="ReceivedWarehouseId")
	private long receivedWarehouseId;

	@Column(name="Receiver")
	private Object receiver;

	@Column(name="SupplierId")
	private long supplierId;

	@Column(name="TotalAmount")
	private BigDecimal totalAmount;

	@Column(name="TotalCharges")
	private BigDecimal totalCharges;

	@Column(name="TotalPrice")
	private BigDecimal totalPrice;

	@Column(name="TransactionCode")
	private Object transactionCode;

	@Column(name="TransactionDate")
	private Object transactionDate;

	@Column(name="TransactionTypeId")
	private long transactionTypeId;

	@Column(name="UpdateDate")
	private Object updateDate;

	@Column(name="UpdateUser")
	private Object updateUser;

	public Transactionmaster() {
	}

	public long getTransactionMasterId() {
		return this.transactionMasterId;
	}

	public void setTransactionMasterId(long transactionMasterId) {
		this.transactionMasterId = transactionMasterId;
	}

	public Object getCreatedDate() {
		return this.createdDate;
	}

	public void setCreatedDate(Object createdDate) {
		this.createdDate = createdDate;
	}

	public Object getCreateUser() {
		return this.createUser;
	}

	public void setCreateUser(Object createUser) {
		this.createUser = createUser;
	}

	public long getCustomerId() {
		return this.customerId;
	}

	public void setCustomerId(long customerId) {
		this.customerId = customerId;
	}

	public Object getDeliver() {
		return this.deliver;
	}

	public void setDeliver(Object deliver) {
		this.deliver = deliver;
	}

	public long getDeliveredWarehosuseId() {
		return this.deliveredWarehosuseId;
	}

	public void setDeliveredWarehosuseId(long deliveredWarehosuseId) {
		this.deliveredWarehosuseId = deliveredWarehosuseId;
	}

	public BigDecimal getPercentCharges() {
		return this.percentCharges;
	}

	public void setPercentCharges(BigDecimal percentCharges) {
		this.percentCharges = percentCharges;
	}

	public long getReceivedWarehouseId() {
		return this.receivedWarehouseId;
	}

	public void setReceivedWarehouseId(long receivedWarehouseId) {
		this.receivedWarehouseId = receivedWarehouseId;
	}

	public Object getReceiver() {
		return this.receiver;
	}

	public void setReceiver(Object receiver) {
		this.receiver = receiver;
	}

	public long getSupplierId() {
		return this.supplierId;
	}

	public void setSupplierId(long supplierId) {
		this.supplierId = supplierId;
	}

	public BigDecimal getTotalAmount() {
		return this.totalAmount;
	}

	public void setTotalAmount(BigDecimal totalAmount) {
		this.totalAmount = totalAmount;
	}

	public BigDecimal getTotalCharges() {
		return this.totalCharges;
	}

	public void setTotalCharges(BigDecimal totalCharges) {
		this.totalCharges = totalCharges;
	}

	public BigDecimal getTotalPrice() {
		return this.totalPrice;
	}

	public void setTotalPrice(BigDecimal totalPrice) {
		this.totalPrice = totalPrice;
	}

	public Object getTransactionCode() {
		return this.transactionCode;
	}

	public void setTransactionCode(Object transactionCode) {
		this.transactionCode = transactionCode;
	}

	public Object getTransactionDate() {
		return this.transactionDate;
	}

	public void setTransactionDate(Object transactionDate) {
		this.transactionDate = transactionDate;
	}

	public long getTransactionTypeId() {
		return this.transactionTypeId;
	}

	public void setTransactionTypeId(long transactionTypeId) {
		this.transactionTypeId = transactionTypeId;
	}

	public Object getUpdateDate() {
		return this.updateDate;
	}

	public void setUpdateDate(Object updateDate) {
		this.updateDate = updateDate;
	}

	public Object getUpdateUser() {
		return this.updateUser;
	}

	public void setUpdateUser(Object updateUser) {
		this.updateUser = updateUser;
	}

}