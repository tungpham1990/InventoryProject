package springweb.entities;

import javax.persistence.*;

/**
 * Created by MinhPK on 7/30/15.
 */

@MappedSuperclass
public abstract class BaseEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    @Column(name = "id")
    private Long id;

    @Version
    @Column(name = "version")
    private Integer version;
}
