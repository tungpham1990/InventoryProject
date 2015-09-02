package springweb.entities;

import java.io.Serializable;
import javax.persistence.*;
import java.sql.Timestamp;
import java.util.List;


/**
 * The persistent class for the category_item database table.
 * 
 */
@Entity
@Table(name="category_item")
@NamedQuery(name="CategoryItem.findAll", query="SELECT c FROM CategoryItem c")
public class CategoryItem extends BaseEntity implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	@Column(name="category_item_id")
	private long categoryItemId;

	@Column(name="category_item_code")
	private Object categoryItemCode;

	@Column(name="category_item_name")
	private Object categoryItemName;

	@Column(name="category_item_parent_id")
	private long categoryItemParentId;

	private Object description;

	private boolean enabled;

	private Object features;

	@Column(name="node_level")
	private int nodeLevel;

	private Object specifications;

	

	//bi-directional many-to-one association to Item
	@OneToMany(mappedBy="categoryItem")
	private List<Item> items;

	public CategoryItem() {
	}

	public long getCategoryItemId() {
		return this.categoryItemId;
	}

	public void setCategoryItemId(long categoryItemId) {
		this.categoryItemId = categoryItemId;
	}

	public Object getCategoryItemCode() {
		return this.categoryItemCode;
	}

	public void setCategoryItemCode(Object categoryItemCode) {
		this.categoryItemCode = categoryItemCode;
	}

	public Object getCategoryItemName() {
		return this.categoryItemName;
	}

	public void setCategoryItemName(Object categoryItemName) {
		this.categoryItemName = categoryItemName;
	}

	public long getCategoryItemParentId() {
		return this.categoryItemParentId;
	}

	public void setCategoryItemParentId(long categoryItemParentId) {
		this.categoryItemParentId = categoryItemParentId;
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

	public Object getFeatures() {
		return this.features;
	}

	public void setFeatures(Object features) {
		this.features = features;
	}

	public int getNodeLevel() {
		return this.nodeLevel;
	}

	public void setNodeLevel(int nodeLevel) {
		this.nodeLevel = nodeLevel;
	}

	public Object getSpecifications() {
		return this.specifications;
	}

	public void setSpecifications(Object specifications) {
		this.specifications = specifications;
	}

	

	public List<Item> getItems() {
		return this.items;
	}

	public void setItems(List<Item> items) {
		this.items = items;
	}

	public Item addItem(Item item) {
		getItems().add(item);
		item.setCategoryItem(this);

		return item;
	}

	public Item removeItem(Item item) {
		getItems().remove(item);
		item.setCategoryItem(null);

		return item;
	}

}