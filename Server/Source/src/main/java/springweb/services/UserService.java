package springweb.services;

import springweb.entities.UserInfo;

/**
 * Created by MinhPK on 7/30/15.
 */

public interface UserService {
    public UserInfo findByUserName(String username);
}
