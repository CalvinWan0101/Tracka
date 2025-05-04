using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Tracka.TransactionRecordTags;

public class TransactionRecordTag : FullAuditedAggregateRoot<Guid> {
    [Required]
    public Guid UserId { get; set; }

    [Required]
    [Column(TypeName = "varchar(200)")]
    public string Name { get; set; }

    public string Description { get; set; }
}

