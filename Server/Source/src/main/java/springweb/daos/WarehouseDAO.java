package springweb.daos;

import java.util.List;

/**
 * Created by MinhPK on 7/30/15.
 */
public interface WarehouseDAO<Warehouse> extends BaseDAO<Warehouse> {
    public List<Warehouse> findAllWarehouse();
}
