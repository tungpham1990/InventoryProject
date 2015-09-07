package springweb.services;

import springweb.entities.Inventory;

/**
 * Created by MinhPK on 7/30/15.
 */

public interface InventoryService {
    public Inventory findByUserName(String itemCode, String warehouseId);
}
