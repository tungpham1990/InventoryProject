package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Timestamp;
import java.util.List;


/**
 * The persistent class for the unit database table.
 * 
 */
@Entity
@Table(name="unit")
@NamedQuery(name="Unit.findAll", query="SELECT u FROM Unit u")
public class Unit extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="unit_id")
	private long unitId;

	
	private Object description;

	private boolean enabled;

	@Column(name="unit_code")
	private Object unitCode;

	@Column(name="unit_name")
	private Object unitName;

	

	//bi-directional many-to-one association to Item
	@OneToMany(mappedBy="unit")
	private List<Item> items;

	public Unit() {
	}

	public long getUnitId() {
		return this.unitId;
	}

	public void setUnitId(long unitId) {
		this.unitId = unitId;
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

	public Object getUnitCode() {
		return this.unitCode;
	}

	public void setUnitCode(Object unitCode) {
		this.unitCode = unitCode;
	}

	public Object getUnitName() {
		return this.unitName;
	}

	public void setUnitName(Object unitName) {
		this.unitName = unitName;
	}

	

	public List<Item> getItems() {
		return this.items;
	}

	public void setItems(List<Item> items) {
		this.items = items;
	}

	public Item addItem(Item item) {
		getItems().add(item);
		item.setUnit(this);

		return item;
	}

	public Item removeItem(Item item) {
		getItems().remove(item);
		item.setUnit(null);

		return item;
	}

}