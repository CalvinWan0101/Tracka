using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Domain.Entities.Auditing;

namespace Tracka.TransactionRecords;

public class TransactionRecord : FullAuditedEntity<Guid> {
    public string Description { get; set; }

    public long Amount { get; set; }
    
    [Required]
    public Guid CategoryId { get; set; }
    
    public List<Guid> TagIds { get; set; } = new List<Guid>();
}

