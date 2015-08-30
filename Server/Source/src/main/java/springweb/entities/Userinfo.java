package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the userinfo database table.
 * 
 */
@Entity
@Table(name="userinfo")
@NamedQuery(name="Userinfo.findAll", query="SELECT u FROM Userinfo u")
public class Userinfo extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="UserId")
	private long userId;

	@Column(name="CMND")
	private Object cmnd;

	@Column(name="CreatedDate")
	private Object createdDate;

	@Column(name="CreateUser")
	private Object createUser;

	@Column(name="Description")
	private Object description;

	@Column(name="Email")
	private Object email;

	@Column(name="Enabled")
	private short enabled;

	@Column(name="Password")
	private String password;

	@Column(name="Phone")
	private Object phone;

	@Column(name="RoleDescription")
	private Object roleDescription;

	@Column(name="UpdateDate")
	private Object updateDate;

	@Column(name="UpdateUser")
	private Object updateUser;

	@Column(name="UserCode")
	private Object userCode;

	@Column(name="UserName")
	private Object userName;

	public Userinfo() {
	}

	public long getUserId() {
		return this.userId;
	}

	public void setUserId(long userId) {
		this.userId = userId;
	}

	public Object getCmnd() {
		return this.cmnd;
	}

	public void setCmnd(Object cmnd) {
		this.cmnd = cmnd;
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

	public Object getEmail() {
		return this.email;
	}

	public void setEmail(Object email) {
		this.email = email;
	}

	public short getEnabled() {
		return this.enabled;
	}

	public void setEnabled(short enabled) {
		this.enabled = enabled;
	}

	public String getPassword() {
		return this.password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public Object getPhone() {
		return this.phone;
	}

	public void setPhone(Object phone) {
		this.phone = phone;
	}

	public Object getRoleDescription() {
		return this.roleDescription;
	}

	public void setRoleDescription(Object roleDescription) {
		this.roleDescription = roleDescription;
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

	public Object getUserCode() {
		return this.userCode;
	}

	public void setUserCode(Object userCode) {
		this.userCode = userCode;
	}

	public Object getUserName() {
		return this.userName;
	}

	public void setUserName(Object userName) {
		this.userName = userName;
	}

}