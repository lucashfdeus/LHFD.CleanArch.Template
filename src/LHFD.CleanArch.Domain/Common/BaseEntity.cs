namespace LHFD.CleanArch.Domain.Common
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; protected set; } = default!;
        public DateTime CreatedAt { get; protected set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; protected set; }

        public bool IsDeleted { get; private set; } = false;
        public DateTime? DeletedAt { get; private set; }

        public virtual void SoftDelete()
        {
            IsDeleted = true;
            DeletedAt = DateTime.UtcNow;
        }
    }
}