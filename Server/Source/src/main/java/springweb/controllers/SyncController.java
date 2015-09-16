package springweb.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;

import springweb.entities.CategoryItem;
import springweb.entities.Item;
import springweb.entities.TransactionDetail;
import springweb.entities.TransactionMaster;
import springweb.entities.Warehouse;
import springweb.services.SyncService;
import springweb.utils.InventoryConstant;

@Controller
@RequestMapping("/sync")
public class SyncController {
	
	@Autowired
    private SyncService syncService;

	@RequestMapping(value="/transaction", method=RequestMethod.POST,  produces={"application/json"})
    public @ResponseBody String createTransaction( @ModelAttribute("TransactionMaster") TransactionMaster transactionMaster, @ModelAttribute("TransactionDetailList") List<TransactionDetail> transactionDetailList) throws Exception
    {
		try{
	    	syncService.createTransactionMaster(transactionMaster);
	    	for(TransactionDetail transactionDetail : transactionDetailList){
	    		syncService.createTransactionDetail(transactionDetail);
	    	}
		}catch(Exception e){
	    	return InventoryConstant.FAIL;
		}
    	return InventoryConstant.OK;
    }
	
    @RequestMapping(value="/update/master", method=RequestMethod.POST,  produces={"application/json"})
    public @ResponseBody String updateMaster( @ModelAttribute("transactonMaster") TransactionMaster transactionMaster) throws Exception
    {
    	TransactionMaster transaction = syncService.updateTransactionMaster(transactionMaster);
    	if(transaction == null){
    		return InventoryConstant.FAIL;
    	}
    	return InventoryConstant.OK;
    }
    
    @RequestMapping(value="/create/master", method=RequestMethod.POST,  produces={"application/json"})
    public @ResponseBody String createMaster( @ModelAttribute("transactonMaster") TransactionMaster transactionMaster) throws Exception
    {
    	TransactionMaster transaction = syncService.createTransactionMaster(transactionMaster);
    	if(transaction == null){
    		return InventoryConstant.FAIL;
    	}
    	return InventoryConstant.OK;
    }
    
    @RequestMapping(value="/create/detail", method=RequestMethod.POST,  produces={"application/json"})
    public @ResponseBody String createDetail( @ModelAttribute("transactonDetail") TransactionDetail transactionDetail) throws Exception
    {
    	TransactionDetail transaction = syncService.createTransactionDetail(transactionDetail);
    	if(transaction == null){
    		return InventoryConstant.FAIL;
    	}
    	return InventoryConstant.OK;
    }
    
    @RequestMapping(value="/get/warehouse", method=RequestMethod.GET,  produces={"application/json"})
    public @ResponseBody List<Warehouse> getWarehouse() throws Exception
    {
    	return syncService.getAllWarehouse();
    }
    
    @RequestMapping(value="/get/category", method=RequestMethod.GET,  produces={"application/json"})
    public @ResponseBody List<CategoryItem> getCategoryItem() throws Exception
    {
    	return syncService.getAllCategoryItem();
    }
    
    @RequestMapping(value="/get/item", method=RequestMethod.GET,  produces={"application/json"})
    public @ResponseBody List<Item> getItem() throws Exception
    {
    	return syncService.getAllItem();
    }
    
    @RequestMapping(value="/get/item/warehouse/{warehouseId}", method=RequestMethod.GET,  produces={"application/json"})
    public @ResponseBody List<Item> getItemsWarehouse(@PathVariable long warehouseId) throws Exception
    {
    	return syncService.getItemsByWarehouseId(warehouseId);
    }
}
