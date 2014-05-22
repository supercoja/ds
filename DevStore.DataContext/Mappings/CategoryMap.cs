using System.Data.Entity.ModelConfiguration;
using DevStore.Domain;

namespace DevStore.DataContext.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
// usar arquivo de configuração, dessa forma, não fica dentro do programa
            ToTable("Category");
            HasKey(k => k.Id);
            Property(p => p.Title).HasMaxLength(60).IsRequired();
        }
    }
}
