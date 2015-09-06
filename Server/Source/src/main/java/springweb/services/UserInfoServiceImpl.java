package springweb.services;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import springweb.daos.UserInfoDAO;
import springweb.entities.UserInfo;

/**
 * Created by MinhPK on 7/30/15.
 */

@Repository
public class UserInfoServiceImpl implements UserInfoService {
    private final static Logger logger = LoggerFactory.getLogger(UserInfoServiceImpl.class);

    @Autowired
    private UserInfoDAO<UserInfo> userInfoDAO;

    public UserInfoDAO<UserInfo> getUserInfoDAO() {
        return userInfoDAO;
    }

    public void setUserInfoDAO(UserInfoDAO<UserInfo> UserInfoDAO) {
        this.userInfoDAO = UserInfoDAO;
    }

    @Override
    public UserInfo findByUserName(String UserInfoname) {
        return userInfoDAO.findByUserName(UserInfoname);
    }
}
