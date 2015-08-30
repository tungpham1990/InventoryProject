package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the categoryitem database table.
 * 
 */
@Entity
@Table(name="categoryitem")
@NamedQuery(name="Categoryitem.findAll", query="SELECT c FROM Categoryitem c")
public class Categoryitem extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="CategoryItemId")
	private long categoryItemId;

	@Column(name="CategoryItemCode")
	private Object categoryItemCode;

	@Column(name="CategoryItemName")
	private Object categoryItemName;

	@Column(name="CategoryItemParentId")
	private long categoryItemParentId;

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

	@Column(name="Specifications")
	private Object specifications;

	@Column(name="UnitId")
	private long unitId;

	@Column(name="UpdateDate")
	private Object updateDate;

	@Column(name="UpdateUser")
	private Object updateUser;

	public Categoryitem() {
	}

	public long getCategoryItemId() {
		return this.categoryItemId;
	}

	public void setCategoryItemId(long categoryItemId) {
		this.categoryItemId = categoryItemId;
	}

	public Object getCategoryItemCode() {
		return this.categoryItemCode;
	}

	public void setCategoryItemCode(Object categoryItemCode) {
		this.categoryItemCode = categoryItemCode;
	}

	public Object getCategoryItemName() {
		return this.categoryItemName;
	}

	public void setCategoryItemName(Object categoryItemName) {
		this.categoryItemName = categoryItemName;
	}

	public long getCategoryItemParentId() {
		return this.categoryItemParentId;
	}

	public void setCategoryItemParentId(long categoryItemParentId) {
		this.categoryItemParentId = categoryItemParentId;
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