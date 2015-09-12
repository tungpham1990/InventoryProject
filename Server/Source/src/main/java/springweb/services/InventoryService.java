package springweb.services;

import springweb.entities.Inventory;

/**
 * Created by MinhPK on 7/30/15.
 */

public interface InventoryService {
    public Inventory calculateInventory(int itemId, int warehouseId);
}
