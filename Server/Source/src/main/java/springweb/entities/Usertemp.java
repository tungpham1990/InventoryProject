package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the usertemp database table.
 * 
 */
@Entity
@Table(name="usertemp")
@NamedQuery(name="Usertemp.findAll", query="SELECT u FROM Usertemp u")
public class Usertemp extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Column(name="Enabled")
	private boolean enabled;

	@Column(name="Password")
	private String password;

	@Id
	@Column(name="UserCode")
	private String userCode;

	@Column(name="Password")
	private String userName;

	public Usertemp() {
	}

	public boolean getEnabled() {
		return this.enabled;
	}

	public void setEnabled(boolean enabled) {
		this.enabled = enabled;
	}

	public String getPassword() {
		return this.password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	public String getUserCode() {
		return this.userCode;
	}

	public void setUserCode(String userCode) {
		this.userCode = userCode;
	}

	public String getUserName() {
		return this.userName;
	}

	public void setUserName(String userName) {
		this.userName = userName;
	}

}