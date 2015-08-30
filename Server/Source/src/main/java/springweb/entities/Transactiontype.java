package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the transactiontype database table.
 * 
 */
@Entity
@Table(name="transactiontype")
@NamedQuery(name="Transactiontype.findAll", query="SELECT t FROM Transactiontype t")
public class Transactiontype extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="TransactionTypeId")
	private long transactionTypeId;

	@Column(name="CreatedDate")
	private Object createdDate;

	@Column(name="CreateUser")
	private Object createUser;

	@Column(name="Description")
	private Object description;

	@Column(name="Enabled")
	private short enabled;

	@Column(name="TransactionTypeCode")
	private Object transactionTypeCode;

	@Column(name="UpdateDate")
	private Object updateDate;

	@Column(name="UpdateUser")
	private Object updateUser;

	public Transactiontype() {
	}

	public long getTransactionTypeId() {
		return this.transactionTypeId;
	}

	public void setTransactionTypeId(long transactionTypeId) {
		this.transactionTypeId = transactionTypeId;
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

	public Object getTransactionTypeCode() {
		return this.transactionTypeCode;
	}

	public void setTransactionTypeCode(Object transactionTypeCode) {
		this.transactionTypeCode = transactionTypeCode;
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