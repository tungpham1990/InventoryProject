package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;


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
	@Column(name="WarehouseId")
	private long warehouseId;

	@Column(name="CreatedDate")
	private Object createdDate;

	@Column(name="CreateUser")
	private Object createUser;

	@Column(name="Description")
	private Object description;

	@Column(name="Enabled")
	private short enabled;

	@Column(name="UpdateDate")
	private Object updateDate;

	@Column(name="UpdateUser")
	private Object updateUser;

	@Column(name="WarehouseCode")
	private Object warehouseCode;

	@Column(name="WarehouseName")
	private Object warehouseName;

	@Column(name="WarehouseParentId")
	private long warehouseParentId;

	public Warehouse() {
	}

	public long getWarehouseId() {
		return this.warehouseId;
	}

	public void setWarehouseId(long warehouseId) {
		this.warehouseId = warehouseId;
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

}