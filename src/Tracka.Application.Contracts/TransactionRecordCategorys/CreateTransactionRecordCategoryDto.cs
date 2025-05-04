using System;

namespace Tracka.TransactionRecordCategorys;

public class CreateTransactionRecordCategoryDto {
    public Guid UserId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}
