package springweb.daos;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import java.lang.reflect.ParameterizedType;

/**
 * Created by MinhPK on 7/30/15.
 */

public class BaseDAOImpl<T> implements BaseDAO<T> {

    @PersistenceContext
    private EntityManager entityManager;

    private final Class<T> entityType;

    @SuppressWarnings("unchecked")
    public BaseDAOImpl(Class<T> entityClass) {
        this.entityType = entityClass;
    }

    @Override
    public T getByID(Long ID) {
        return entityManager.find(entityType, ID);
    }

    @Override
    public void save(T type) {
        entityManager.persist(type);
    }

    @Override
    public T update(T type) {
        return entityManager.merge(type);
    }

    @Override
    public void delete(T type) {
        entityManager.remove(entityManager.contains(type) ? type : entityManager.merge(type));
    }

}