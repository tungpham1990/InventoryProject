package springweb.daos;

import springweb.entities.UserInfo;
import springweb.entities.Warehouse;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.TypedQuery;

/**
 * Created by MinhPK on 7/30/15.
 */
public class WarehouseDAOImpl extends BaseDAOImpl implements WarehouseDAO {

    @PersistenceContext
    private EntityManager entityManager;

    public WarehouseDAOImpl() {
        super(Warehouse.class);
    }

    public UserInfo findByUserName(String username) {

        TypedQuery<UserInfo> query = entityManager.
                    createQuery("SELECT u FROM UserInfo u WHERE u.userInfoName = ?1", UserInfo.class);
        query.setParameter(1, username);

        return (UserInfo) query.getSingleResult();
    }
}