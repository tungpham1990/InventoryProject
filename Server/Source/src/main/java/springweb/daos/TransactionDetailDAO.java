package springweb.daos;

import springweb.entities.UserInfo;

/**
 * Created by MinhPK on 7/30/15.
 */
public interface TransactionDetailDAO<TransactionDetail> extends BaseDAO<TransactionDetail> {
    public UserInfo findByUserName(String username);
}
