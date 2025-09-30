namespace CsuChhs.DomainEvents.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task DispatchAsync<TEvent>(TEvent domainEvent,
            CancellationToken cancellationToken = default)
            where TEvent : IDomainEvent;
    }
}