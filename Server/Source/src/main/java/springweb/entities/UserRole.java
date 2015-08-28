package springweb.entities;

import org.springframework.stereotype.Repository;

import javax.persistence.Entity;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

/**
 * Created by MinhPK on 7/30/15.
 */

@Entity
@Table(name = "user_roles")
public class UserRole extends BaseEntity{

    @ManyToOne
    private User user;

    private String role;

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        this.role = role;
    }
}
