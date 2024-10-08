﻿using CMS.Core.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Infrastructure.Data.Extensions
{
    internal static class ModelBuilderExtentions
    {
        public static void RegisterAllEntities<BaseType>(this ModelBuilder modelBuilder,
                                                    params Assembly[] assemblies) where BaseType : IEntity
        {
            IEnumerable<Type> types = assemblies.SelectMany(a => a.GetExportedTypes())
                .Where(c => c.IsClass && !c.IsAbstract && c.IsPublic);

            foreach (var type in types)
            {
                modelBuilder.Entity(type);
            }
        }
    }
}
