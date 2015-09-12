package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Timestamp;


/**
 * The persistent class for the supplier database table.
 * 
 */
@Entity
@Table(name="supplier")
@NamedQuery(name="Supplier.findAll", query="SELECT s FROM Supplier s")
public class Supplier extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="supplier_id")
	private long supplierId;

	private Object description;

	private boolean enabled;

	@Column(name="supplier_code")
	private Object supplierCode;

	@Column(name="supplier_name")
	private Object supplierName;

	@Column(name="supplier_short_name")
	private Object supplierShortName;


	public Supplier() {
	}

	public long getSupplierId() {
		return this.supplierId;
	}

	public void setSupplierId(long supplierId) {
		this.supplierId = supplierId;
	}

	

	public Object getDescription() {
		return this.description;
	}

	public void setDescription(Object description) {
		this.description = description;
	}

	public boolean getEnabled() {
		return this.enabled;
	}

	public void setEnabled(boolean enabled) {
		this.enabled = enabled;
	}

	public Object getSupplierCode() {
		return this.supplierCode;
	}

	public void setSupplierCode(Object supplierCode) {
		this.supplierCode = supplierCode;
	}

	public Object getSupplierName() {
		return this.supplierName;
	}

	public void setSupplierName(Object supplierName) {
		this.supplierName = supplierName;
	}

	public Object getSupplierShortName() {
		return this.supplierShortName;
	}

	public void setSupplierShortName(Object supplierShortName) {
		this.supplierShortName = supplierShortName;
	}

}