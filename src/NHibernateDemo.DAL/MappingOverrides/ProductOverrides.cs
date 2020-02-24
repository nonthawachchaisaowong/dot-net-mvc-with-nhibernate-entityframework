﻿using FluentNHibernate.Automapping;
using FluentNHibernate.Automapping.Alterations;
using NHibernateDemo.Domain.Entities;

namespace NHibernateDemo.DAL.MappingOverrides
{
    public class ProductOverrides : IAutoMappingOverride<Product>
    {
        public void Override(AutoMapping<Product> mapping)
        {
        }
    }
}
