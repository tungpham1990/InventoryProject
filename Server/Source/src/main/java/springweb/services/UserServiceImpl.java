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
public class UserServiceImpl implements UserService {
    private final static Logger logger = LoggerFactory.getLogger(UserServiceImpl.class);

    @Autowired
    private UserInfoDAO<UserInfo> userInfoDAO;


    public UserInfoDAO<UserInfo> getUserDAO() {
		return userInfoDAO;
	}


	public void setUserDAO(UserInfoDAO<UserInfo> userInfoDAO) {
		this.userInfoDAO = userInfoDAO;
	}


	@Override
    public UserInfo findByUserName(String username) {
        return userInfoDAO.findByUserName(username);
    }
}
