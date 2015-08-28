package springweb.daos;

import org.hibernate.SessionFactory;

/**
 * Created by MinhPK on 7/30/15.
 */
public interface BaseDAO <T> {
    T getByID(Long ID);
    void save(T type);
    T update(T type);
    void delete(T type);
}
