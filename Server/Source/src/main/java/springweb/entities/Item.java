package springweb.entities;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQuery;
import javax.persistence.Table;

@Entity
@Table(name="item")
@NamedQuery(name="Item.findAll", query="SELECT c FROM Item c")
public class Item extends BaseEntity implements Serializable {
	
	
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="item_id")
	private Long itemId;
	
	@Column(name="item_code")
	private Object itemCode;
	
	@Column(name="item_name")
	private Object itemName;
	
	@Column(name="features")
	private Object features;
	
	@Column(name="specifications")
	private Object specifications;
	
	@ManyToOne
	@JoinColumn(name = "unit_id", nullable = true)
	private Unit unit;
	
	@ManyToOne
	@JoinColumn(name = "category_item_id", nullable = true)
	private CategoryItem categoryItem;
	
	public Long getItemId() {
		return itemId;
	}

	public void setItemId(Long itemId) {
		this.itemId = itemId;
	}

	public Object getItemCode() {
		return itemCode;
	}

	public void setItemCode(Object itemCode) {
		this.itemCode = itemCode;
	}

	public Object getItemName() {
		return itemName;
	}

	public void setItemName(Object itemName) {
		this.itemName = itemName;
	}

	public Object getFeatures() {
		return features;
	}

	public void setFeatures(Object features) {
		this.features = features;
	}

	public Object getSpecifications() {
		return specifications;
	}

	public void setSpecifications(Object specifications) {
		this.specifications = specifications;
	}

	public Object getUnit() {
		return unit;
	}

	public void setUnit(Unit unit) {
		this.unit = unit;
	}

	public CategoryItem getCategoryItem() {
		return categoryItem;
	}

	public void setCategoryItem(CategoryItem categoryItem) {
		this.categoryItem = categoryItem;
	}

	public boolean isEnabled() {
		return enabled;
	}

	public void setEnabled(boolean enabled) {
		this.enabled = enabled;
	}

	public Object getDescription() {
		return description;
	}

	public void setDescription(Object description) {
		this.description = description;
	}

	

	@Column(name="enabled")
	private boolean enabled;
	
	@Column(name="description")
	private Object description;

	
}
