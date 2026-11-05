using LHFD.CleanArch.Domain.Interfaces;
using LHFD.CleanArch.Infrastructure.Context;

namespace LHFD.CleanArch.Infrastructure;

public sealed class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
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