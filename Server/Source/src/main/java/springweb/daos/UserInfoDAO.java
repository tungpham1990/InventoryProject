package springweb.daos;

import springweb.entities.UserInfo;

/**
 * Created by MinhPK on 7/30/15.
 */
public interface UserInfoDAO<User> extends BaseDAO<User> {
    public UserInfo findByUserName(String username);
}
