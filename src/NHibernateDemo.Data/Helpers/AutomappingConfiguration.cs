using FluentNHibernate.Automapping;
using NHibernateDemo.Domain.Entities;
using System;

namespace NHibernateDemo.Domain.Helpers
{
    public class AutomappingConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.GetInterface(typeof(IEntity).FullName) != null;
        }
    }
}
