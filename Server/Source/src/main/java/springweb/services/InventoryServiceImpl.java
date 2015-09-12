package springweb.services;

import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.ParameterMode;
import javax.persistence.PersistenceContext;
import javax.persistence.StoredProcedureQuery;

import springweb.entities.Inventory;

public class InventoryServiceImpl implements InventoryService{
	@PersistenceContext
    private EntityManager entityManager;
    
	@Override
	public List<Inventory> calculateInventory(int itemId, int warehouseId) {
        StoredProcedureQuery storedProcedure = entityManager.createStoredProcedureQuery("sp_calculate_inventory", Inventory.class);
        // set parameters
        storedProcedure.registerStoredProcedureParameter("item_id", Integer.class, ParameterMode.IN);
        storedProcedure.registerStoredProcedureParameter("warehouse_id", Integer.class, ParameterMode.IN);
        storedProcedure.setParameter("item_id", itemId);
        storedProcedure.setParameter("warehouse_id", warehouseId);
        // execute SP
        storedProcedure.execute();
        // get result
        List<Inventory> invList = storedProcedure.getResultList();
        System.out.println("inventory is: " + invList);
		return invList;
	}

}
