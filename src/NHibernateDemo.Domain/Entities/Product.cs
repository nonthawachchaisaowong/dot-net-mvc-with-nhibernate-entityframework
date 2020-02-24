namespace NHibernateDemo.Domain.Entities
{
    public class Product : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Category Category { get; set; }
    }
}
