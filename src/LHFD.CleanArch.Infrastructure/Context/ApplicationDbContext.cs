using Microsoft.EntityFrameworkCore;

namespace LHFD.CleanArch.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Exemplo: guia para novas entidades:
        public DbSet<object> TEntity => Set<object>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            var entityTypes = modelBuilder.Model.GetEntityTypes()
                .Select(t => t.ClrType)
                .Where(t => !t.IsAbstract);

            foreach (var entityType in entityTypes)
            {
                var mappingInterface = typeof(IEntityTypeConfiguration<>).MakeGenericType(entityType);
                var hasMapping = typeof(ApplicationDbContext).Assembly.GetTypes()
                    .Any(t => mappingInterface.IsAssignableFrom(t));

                if (!hasMapping)
                {
                    throw new InvalidOperationException(
                        $"A entidade '{entityType.Name}' não possui uma classe de mapeamento " +
                        $"implementando IEntityTypeConfiguration<{entityType.Name}>. " +
                        $"O mapeamento explícito é obrigatório neste template.");
                }
            }
        }
    }
}