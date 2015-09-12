package springweb.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;

import springweb.entities.Inventory;
import springweb.services.InventoryService;

/**
 * Created by MinhPK on 7/30/15.
 */
@Controller
@RequestMapping("/inventory")
public class InventoryController {

    @Autowired
    private InventoryService inventoryService;

    @RequestMapping(value="/check/{itemId}/{warehouseId}", method=RequestMethod.GET,  produces={"application/json"})
    public @ResponseBody List<Inventory> checkInventory(@PathVariable int itemId, @PathVariable int warehouseId) throws Exception
    {
    	List<Inventory> invList = inventoryService.calculateInventory(itemId, warehouseId);
    	return invList;
    }

}
