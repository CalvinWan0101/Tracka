﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tracka.TransactionRecordTags;

namespace Tracka.EntityFrameworkCore.TypeConfigurations.TransactionRecordTags;

internal class TransactionRecordTagMapper : BaseMapper<TransactionRecordTag> {
    public TransactionRecordTagMapper() : base("TransactionRecordTags") { }

    public override void Configure(EntityTypeBuilder<TransactionRecordTag> builder) {
        base.Configure(builder);
    }
};
