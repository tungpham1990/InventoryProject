package springweb.daos;

import springweb.entities.UserInfo;

/**
 * Created by MinhPK on 7/30/15.
 */
public interface CategoryItemDAO<CategoryItem> extends BaseDAO<CategoryItem> {
    public UserInfo findByUserName(String username);
}
