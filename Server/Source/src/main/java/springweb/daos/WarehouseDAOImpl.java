package springweb.daos;

import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.TypedQuery;

import springweb.entities.Warehouse;

/**
 * Created by MinhPK on 7/30/15.
 */
public class WarehouseDAOImpl extends BaseDAOImpl implements WarehouseDAO {

    @PersistenceContext
    private EntityManager entityManager;

    public WarehouseDAOImpl() {
        super(Warehouse.class);
    }

    public List<Warehouse> findAllWarehouse() {

        TypedQuery<Warehouse> query = entityManager.
                    createQuery("SELECT u FROM Warehouse u", Warehouse.class);

        return query.getResultList();
    }
}