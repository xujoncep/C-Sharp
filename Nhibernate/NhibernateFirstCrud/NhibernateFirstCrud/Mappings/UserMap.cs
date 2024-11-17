using FluentNHibernate.Mapping;
using NhibernateFirstCrud.Models.Entities;

namespace NhibernateFirstCrud.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Email);
            References(x => x.Role)
                .Cascade.All();
            Table("Users");
        }
    }
}
