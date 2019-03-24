﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajuine.DomainModel.Specifications;

namespace Cajuine.DomainModel.Entities
{
    public abstract class EntityBase : IEntityValidation
    {
        public Guid Id { get; set; }

        public virtual bool IsValid()
        {
            return true;
        }
    }
}
