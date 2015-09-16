package springweb.daos;

import springweb.entities.UserInfo;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.TypedQuery;

/**
 * Created by MinhPK on 7/30/15.
 */
public class UserDAOImpl extends BaseDAOImpl implements UserDAO {

    @PersistenceContext
    private EntityManager entityManager;

    public UserDAOImpl() {
        super(UserInfo.class);
    }

    public UserInfo findByUserName(String username) {

        TypedQuery<UserInfo> query = entityManager.
                    createQuery("SELECT u FROM usertemp u WHERE u.UserCode = :usercode", UserInfo.class);
        query.setParameter("usercode", username);

        return (UserInfo) query.getSingleResult();
    }
}