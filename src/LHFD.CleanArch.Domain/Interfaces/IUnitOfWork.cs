namespace LHFD.CleanArch.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync(CancellationToken cancellationToken = default);
    }
}