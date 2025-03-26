using cat.itb.M6NF2Prac.models;
using FluentNHibernate.Mapping;

namespace cat.itb.M6NF2Prac.maps
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("product");
            Id(x => x.ID);
            Map(x => x.Code).Column("code");
            Map(x => x.Description).Column("description");
            Map(x => x.CurrentStock).Column("currentstock");
            Map(x => x.MinStock).Column("minstock");
            Map(x => x.Price).Column("price");
            References(x => x.SalesP)
                    .Column("salesperson")
                    .Not.LazyLoad()
                    .Fetch.Join();
            HasOne(x => x.ProductRef)
                .PropertyRef(nameof(Product.ID))
                .Not.LazyLoad()
                .Cascade.AllDeleteOrphan();
        }
    }
}
