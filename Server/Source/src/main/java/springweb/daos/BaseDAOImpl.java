package springweb.daos;

import java.util.List;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

/**
 * Created by MinhPK on 7/30/15.
 */

public class BaseDAOImpl<E> implements BaseDAO<E> {

    @PersistenceContext
    private EntityManager entityManager;

    private final Class<E> entityType;

    @SuppressWarnings("unchecked")
    public BaseDAOImpl(Class<E> entityClass) {
        this.entityType = entityClass;
    }

    @Override
    public E findById(Long ID) {
        return entityManager.find(entityType, ID);
    }

    @Override
    public void persist(E type) {
        entityManager.persist(type);
    }

    @Override
    public E merge(E type) {
        return entityManager.merge(type);
    }

    @Override
    public void remove(E type) {
        entityManager.remove(entityManager.contains(type) ? type : entityManager.merge(type));
    }

	@Override
	public List<E> findAll() throws Exception {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<E> findByProperty(String prop, Object val) throws Exception {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public List<E> findInRange(int firstResult, int maxResults) throws Exception {
		// TODO Auto-generated method stub
		return null;
	}

	@Override
	public long count() throws Exception {
		// TODO Auto-generated method stub
		return 0;
	}

}