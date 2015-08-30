package springweb.daos;

import java.util.List;

import org.hibernate.SessionFactory;


public interface BaseDAO <E> {
    E getByID(Long ID);
    void save(E type);
    E update(E type);
    void delete(E type);
	
	void persist(E e) throws Exception;
	 
	 void merge(E e) throws Exception;

	 void remove(Object id) throws Exception;
	 
	 E findById(Object id) throws Exception;
	 
	 List<E> findAll() throws Exception;
	 
	 List<E> findByProperty(String prop, Object val) throws Exception;
	 
	 List<E> findInRange(int firstResult, int maxResults) throws Exception;
	 
	 long count() throws Exception;
}
