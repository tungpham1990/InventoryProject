package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.math.BigDecimal;


/**
 * The persistent class for the transactiondetail database table.
 * 
 */
@Entity
@Table(name="transactiondetail")
@NamedQuery(name="Transactiondetail.findAll", query="SELECT t FROM Transactiondetail t")
public class Transactiondetail extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="TransactionDetailId")
	private long transactionDetailId;

	@Column(name="CategoryItemId")
	private long categoryItemId;

	@Column(name="CreatedDate")
	private Object createdDate;

	@Column(name="CreateUser")
	private Object createUser;

	@Column(name="Description")
	private Object description;

	@Column(name="ItemId")
	private long itemId;

	@Column(name="PercentCharges")
	private BigDecimal percentCharges;

	@Column(name="Price")
	private BigDecimal price;

	@Column(name="Quantity")
	private BigDecimal quantity;

	@Column(name="TotalAmount")
	private BigDecimal totalAmount;

	@Column(name="TotalCharges")
	private BigDecimal totalCharges;

	@Column(name="TotalPrice")
	private BigDecimal totalPrice;

	@Column(name="TransactionMasterId")
	private long transactionMasterId;

	@Column(name="UnitId")
	private long unitId;

	@Column(name="UpdateDate")
	private Object updateDate;

	@Column(name="UpdateUser")
	private Object updateUser;

	public Transactiondetail() {
	}

	public long getTransactionDetailId() {
		return this.transactionDetailId;
	}

	public void setTransactionDetailId(long transactionDetailId) {
		this.transactionDetailId = transactionDetailId;
	}

	public long getCategoryItemId() {
		return this.categoryItemId;
	}

	public void setCategoryItemId(long categoryItemId) {
		this.categoryItemId = categoryItemId;
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

	public Object getDescription() {
		return this.description;
	}

	public void setDescription(Object description) {
		this.description = description;
	}

	public long getItemId() {
		return this.itemId;
	}

	public void setItemId(long itemId) {
		this.itemId = itemId;
	}

	public BigDecimal getPercentCharges() {
		return this.percentCharges;
	}

	public void setPercentCharges(BigDecimal percentCharges) {
		this.percentCharges = percentCharges;
	}

	public BigDecimal getPrice() {
		return this.price;
	}

	public void setPrice(BigDecimal price) {
		this.price = price;
	}

	public BigDecimal getQuantity() {
		return this.quantity;
	}

	public void setQuantity(BigDecimal quantity) {
		this.quantity = quantity;
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

	public long getTransactionMasterId() {
		return this.transactionMasterId;
	}

	public void setTransactionMasterId(long transactionMasterId) {
		this.transactionMasterId = transactionMasterId;
	}

	public long getUnitId() {
		return this.unitId;
	}

	public void setUnitId(long unitId) {
		this.unitId = unitId;
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