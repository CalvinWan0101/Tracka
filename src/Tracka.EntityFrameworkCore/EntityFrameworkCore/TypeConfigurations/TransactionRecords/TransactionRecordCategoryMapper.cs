using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tracka.TransactionRecords.TransactionRecordCategorys;

namespace Tracka.EntityFrameworkCore.TypeConfigurations.TransactionRecords;

internal class TransactionRecordCategoryMapper : BaseMapper<TransactionRecordCategory> {
    public TransactionRecordCategoryMapper() : base("TransactionRecordCategorys") { }

    public override void Configure(EntityTypeBuilder<TransactionRecordCategory> builder) {
        base.Configure(builder);
    }
};
