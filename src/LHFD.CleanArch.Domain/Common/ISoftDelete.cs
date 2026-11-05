namespace LHFD.CleanArch.Domain.Common
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; }
        DateTime? DeletedAt { get; }
        void SoftDelete();
    }
}