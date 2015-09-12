package springweb.services;

import org.springframework.stereotype.Repository;
import springweb.entities.User;

/**
 * Created by MinhPK on 7/30/15.
 */

public interface UserService {
    public User findByUserName(String username);
}
