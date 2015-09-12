package springweb.daos;

import springweb.entities.UserInfo;

/**
 * Created by MinhPK on 7/30/15.
 */
public interface WarehouseDAO<Warehouse> extends BaseDAO<Warehouse> {
    public UserInfo findByUserName(String username);
}
