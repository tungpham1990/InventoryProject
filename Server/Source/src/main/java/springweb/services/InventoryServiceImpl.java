package springweb.services;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.ParameterMode;
import javax.persistence.Persistence;
import javax.persistence.StoredProcedureQuery;

import springweb.entities.Inventory;

public class InventoryServiceImpl implements InventoryService{
	private static final String PERSISTENCE_UNIT_NAME = "transactions-optional";
    private static EntityManagerFactory factory;
    
	@Override
	public Inventory findByUserName(String itemCode, String warehouseId) {
		factory = Persistence.createEntityManagerFactory(PERSISTENCE_UNIT_NAME);
        EntityManager em = factory.createEntityManager();

        // Create call stored procedure
        em.getTransaction().begin();
        StoredProcedureQuery storedProcedure = em.createStoredProcedureQuery("sales_tax");
        // set parameters
        storedProcedure.registerStoredProcedureParameter("subtotal", Double.class, ParameterMode.IN);
        storedProcedure.registerStoredProcedureParameter("tax", Double.class, ParameterMode.OUT);
        storedProcedure.setParameter("subtotal", 1f);
        // execute SP
        storedProcedure.execute();
        // get result
        Double tax = (Double)storedProcedure.getOutputParameterValue("tax");
        System.out.println("Tax is: " + tax);
        em.getTransaction().commit();
        em.close();
		return null;
	}

}
