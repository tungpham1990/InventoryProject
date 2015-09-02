package springweb.entities;

import java.io.Serializable;

import javax.persistence.Entity;
import javax.persistence.NamedQuery;
import javax.persistence.Table;

@Entity
@Table(name="transaction_detail")
@NamedQuery(name="TransactionDetail.findAll", query="SELECT c FROM TransactionDetail c")
public class TransactionDetail extends BaseEntity implements Serializable {
	
	transaction_detail_id
	transaction_master_id
	category_item_id
	item_id
	price
	unit_id
	quantity
	total_price
	percent_charges
	total_charges
	total_amount
	description
	created_date
	create_user
	update_date
	update_user

}
