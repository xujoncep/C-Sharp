namespace NhibernateFirstCrud.Mappings;
using NhibernateFirstCrud.Models.Entities;
using FluentNHibernate.Mapping;



public class RoleMap : ClassMap<Role>
{
    public RoleMap()
    {
        
        Id(x => x.Id);
        Map(x => x.Name);
        Table("Roles");
    }
}
