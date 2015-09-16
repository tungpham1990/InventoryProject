package springweb.services;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import springweb.daos.UserDAO;
import springweb.entities.UserInfo;

/**
 * Created by MinhPK on 7/30/15.
 */

@Repository
public class UserServiceImpl implements UserService {
    private final static Logger logger = LoggerFactory.getLogger(UserServiceImpl.class);

    @Autowired
    private UserDAO<UserInfo> userDAO;

    public UserDAO<UserInfo> getUserDAO() {
        return userDAO;
    }

    public void setUserDAO(UserDAO<UserInfo> userDAO) {
        this.userDAO = userDAO;
    }

    @Override
    public UserInfo findByUserName(String username) {
        return userDAO.findByUserName(username);
    }
}
