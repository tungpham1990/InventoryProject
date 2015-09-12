package springweb.daos;

import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.ParameterMode;
import javax.persistence.PersistenceContext;
import javax.persistence.StoredProcedureQuery;

import springweb.entities.Item;

/**
 * Created by MinhPK on 7/30/15.
 */
public class ItemDAOImpl extends BaseDAOImpl implements ItemDAO {

    @PersistenceContext
    private EntityManager entityManager;

    public ItemDAOImpl() {
        super(Item.class);
    }

	@Override
	public List<Item> getItemsByWarehouseId(long warehouseId) {
		 StoredProcedureQuery storedProcedure = entityManager.createStoredProcedureQuery("sp_get_warehouse_item", Item.class);
        // set parameters
        storedProcedure.registerStoredProcedureParameter("warehouse_id", Integer.class, ParameterMode.IN);
        storedProcedure.setParameter("warehouse_id", warehouseId);
        // execute SP
        storedProcedure.execute();
        // get result
        List<Item> itemList = storedProcedure.getResultList();
		return itemList;
	}
}