package springweb.daos;

import java.util.List;


public interface BaseDAO <E> {
	
	 void persist(E e) throws Exception;
	 
	 E merge(E e) throws Exception;

	 void remove(E e) throws Exception;
	 
	 void removeById(long entityId);
	 
	 E findById(Long id) throws Exception;
	 
	 List<E> findAll() throws Exception;
	 
	 List<E> findByProperty(String prop, Object val) throws Exception;
	 
	 List<E> findInRange(int firstResult, int maxResults) throws Exception;
	 
	 long count() throws Exception;
}
