package springweb.entities;

import java.io.Serializable;
import java.util.List;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import com.fasterxml.jackson.annotation.JsonIgnore;


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
	private Long categoryItemId;

	@Column(name="category_item_code")
	private String categoryItemCode;

	@Column(name="category_item_name")
	private String categoryItemName;

	@Column(name="category_item_parent_id")
	private Long categoryItemParentId;

	private String description;

	private Boolean enabled;

	private String features;

	@Column(name="node_level")
	private int nodeLevel;

	private String specifications;

	

	//bi-directional many-to-one association to Item
	@OneToMany(mappedBy="categoryItem")
	@JsonIgnore
	private List<Item> items;

	public CategoryItem() {
	}

	public Long getCategoryItemId() {
		return this.categoryItemId;
	}

	public void setCategoryItemId(Long categoryItemId) {
		this.categoryItemId = categoryItemId;
	}

	public String getCategoryItemCode() {
		return this.categoryItemCode;
	}

	public void setCategoryItemCode(String categoryItemCode) {
		this.categoryItemCode = categoryItemCode;
	}

	public String getCategoryItemName() {
		return this.categoryItemName;
	}

	public void setCategoryItemName(String categoryItemName) {
		this.categoryItemName = categoryItemName;
	}

	public Long getCategoryItemParentId() {
		return this.categoryItemParentId;
	}

	public void setCategoryItemParentId(Long categoryItemParentId) {
		this.categoryItemParentId = categoryItemParentId;
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

	public String getFeatures() {
		return this.features;
	}

	public void setFeatures(String features) {
		this.features = features;
	}

	public int getNodeLevel() {
		return this.nodeLevel;
	}

	public void setNodeLevel(int nodeLevel) {
		this.nodeLevel = nodeLevel;
	}

	public String getSpecifications() {
		return this.specifications;
	}

	public void setSpecifications(String specifications) {
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