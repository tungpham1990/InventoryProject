package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Timestamp;


/**
 * The persistent class for the user_info database table.
 * 
 */
@Entity
@Table(name="user_info")
@NamedQuery(name="UserInfo.findAll", query="SELECT u FROM UserInfo u")
public class UserInfo extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="user_info_id")
	private Long userInfoId;

	private String cmnd;

	private String description;

	private String email;

	private Boolean enabled;

	private String phone;

	@Column(name="role_info")
	private String roleInfo;

	
	@Column(name="user_info_code")
	private String userInfoCode;

	@Column(name="user_info_name")
	private String userInfoName;

	public UserInfo() {
	}

	public Long getUserInfoId() {
		return this.userInfoId;
	}

	public void setUserInfoId(Long userInfoId) {
		this.userInfoId = userInfoId;
	}

	public String getCmnd() {
		return this.cmnd;
	}

	public void setCmnd(String cmnd) {
		this.cmnd = cmnd;
	}

	

	public String getDescription() {
		return this.description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public String getEmail() {
		return this.email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public Boolean getEnabled() {
		return this.enabled;
	}

	public void setEnabled(Boolean enabled) {
		this.enabled = enabled;
	}

	public String getPhone() {
		return this.phone;
	}

	public void setPhone(String phone) {
		this.phone = phone;
	}

	public String getRoleInfo() {
		return this.roleInfo;
	}

	public void setRoleInfo(String roleInfo) {
		this.roleInfo = roleInfo;
	}

	
	public String getUserInfoCode() {
		return this.userInfoCode;
	}

	public void setUserInfoCode(String userInfoCode) {
		this.userInfoCode = userInfoCode;
	}

	public String getUserInfoName() {
		return this.userInfoName;
	}

	public void setUserInfoName(String userInfoName) {
		this.userInfoName = userInfoName;
	}

}