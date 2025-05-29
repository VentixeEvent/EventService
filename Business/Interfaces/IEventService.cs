using Business.Models;
using Business.Services;

namespace Business.Interfaces;

public interface IEventService
{
    Task<EventResult<Event?>> GetEventAsync(string eventId);
    Task<EventResult<IEnumerable<Event>>> GetEventsAsync();
    Task<EventResult> CreateEventAsync(CreateEventRequest request);
}
