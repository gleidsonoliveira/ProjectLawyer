using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectLawyer.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLawyer.Data.Mappings
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(100);
            builder.Property(u => u.CityCode).HasMaxLength(30);
            
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
            builder.HasOne(o => o.State).WithMany(c => c.Citys).HasForeignKey(c => c.StateId);
        }
    }
}
