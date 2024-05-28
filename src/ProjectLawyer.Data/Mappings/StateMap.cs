using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectLawyer.Domain.Entity;

namespace ProjectLawyer.Data.Mappings
{
    public class StateMap : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("State");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Uf).IsRequired().HasMaxLength(2);
            builder.Property(u => u.StateCode).HasMaxLength(30);

            #region Padrão
            builder.Property(u => u.CreatedDate).HasComment("Grava a data da criação do registro");
            builder.Property(u => u.CreatedUserId).HasComment("Grava o id do usuário que realizo a criação do registro");

            builder.Property(u => u.ModifiedDate).HasComment("Grava a data da modifição do registro");
            builder.Property(u => u.ModifiedUserId).HasComment("Grava o id do usuário que realizo a modifição do registro");

            builder.Property(u => u.DeletedDate).HasComment("Grava da exclusão do registro");
            builder.Property(u => u.DeletedUserId).HasComment("Grava o id do usuário que realizo a exclusão do registro");

            builder.Property(u => u.Observation).HasMaxLength(2000);

            //Enum
            builder.Property(u => u.Situation).IsRequired().HasDefaultValueSql("0");
            #endregion

            //Relacionamento
            builder.HasMany(o => o.Citys).WithOne(c => c.State);
        }
    }
}
