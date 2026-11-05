using LHFD.CleanArch.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LHFD.CleanArch.Infrastructure
{

    public sealed class UnitOfWork<TContext> : IUnitOfWork, IDisposable where TContext : DbContext
    {
        private readonly TContext _context;

        public UnitOfWork(TContext context)
        {
            _context = context;
        }

        public async Task<bool> CommitAsync(CancellationToken cancellationToken = default)
        {
            var affectedRows = await _context.SaveChangesAsync(cancellationToken);
            return affectedRows > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}