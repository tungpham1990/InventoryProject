package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Timestamp;


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
	@Column(name="company_id")
	private Long companyId;

	@Column(name="company_code")
	private String companyCode;

	@Column(name="company_name")
	private String companyName;

	@Column(name="company_parent_id")
	private Long companyParentId;

	@Column(name="company_short_name")
	private String companyShortName;


	private String description;

	private boolean enabled;

	@Column(name="is_branch")
	private boolean isBranch;


	public Company() {
	}

	public Long getCompanyId() {
		return this.companyId;
	}

	public void setCompanyId(Long companyId) {
		this.companyId = companyId;
	}

	public String getCompanyCode() {
		return this.companyCode;
	}

	public void setCompanyCode(String companyCode) {
		this.companyCode = companyCode;
	}

	public String getCompanyName() {
		return this.companyName;
	}

	public void setCompanyName(String companyName) {
		this.companyName = companyName;
	}

	public Long getCompanyParentId() {
		return this.companyParentId;
	}

	public void setCompanyParentId(Long companyParentId) {
		this.companyParentId = companyParentId;
	}

	public String getCompanyShortName() {
		return this.companyShortName;
	}

	public void setCompanyShortName(String companyShortName) {
		this.companyShortName = companyShortName;
	}

	

	public String getDescription() {
		return this.description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public boolean getEnabled() {
		return this.enabled;
	}

	public void setEnabled(boolean enabled) {
		this.enabled = enabled;
	}

	public boolean getIsBranch() {
		return this.isBranch;
	}

	public void setIsBranch(boolean isBranch) {
		this.isBranch = isBranch;
	}

	

}