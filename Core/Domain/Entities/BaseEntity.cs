using System;
using System.ComponentModel.DataAnnotations;

namespace test_deliverit.Core.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}