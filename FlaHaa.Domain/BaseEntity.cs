
using FlaHa.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlaHa.Domain
{
    public abstract class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
