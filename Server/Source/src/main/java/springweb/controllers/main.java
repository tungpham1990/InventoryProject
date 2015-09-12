package springweb.controllers;

import springweb.services.InventoryServiceImpl;

public class main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		InventoryServiceImpl inventory =  new InventoryServiceImpl();
		inventory.calculateInventory(1, 1);
	}

}
