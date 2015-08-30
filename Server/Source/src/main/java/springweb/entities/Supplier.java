package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the supplier database table.
 * 
 */
@Entity
@Table(name="supplier")
@NamedQuery(name="Supplier.findAll", query="SELECT s FROM Supplier s")
public class Supplier extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="SupplierId")
	private long supplierId;

	@Column(name="CreatedDate")
	private Object createdDate;

	@Column(name="CreateUser")
	private Object createUser;

	@Column(name="Description")
	private Object description;

	@Column(name="Enabled")
	private short enabled;

	@Column(name="SupplierCode")
	private Object supplierCode;

	@Column(name="SupplierName")
	private Object supplierName;

	@Column(name="SupplierShortName")
	private Object supplierShortName;

	@Column(name="UpdateDate")
	private Object updateDate;

	@Column(name="UpdateUser")
	private Object updateUser;

	public Supplier() {
	}

	public long getSupplierId() {
		return this.supplierId;
	}

	public void setSupplierId(long supplierId) {
		this.supplierId = supplierId;
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

	public Object getSupplierCode() {
		return this.supplierCode;
	}

	public void setSupplierCode(Object supplierCode) {
		this.supplierCode = supplierCode;
	}

	public Object getSupplierName() {
		return this.supplierName;
	}

	public void setSupplierName(Object supplierName) {
		this.supplierName = supplierName;
	}

	public Object getSupplierShortName() {
		return this.supplierShortName;
	}

	public void setSupplierShortName(Object supplierShortName) {
		this.supplierShortName = supplierShortName;
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