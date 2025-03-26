using cat.itb.M6NF2Prac.models;
using FluentNHibernate.Mapping;

namespace cat.itb.M6NF2Prac.maps
{
    public class SalespersonMap : ClassMap<Salesperson>
    {
        public SalespersonMap()
        {
            Table("salesperson");
            Id(x => x.ID);
            Map(x => x.Surename).Column("surename");
            Map(x => x.Job).Column("job");
            Map(x => x.StartDate).Column("startdate");
            Map(x => x.Salary).Column("salary");
            Map(x => x.Commission).Column("commission");
            Map(x => x.Dep).Column("dep");
            // Reference from Product
            HasOne(x => x.SalespersonRef)
                .PropertyRef(nameof(Salesperson.ID))
                .Not.LazyLoad()
                .Cascade.AllDeleteOrphan();
        }
    }
}
