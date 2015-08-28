package springweb.daos;

import springweb.entities.User;

/**
 * Created by MinhPK on 7/30/15.
 */
public interface UserDAO<User> extends BaseDAO<User> {
    public User findByUserName(String username);
}
