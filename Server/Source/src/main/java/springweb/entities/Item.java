package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the item database table.
 * 
 */
@Entity
@Table(name="item")
@NamedQuery(name="Item.findAll", query="SELECT i FROM Item i")
public class Item extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="ItemId")
	private long itemId;

	@Column(name="CategoryItemsId")
	private long categoryItemsId;

	@Column(name="CreatedDate")
	private Object createdDate;

	@Column(name="CreateUser")
	private Object createUser;

	@Column(name="Description")
	private Object description;

	@Column(name="Enabled")
	private short enabled;

	@Column(name="Features")
	private Object features;

	@Column(name="ItemCode")
	private Object itemCode;

	@Column(name="ItemName")
	private Object itemName;

	@Column(name="Specifications")
	private Object specifications;

	@Column(name="UnitId")
	private long unitId;

	@Column(name="UpdateDate")
	private Object updateDate;

	@Column(name="UpdateUser")
	private Object updateUser;

	public Item() {
	}

	public long getItemId() {
		return this.itemId;
	}

	public void setItemId(long itemId) {
		this.itemId = itemId;
	}

	public long getCategoryItemsId() {
		return this.categoryItemsId;
	}

	public void setCategoryItemsId(long categoryItemsId) {
		this.categoryItemsId = categoryItemsId;
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

	public short getEnabled() {
		return this.enabled;
	}

	public void setEnabled(short enabled) {
		this.enabled = enabled;
	}

	public Object getFeatures() {
		return this.features;
	}

	public void setFeatures(Object features) {
		this.features = features;
	}

	public Object getItemCode() {
		return this.itemCode;
	}

	public void setItemCode(Object itemCode) {
		this.itemCode = itemCode;
	}

	public Object getItemName() {
		return this.itemName;
	}

	public void setItemName(Object itemName) {
		this.itemName = itemName;
	}

	public Object getSpecifications() {
		return this.specifications;
	}

	public void setSpecifications(Object specifications) {
		this.specifications = specifications;
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