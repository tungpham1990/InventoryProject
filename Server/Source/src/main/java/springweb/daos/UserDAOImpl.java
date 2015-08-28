package springweb.daos;

import springweb.entities.User;

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
        super(User.class);
    }

    public User findByUserName(String username) {

        TypedQuery<User> query = entityManager.
                    createQuery("SELECT u FROM User u WHERE u.username = ?1", User.class);
        query.setParameter(1, username);

        return (User) query.getSingleResult();
    }
}