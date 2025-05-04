using System;
using Volo.Abp.Application.Dtos;

namespace Tracka.TransactionRecordCategorys;

public class TransactionRecordCategoryDto : FullAuditedEntityDto<Guid> {
    public Guid UserId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}

