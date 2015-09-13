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
	private Long unitId;

	
	private String description;

	private Boolean enabled;

	@Column(name="unit_code")
	private String unitCode;

	@Column(name="unit_name")
	private String unitName;

	

	//bi-directional many-to-one association to Item
	@OneToMany(mappedBy="unit")
	private List<Item> items;

	public Unit() {
	}

	public Long getUnitId() {
		return this.unitId;
	}

	public void setUnitId(Long unitId) {
		this.unitId = unitId;
	}

	

	public String getDescription() {
		return this.description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public Boolean getEnabled() {
		return this.enabled;
	}

	public void setEnabled(Boolean enabled) {
		this.enabled = enabled;
	}

	public String getUnitCode() {
		return this.unitCode;
	}

	public void setUnitCode(String unitCode) {
		this.unitCode = unitCode;
	}

	public String getUnitName() {
		return this.unitName;
	}

	public void setUnitName(String unitName) {
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