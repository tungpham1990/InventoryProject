package springweb.services;

import java.util.List;

import springweb.entities.Inventory;

/**
 * Created by MinhPK on 7/30/15.
 */

public interface InventoryService {
    public List<Inventory> calculateInventory(int itemId, int warehouseId);
}
