package springweb.daos;

import java.util.List;

/**
 * Created by MinhPK on 7/30/15.
 */
public interface ItemDAO<Item> extends BaseDAO<Item> {
    public List<Item> getItemsByWarehouseId(long warehouseId);
}
