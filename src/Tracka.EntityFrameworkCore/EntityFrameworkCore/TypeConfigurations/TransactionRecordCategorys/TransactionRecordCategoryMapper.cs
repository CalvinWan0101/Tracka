using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tracka.TransactionRecordCategorys;

namespace Tracka.EntityFrameworkCore.TypeConfigurations.TransactionRecordCategorys;

internal class TransactionRecordCategoryMapper : BaseMapper<TransactionRecordCategory> {
    public TransactionRecordCategoryMapper() : base("TransactionRecordCategorys") { }

    public override void Configure(EntityTypeBuilder<TransactionRecordCategory> builder) {
        base.Configure(builder);
    }
};
