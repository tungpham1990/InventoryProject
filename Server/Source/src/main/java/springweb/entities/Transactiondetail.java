package springweb.entities;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.OneToOne;
import javax.persistence.Table;

@Entity
@Table(name="transaction_detail")
@NamedQuery(name="TransactionDetail.findAll", query="SELECT c FROM TransactionDetail c")
public class TransactionDetail extends BaseEntity implements Serializable {
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="transaction_detail_id")
	private long transactionDetailId;
	
	@ManyToOne
	@JoinColumn(name = "transaction_master_id", nullable = false)
	private TransactionMaster transactionMaster;
	
	@Column(name="category_item_id")
	private long categoryItemId;
	
	@OneToOne
	private Item item;
	
	@Column(name="price")
	private float price;
	
	@Column(name="unit_id")
	private Unit unit;
	
	@Column(name="quantity")
	private long quantity;
	
	@Column(name="total_price")
	private float totalPrice;
	
	@Column(name="percent_charges")
	private float percentCharges;
	
	@Column(name="total_charges")
	private float totalCharges;
	
	public long getTransactionDetailId() {
		return transactionDetailId;
	}

	public void setTransactionDetailId(long transactionDetailId) {
		this.transactionDetailId = transactionDetailId;
	}

	public TransactionMaster getTransactionMaster() {
		return transactionMaster;
	}

	public void setTransactionMaster(TransactionMaster transactionMaster) {
		this.transactionMaster = transactionMaster;
	}

	public long getCategoryItemId() {
		return categoryItemId;
	}

	public void setCategoryItemId(long categoryItemId) {
		this.categoryItemId = categoryItemId;
	}

	public Item getItem() {
		return item;
	}

	public void setItem(Item item) {
		this.item = item;
	}

	public float getPrice() {
		return price;
	}

	public void setPrice(float price) {
		this.price = price;
	}

	public Unit getUnit() {
		return unit;
	}

	public void setUnit(Unit unit) {
		this.unit = unit;
	}

	public long getQuantity() {
		return quantity;
	}

	public void setQuantity(long quantity) {
		this.quantity = quantity;
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

	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	@Column(name="total_amount")
	private float totalAmount;
	
	@Column(name="description")
	private String description;
	
}
