package springweb.services;

import springweb.entities.UserInfo;

/**
 * Created by MinhPK on 7/30/15.
 */

public interface UserInfoService {
    public UserInfo findByUserName(String username);
}
