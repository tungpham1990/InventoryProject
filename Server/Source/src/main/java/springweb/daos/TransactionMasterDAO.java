package springweb.daos;

import springweb.entities.UserInfo;

/**
 * Created by MinhPK on 7/30/15.
 */
public interface TransactionMasterDAO<TransactionMaster> extends BaseDAO<TransactionMaster> {
    public UserInfo findByUserName(String username);
}
