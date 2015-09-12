package springweb.dtos;

import java.io.Serializable;

/**
 * Created by MinhPK on 7/30/15.
 */
public class UserDTO extends BaseDTO implements Serializable {
    private static final long serialVersionUID = -112950002831333869L;

    private String username;
    private String password;
    private boolean enabled;

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public boolean isEnabled() {
        return enabled;
    }

    public void setEnabled(boolean enabled) {
        this.enabled = enabled;
    }
}
