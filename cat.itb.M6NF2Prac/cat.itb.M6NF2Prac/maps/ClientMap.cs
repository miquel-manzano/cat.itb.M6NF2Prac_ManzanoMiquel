using cat.itb.M6NF2Prac.models;
using FluentNHibernate.Mapping;

namespace cat.itb.M6NF2Prac.maps
{
    public class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            Table("client");
            Id(x => x.ID);
            Map(x => x.Code).Column("code");
            Map(x => x.Name).Column("name");
            Map(x => x.Credit).Column("credit");
            HasOne(x => x.ClientRef)
                .PropertyRef(nameof(Client.ID))
                .Not.LazyLoad()
                .Cascade.AllDeleteOrphan();
        }
    }
}
