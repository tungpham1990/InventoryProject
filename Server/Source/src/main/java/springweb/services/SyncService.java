package springweb.services;

import java.util.List;

import springweb.entities.CategoryItem;
import springweb.entities.Item;
import springweb.entities.TransactionDetail;
import springweb.entities.TransactionMaster;
import springweb.entities.Warehouse;

public interface SyncService {
	public TransactionMaster createTransactionMaster(TransactionMaster transactionMaster);
	public TransactionMaster updateTransactionMaster(TransactionMaster transactionMaster);
	public boolean deteleTransactionMaster(long transactionId);
	public TransactionMaster getTransactionMasterById(long transactionId);
	public List<TransactionMaster> getAllTransactionMaster();
	
	public TransactionDetail createTransactionDetail(TransactionDetail transactionDetail);
	public TransactionDetail updateTransactionDetail(TransactionDetail transactionDetail);
	public boolean deteleTransactionDetail(long transactionId);
	public TransactionDetail getTransactionDetailById(long transactionId);
	public List<TransactionDetail> getAllTransactionDetail();

	public Warehouse getWarehouseById(long warehouseId);
	public List<Warehouse> getAllWarehouse();
	
	public CategoryItem getCategoryItem(long categoryId);
	public List<CategoryItem> getAllCategoryItem();
	
	public Item getItemById(long itemId);
	public List<Item> getAllItem();
	public List<Item> getItemsByWarehouseId(long warehouseId);
	
}
