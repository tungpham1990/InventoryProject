package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the customer database table.
 * 
 */
@Entity
@Table(name="customer")
@NamedQuery(name="Customer.findAll", query="SELECT c FROM Customer c")
public class Customer extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="CustomerId")
	private long customerId;

	@Column(name="CreatedDate")
	private Object createdDate;

	@Column(name="CreateUser")
	private Object createUser;

	@Column(name="CustomerCode")
	private Object customerCode;

	@Column(name="CustomerName")
	private Object customerName;

	@Column(name="CustomerShortName")
	private Object customerShortName;

	@Column(name="Description")
	private Object description;

	@Column(name="Enabled")
	private short enabled;

	@Column(name="IsPersonal")
	private short isPersonal;

	@Column(name="UpdateDate")
	private Object updateDate;

	@Column(name="UpdateUser")
	private Object updateUser;

	public Customer() {
	}

	public long getCustomerId() {
		return this.customerId;
	}

	public void setCustomerId(long customerId) {
		this.customerId = customerId;
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

	public Object getCustomerCode() {
		return this.customerCode;
	}

	public void setCustomerCode(Object customerCode) {
		this.customerCode = customerCode;
	}

	public Object getCustomerName() {
		return this.customerName;
	}

	public void setCustomerName(Object customerName) {
		this.customerName = customerName;
	}

	public Object getCustomerShortName() {
		return this.customerShortName;
	}

	public void setCustomerShortName(Object customerShortName) {
		this.customerShortName = customerShortName;
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

	public short getIsPersonal() {
		return this.isPersonal;
	}

	public void setIsPersonal(short isPersonal) {
		this.isPersonal = isPersonal;
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