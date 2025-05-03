using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tracka.TransactionRecords.TransactionRecordTags;

namespace Tracka.EntityFrameworkCore.TypeConfigurations.TransactionRecords;

internal class TransactionRecordTagMapper : BaseMapper<TransactionRecordTag> {
    public TransactionRecordTagMapper() : base("TransactionRecordTags") { }

    public override void Configure(EntityTypeBuilder<TransactionRecordTag> builder) {
        base.Configure(builder);
    }
};
