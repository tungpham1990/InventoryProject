package springweb.dtos;

import java.io.Serializable;

/**
 * Created by MinhPK on 8/1/15.
 */
public class BaseDTO implements Serializable {
    private static final long serialVersionUID = -112950002831333869L;

    private Long id;

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }
}
