package springweb.services;

import java.util.ArrayList;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;

import springweb.daos.CategoryItemDAO;
import springweb.daos.ItemDAO;
import springweb.daos.TransactionDetailDAO;
import springweb.daos.TransactionMasterDAO;
import springweb.daos.WarehouseDAO;
import springweb.entities.CategoryItem;
import springweb.entities.Item;
import springweb.entities.TransactionDetail;
import springweb.entities.TransactionMaster;
import springweb.entities.Warehouse;

public class SyncServiceImpl implements SyncService{
	
 	 @Autowired
     private TransactionMasterDAO<TransactionMaster> transactionMasterDAO;
 	 @Autowired
 	 private TransactionDetailDAO<TransactionDetail> transactionDetailDAO;
 	 @Autowired
 	 private ItemDAO<Item> itemDAO;
 	 @Autowired
 	 private CategoryItemDAO<CategoryItem> categoryItemDAO;
 	 @Autowired
 	 private WarehouseDAO<Warehouse> warehouseDAO;

	@Override
	public TransactionMaster createTransactionMaster(TransactionMaster transactionMaster) {
		try {
			return transactionMasterDAO.merge(transactionMaster);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return null;
	}

	@Override
	public TransactionMaster updateTransactionMaster(TransactionMaster transactionMaster) {
		try {
			return transactionMasterDAO.merge(transactionMaster);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}

	@Override
	public boolean deteleTransactionMaster(long transactionId) {
		try {
			TransactionMaster transactionMaster = transactionMasterDAO.findById(transactionId);
			transactionMasterDAO.remove(transactionMaster);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return false;
		}
		return true;
	}

	@Override
	public TransactionMaster getTransactionMasterById(long transactionId) {
		try {
			return transactionMasterDAO.findById(transactionId);
		} catch (Exception e) {
			e.printStackTrace();
		}
		return new TransactionMaster();
	}

	@Override
	public List<TransactionMaster> getAllTransactionMaster() {
		try {
			return transactionMasterDAO.findAll();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return new ArrayList<TransactionMaster>();
	}

	@Override
	public TransactionDetail createTransactionDetail(TransactionDetail transactionDetail) {
		try {
			return transactionDetailDAO.merge(transactionDetail);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}

	@Override
	public TransactionDetail updateTransactionDetail(TransactionDetail transactionDetail) {
		try {
			return transactionDetailDAO.merge(transactionDetail);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}

	@Override
	public boolean deteleTransactionDetail(long transactionId) {
		
		try {
			TransactionDetail transactionDetail = transactionDetailDAO.findById(transactionId);
			transactionDetailDAO.remove(transactionDetail);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
			return false;
		}
		return true;
	}

	@Override
	public TransactionDetail getTransactionDetailById(long transactionId) {
		try {
			transactionDetailDAO.findById(transactionId);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}

	@Override
	public List<TransactionDetail> getAllTransactionDetail() {
		try {
			return transactionDetailDAO.findAll();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return new ArrayList<TransactionDetail>();
	}

	@Override
	public Warehouse getWarehouseById(long warehouseId) {
		try {
			return warehouseDAO.findById(warehouseId);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return new Warehouse();
	}

	@Override
	public List<Warehouse> getAllWarehouse() {
		try {
			return warehouseDAO.findAll();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return new ArrayList<Warehouse>();
	}

	@Override
	public CategoryItem getCategoryItem(long categoryId) {
		try {
			return categoryItemDAO.findById(categoryId);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return new CategoryItem();
	}

	@Override
	public List<CategoryItem> getAllCategoryItem() {
		try {
			return categoryItemDAO.findAll();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return new ArrayList<CategoryItem>();
	}

	@Override
	public Item getItemById(long itemId) {
		try {
			return itemDAO.findById(itemId);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return new Item();
	}

	@Override
	public List<Item> getAllItem() {
		try {
			return itemDAO.findAll();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return new ArrayList<Item>();
	}

	@Override
	public List<Item> getItemsByWarehouseId(long warehouseId) {
		return itemDAO.getItemsByWarehouseId(warehouseId);
	}

	public TransactionMasterDAO<TransactionMaster> getTransactionMasterDAO() {
		return transactionMasterDAO;
	}

	public void setTransactionMasterDAO(TransactionMasterDAO<TransactionMaster> transactionMasterDAO) {
		this.transactionMasterDAO = transactionMasterDAO;
	}

	public TransactionDetailDAO<TransactionDetail> getTransactionDetailDAO() {
		return transactionDetailDAO;
	}

	public void setTransactionDetailDAO(TransactionDetailDAO<TransactionDetail> transactionDetailDAO) {
		this.transactionDetailDAO = transactionDetailDAO;
	}

	public ItemDAO<Item> getItemDAO() {
		return itemDAO;
	}

	public void setItemDAO(ItemDAO<Item> itemDAO) {
		this.itemDAO = itemDAO;
	}

	public CategoryItemDAO<CategoryItem> getCategoryItemDAO() {
		return categoryItemDAO;
	}

	public void setCategoryItemDAO(CategoryItemDAO<CategoryItem> categoryItemDAO) {
		this.categoryItemDAO = categoryItemDAO;
	}

	public WarehouseDAO<Warehouse> getWarehouseDAO() {
		return warehouseDAO;
	}

	public void setWarehouseDAO(WarehouseDAO<Warehouse> warehouseDAO) {
		this.warehouseDAO = warehouseDAO;
	}

}
