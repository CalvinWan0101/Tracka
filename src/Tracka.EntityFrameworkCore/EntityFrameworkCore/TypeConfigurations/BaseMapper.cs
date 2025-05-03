using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp.Domain.Entities;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Tracka.EntityFrameworkCore.TypeConfigurations;

internal class BaseMapper<T> : IEntityTypeConfiguration<T> where T : Entity {
    private readonly string _tableName;

    public BaseMapper(string tableName) {
        _tableName = tableName;
    }

    public virtual void Configure(EntityTypeBuilder<T> builder) {
        builder.ToTable(_tableName);
        builder.ConfigureByConvention();
    }
}

