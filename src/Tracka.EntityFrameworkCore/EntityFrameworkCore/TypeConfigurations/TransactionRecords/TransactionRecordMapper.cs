using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tracka.TransactionRecords;

namespace Tracka.EntityFrameworkCore.TypeConfigurations.TransactionRecords;

internal class TransactionRecordMapper : BaseMapper<TransactionRecord> {
    public TransactionRecordMapper() : base("TransactionRecords") { }

    public override void Configure(EntityTypeBuilder<TransactionRecord> builder) {
        base.Configure(builder);
    }
};
