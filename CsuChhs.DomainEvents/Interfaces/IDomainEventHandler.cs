namespace CsuChhs.DomainEvents.Interfaces
{
    public interface IDomainEventHandler<T> where T : IDomainEvent
    {
        Task HandleAsync(T domainEvent,
            CancellationToken cancellationToken = default);
    }
}