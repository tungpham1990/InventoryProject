package springweb.daos;

import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import java.lang.reflect.ParameterizedType;
import java.util.List;

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
    public E getByID(Long ID) {
        return entityManager.find(entityType, ID);
    }

    @Override
    public void save(E type) {
        entityManager.persist(type);
    }

    @Override
    public E update(E type) {
        return entityManager.merge(type);
    }

    @Override
    public void delete(E type) {
        entityManager.remove(entityManager.contains(type) ? type : entityManager.merge(type));
    }

	@Override
	public void persist(E e) throws Exception {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void merge(E e) throws Exception {
		// TODO Auto-generated method stub
		
	}

	@Override
	public void remove(Object id) throws Exception {
		// TODO Auto-generated method stub
		
	}

	@Override
	public E findById(Object id) throws Exception {
		// TODO Auto-generated method stub
		return null;
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