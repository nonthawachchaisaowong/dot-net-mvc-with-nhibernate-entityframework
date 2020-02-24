using FluentNHibernate.Mapping;
using NHibernateDemo.Domain.Entities;

namespace NHibernateDemo.DAL.Mappings
{
    public sealed class CategoryMapping : ClassMap<Category>
    {
        public CategoryMapping()
        {
            LazyLoad();
            Table("Category");
            Id(c => c.Id);
            Id(c => c.Id).GeneratedBy.Identity();
            Map(c => c.Name);
        }
    }
}
