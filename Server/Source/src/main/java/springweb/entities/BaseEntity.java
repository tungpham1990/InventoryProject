package springweb.entities;

import java.sql.Timestamp;

import javax.persistence.*;

/**
 * Created by MinhPK on 7/30/15.
 */

@MappedSuperclass
public abstract class BaseEntity {

	@Column(name="create_user")
	private Object createUser;

	@Column(name="created_date")
	private Timestamp createdDate;
	
	@Column(name="update_date")
	private Timestamp updateDate;

	@Column(name="update_user")
	private Object updateUser;
	
	public Object getCreateUser() {
		return createUser;
	}

	public void setCreateUser(Object createUser) {
		this.createUser = createUser;
	}

	public Timestamp getCreatedDate() {
		return createdDate;
	}

	public void setCreatedDate(Timestamp createdDate) {
		this.createdDate = createdDate;
	}

	public Timestamp getUpdateDate() {
		return updateDate;
	}

	public void setUpdateDate(Timestamp updateDate) {
		this.updateDate = updateDate;
	}

	public Object getUpdateUser() {
		return updateUser;
	}

	public void setUpdateUser(Object updateUser) {
		this.updateUser = updateUser;
	}
}
