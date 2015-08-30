package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the unit database table.
 * 
 */
@Entity
@Table(name="unit")
@NamedQuery(name="Unit.findAll", query="SELECT u FROM Unit u")
public class Unit extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="UnitId")
	private long unitId;

	@Column(name="CreatedDate")
	private Object createdDate;

	@Column(name="CreateUser")
	private Object createUser;

	@Column(name="Description")
	private Object description;

	@Column(name="Enabled")
	private short enabled;

	@Column(name="UnitCode")
	private Object unitCode;

	@Column(name="UnitName")
	private Object unitName;

	@Column(name="UpdateDate")
	private Object updateDate;

	@Column(name="UpdateUser")
	private Object updateUser;

	public Unit() {
	}

	public long getUnitId() {
		return this.unitId;
	}

	public void setUnitId(long unitId) {
		this.unitId = unitId;
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

	public Object getUnitCode() {
		return this.unitCode;
	}

	public void setUnitCode(Object unitCode) {
		this.unitCode = unitCode;
	}

	public Object getUnitName() {
		return this.unitName;
	}

	public void setUnitName(Object unitName) {
		this.unitName = unitName;
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