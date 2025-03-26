using cat.itb.M6NF2Prac.models;
using FluentNHibernate.Mapping;

namespace cat.itb.M6NF2Prac.maps
{
    public class OrderprodMap : ClassMap<Orderprod>
    {
        public OrderprodMap()
        {
            Table("orderprod");
            Id(x => x.ID);
            References(x => x.Product)
                .Column("product")
                .Not.LazyLoad()
                .Fetch.Join();
            References(x => x.Client)
                .Column("client")
                .Not.LazyLoad()
                .Cascade.AllDeleteOrphan()
                .Fetch.Join();//maybe esta mal
            Map(x => x.Orderdate).Column("orderdate");
            Map(x => x.Amount).Column("amount");
            Map(x => x.DeliveryDate).Column("deliverydate");
            Map(x => x.Cost).Column("cost");
        }
    }
}
