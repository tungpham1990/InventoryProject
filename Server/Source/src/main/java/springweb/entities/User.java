package springweb.entities;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

/**
 * Created by MinhPK on 7/30/15.
 */

@Entity
@Table(name = "usertemp")
public class User extends BaseEntity{

	@Id
    private String UserName;
    private String Password;
    private boolean Enabled;
	public String getUserName() {
		return UserName;
	}
	public void setUserName(String userName) {
		UserName = userName;
	}
	public String getPassword() {
		return Password;
	}
	public void setPassword(String password) {
		Password = password;
	}
	public boolean isEnabled() {
		return Enabled;
	}
	public void setEnabled(boolean enabled) {
		Enabled = enabled;
	}

    
}
