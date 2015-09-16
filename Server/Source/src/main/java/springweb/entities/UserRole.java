package springweb.entities;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

/**
 * Created by MinhPK on 7/30/15.
 */

@Entity
@Table(name = "user_roles")
public class UserRole extends BaseEntity{

    @ManyToOne
    private UserInfo user;

    @Id
    @Column
    private String role;

    public UserInfo getUser() {
        return user;
    }

    public void setUser(UserInfo user) {
        this.user = user;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        this.role = role;
    }
}
