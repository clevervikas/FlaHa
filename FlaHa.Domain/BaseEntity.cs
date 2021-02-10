using FlaHa.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlaHa.Domain
{
    public abstract class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
    }
}
