package springweb.daos;

import springweb.entities.UserInfo;

/**
 * Created by MinhPK on 7/30/15.
 */
public interface UserDAO<UserInfo> extends BaseDAO<UserInfo> {
    public UserInfo findByUserName(String username);
}
