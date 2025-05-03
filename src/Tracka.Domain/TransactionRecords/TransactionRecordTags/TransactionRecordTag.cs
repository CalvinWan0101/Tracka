using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace Tracka.TransactionRecords.TransactionRecordTags;

public class TransactionRecordTag : FullAuditedAggregateRoot<Guid> {
    [Required]
    [Column(TypeName = "varchar(200)")]
    public string Name { get; set; }
}

