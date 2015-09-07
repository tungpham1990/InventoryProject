package springweb.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import springweb.services.UserInfoService;

/**
 * Created by MinhPK on 7/30/15.
 */
@Controller
@RequestMapping("/inventory")
public class InventoryController {

    @Autowired
    private UserInfoService userInfoService;

    @RequestMapping(value="/check/{itemCode}/{warehouseId}", method=RequestMethod.POST)
    public String checkInventory(@PathVariable String itemCode, @PathVariable String warehouseId) throws Exception
    {
    	
     return "";
    }

}
