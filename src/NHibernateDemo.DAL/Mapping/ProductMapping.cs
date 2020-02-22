using FluentNHibernate.Mapping;
using NHibernateDemo.Domain.Entities;

namespace NHibernateDemo.DAL.Mapping
{
    public sealed class ProductMapping : ClassMap<Product>
    {
        public ProductMapping()
        {
            LazyLoad();
            Table("Product");
            Id(p => p.Id);
            Id(p => p.Id).GeneratedBy.Identity();
            Map(p => p.Name);
            References(p => p.Category);
        }
    }
}
