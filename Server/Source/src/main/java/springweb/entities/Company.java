package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the company database table.
 * 
 */
@Entity
@Table(name="company")
@NamedQuery(name="Company.findAll", query="SELECT c FROM Company c")
public class Company extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="CompanyId")
	private long companyId;

	@Column(name="CompanyCode")
	private Object companyCode;

	@Column(name="CompanyName")
	private Object companyName;

	@Column(name="CompanyParentId")
	private long companyParentId;

	@Column(name="CompanyShortName")
	private Object companyShortName;

	@Column(name="CreatedDate")
	private Object createdDate;

	@Column(name="CreateUser")
	private Object createUser;

	@Column(name="Description")
	private Object description;

	@Column(name="Enabled")
	private short enabled;

	@Column(name="IsBranch")
	private short isBranch;

	@Column(name="UpdateDate")
	private Object updateDate;

	@Column(name="UpdateUser")
	private Object updateUser;

	public Company() {
	}

	public long getCompanyId() {
		return this.companyId;
	}

	public void setCompanyId(long companyId) {
		this.companyId = companyId;
	}

	public Object getCompanyCode() {
		return this.companyCode;
	}

	public void setCompanyCode(Object companyCode) {
		this.companyCode = companyCode;
	}

	public Object getCompanyName() {
		return this.companyName;
	}

	public void setCompanyName(Object companyName) {
		this.companyName = companyName;
	}

	public long getCompanyParentId() {
		return this.companyParentId;
	}

	public void setCompanyParentId(long companyParentId) {
		this.companyParentId = companyParentId;
	}

	public Object getCompanyShortName() {
		return this.companyShortName;
	}

	public void setCompanyShortName(Object companyShortName) {
		this.companyShortName = companyShortName;
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

	public short getIsBranch() {
		return this.isBranch;
	}

	public void setIsBranch(short isBranch) {
		this.isBranch = isBranch;
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