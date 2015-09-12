package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Timestamp;


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
	@Column(name="customer_id")
	private long customerId;

	@Column(name="create_user")
	private Object createUser;

	@Column(name="created_date")
	private Timestamp createdDate;

	@Column(name="customer_code")
	private Object customerCode;

	@Column(name="customer_name")
	private Object customerName;

	@Column(name="customer_short_name")
	private Object customerShortName;

	private Object description;

	private boolean enabled;

	@Column(name="is_personal")
	private boolean isPersonal;


	
	public Customer() {
	}

	public long getCustomerId() {
		return this.customerId;
	}

	public void setCustomerId(long customerId) {
		this.customerId = customerId;
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

	public boolean getEnabled() {
		return this.enabled;
	}

	public void setEnabled(boolean enabled) {
		this.enabled = enabled;
	}

	public boolean getIsPersonal() {
		return this.isPersonal;
	}

	public void setIsPersonal(boolean isPersonal) {
		this.isPersonal = isPersonal;
	}


}