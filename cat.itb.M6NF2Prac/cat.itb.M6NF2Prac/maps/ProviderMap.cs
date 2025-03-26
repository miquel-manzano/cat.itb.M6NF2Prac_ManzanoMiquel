using cat.itb.M6NF2Prac.models;
using FluentNHibernate.Mapping;

namespace cat.itb.M6NF2Prac.maps
{
    public class ProviderMap : ClassMap<Provider>
    {
        public ProviderMap()
        {
            Table("provider");
            Id(x => x.ID);
            Map(x => x.Name).Column("name");
            Map(x => x.Address).Column("address");
            Map(x => x.City).Column("city");
            Map(x => x.StCode).Column("stcode");
            Map(x => x.ZipCode).Column("zipcode");
            Map(x => x.Area).Column("area");
            Map(x => x.Phone).Column("phone");
            References(x => x.Product)
                    .Column("product")
                    .Not.LazyLoad()
                    .Fetch.Join();
            Map(x => x.Amount).Column("amount");
            Map(x => x.Credit).Column("credit");
            Map(x => x.Remark).Column("remark");
        }
    }
}
