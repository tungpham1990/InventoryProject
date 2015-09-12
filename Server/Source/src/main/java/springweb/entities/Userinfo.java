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
	private long userInfoId;

	private Object cmnd;

	private Object description;

	private Object email;

	private boolean enabled;

	private Object phone;

	@Column(name="role_info")
	private Object roleInfo;

	
	@Column(name="user_info_code")
	private Object userInfoCode;

	@Column(name="user_info_name")
	private Object userInfoName;

	public UserInfo() {
	}

	public long getUserInfoId() {
		return this.userInfoId;
	}

	public void setUserInfoId(long userInfoId) {
		this.userInfoId = userInfoId;
	}

	public Object getCmnd() {
		return this.cmnd;
	}

	public void setCmnd(Object cmnd) {
		this.cmnd = cmnd;
	}

	

	public Object getDescription() {
		return this.description;
	}

	public void setDescription(Object description) {
		this.description = description;
	}

	public Object getEmail() {
		return this.email;
	}

	public void setEmail(Object email) {
		this.email = email;
	}

	public boolean getEnabled() {
		return this.enabled;
	}

	public void setEnabled(boolean enabled) {
		this.enabled = enabled;
	}

	public Object getPhone() {
		return this.phone;
	}

	public void setPhone(Object phone) {
		this.phone = phone;
	}

	public Object getRoleInfo() {
		return this.roleInfo;
	}

	public void setRoleInfo(Object roleInfo) {
		this.roleInfo = roleInfo;
	}

	
	public Object getUserInfoCode() {
		return this.userInfoCode;
	}

	public void setUserInfoCode(Object userInfoCode) {
		this.userInfoCode = userInfoCode;
	}

	public Object getUserInfoName() {
		return this.userInfoName;
	}

	public void setUserInfoName(Object userInfoName) {
		this.userInfoName = userInfoName;
	}

}